using HrmSystem.Model;
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
    public class SqlHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public static object ExecuteScalar(string sql,params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(parameters);
                return comm.ExecuteScalar();
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {           
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(parameters);
                conn.Open();
                return comm.ExecuteNonQuery();
            }
        }
        public static DataTable DataAdapter_dt(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.SelectCommand.Parameters.AddRange(parameters);               
                sda.Fill(dt);                
            }

            return dt;
        }

        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameters)
        {

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            return comm.ExecuteReader(CommandBehavior.CloseConnection);
                
        }

        public static DataSet DataAdapter_ds(string sql, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.SelectCommand.Parameters.AddRange(parameters);

                sda.Fill(ds);
            }

            return ds;
        }

    }
}
