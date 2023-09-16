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
    public class DepartmentServ
    {
        private string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public DataTable GetDepartmentList()
        {
            string sql = "select * from Department";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dt);
                return dt;
            }
        }

        public bool Add(string deptname)
        {

            string sql = "insert into Department values(@Id,@Name)";

            SqlParameter[] parameters = {new SqlParameter("@Id",Guid.NewGuid()),
                                         new SqlParameter("@Name",deptname)

            };

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(parameters);
                conn.Open();
                return comm.ExecuteNonQuery() > 0;
            }
        }

        public bool Del(string deptname)
        {

            string sql = "delete from Department where  Name = @Name";

            SqlParameter parameter = new SqlParameter("@Name", deptname);

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.Add(parameter);
                conn.Open();
                return comm.ExecuteNonQuery() > 0;
            }
        }
    }
}
