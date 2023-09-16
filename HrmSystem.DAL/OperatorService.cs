using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HrmSystem.Model;
using System.Data.SqlClient;
using System.Data;

namespace HrmSystem.DAL
{
    public class OperatorService
    {
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public Operator GetOperator(string un)
        {
            Operator op = null;
            string sql = "SELECT * from Operator where UserName = @UserName";
            SqlParameter paraUserName = new SqlParameter("@UserName", un);

            SqlDataReader sdr = SqlHelper.ExecuteReader(sql, paraUserName);
            if (sdr.Read())
            {
                op = new Operator();
                op.Id = (Guid)sdr["Id"];
                op.UserName = sdr["UserName"].ToString();
                op.Password = sdr["Password"].ToString();
                op.IsDeleted = (bool)sdr["IsDeleted"];
                op.RealName = sdr["RealName"].ToString();
                op.IsLocked = (bool)sdr["IsLocked"];
                op.IsAdmin = (bool)sdr["IsAdmin"];
            }

            sdr.Close();
            return op;
            
            
        }

        public bool AddOperator(Operator op)
        {
            string sql = "insert into Operator (Id,UserName,Password,IsDeleted,RealName,IsLocked,IsAdmin) values(@Id,@Username,@Password,0,@Realname,0,0)";
            SqlParameter[] paras = {new SqlParameter ("@Id",Guid.NewGuid()),
                                    new SqlParameter("@Username",op.UserName),
                                    new SqlParameter("@Password",op.Password),
                                    new SqlParameter("@RealName",op.RealName)};

            return SqlHelper.ExecuteNonQuery(sql, paras) > 0;
         }

        public Operator GetOpById(Guid Id)
        {
            string sql = "SELECT UserName ,IsDeleted ,RealName ,IsLocked ,IsAdmin FROM Operator where Id = @Id";
            SqlParameter para = new SqlParameter("@Id", Id);
            DataTable dt = SqlHelper.DataAdapter_dt(sql, para);
            Operator op = new Operator();
            DataRow row = dt.Rows[0];
            if (dt.Rows.Count > 0)
            {
                op.UserName = row["UserName"].ToString();
                op.RealName = row["RealName"].ToString();
                op.IsLocked = (bool)row["IsLocked"];
                op.IsDeleted = (bool)row["IsDeleted"];
                op.IsAdmin = (bool)row["IsAdmin"];
            }
            return op;

        }
        public DataTable GetOpList()
        {
            string sql = "select Id as Id, UserName as 用户名,IsDeleted as 是否删除,RealName as 真实姓名,IsLocked as 是否锁定,IsAdmin as 是否为管理员 from Operator";
            return SqlHelper.DataAdapter_dt(sql);
        }
        public bool DelOp(Guid Id)
        {
            string sql = "update Operator set IsDeleted = 1 where Id = @Id";
            SqlParameter para = new SqlParameter("@Id", Id);
            return SqlHelper.ExecuteNonQuery(sql, para) > 0;
        }

        public bool UpdateOp(Operator op)
        {
            string sql = "update Operator set UserName=@Username,IsDeleted=@IsDeleted,RealName=@Realname,IsLocked=@IsLocked,IsAdmin=@IsAdmin where Id = @Id";
            SqlParameter[] paras = {new SqlParameter("@Id",op.Id),
                                    new SqlParameter("@Username",op.UserName),
                                    new SqlParameter("@IsDeleted",op.IsDeleted),
                                    new SqlParameter("@RealName",op.RealName),
                                    new SqlParameter("@IsLocked",op.IsLocked),
                                    new SqlParameter("@IsAdmin",op.IsAdmin)};
            return SqlHelper.ExecuteNonQuery(sql, paras) > 0;
        }
    }
}
