using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem.DAL
{
    public class LogMigrationServ
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public bool LogMigration(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                SqlTransaction tran = conn.BeginTransaction();
                comm.Transaction = tran;
                try
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OprationLogBackup]') AND type in (N'U')) BEGIN SELECT* INTO OprationLogBackup FROM OperationLog WHERE 1 = 2 END";
                    comm.CommandTimeout = 30;//设置超时时间                    
                    comm.ExecuteNonQuery();
                    comm.CommandText = "DELETE FROM OprationLogBackup";
                    comm.ExecuteNonQuery();
                    comm.CommandText = "INSERT INTO OprationLogBackup SELECT * FROM OperationLog WHERE ActionDate < @date";
                    SqlParameter para = new SqlParameter("@date", date);
                    comm.Parameters.Add(para);
                    comm.ExecuteNonQuery();

                    tran.Commit();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    
                    tran.Rollback();                   
                    return false;
                    throw ex;
                }
                
            }
        }
    }
}
