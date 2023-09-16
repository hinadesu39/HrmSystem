using HrmSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem.BLL
{
    public class PwdChange
    {
        public static bool ChangePwd(LoginUser lu, string newPwd)
        {
            string sql = "update Operator set Password = @Password where UserName = @UserName";
            SqlParameter[] paras = {new SqlParameter("@Password",newPwd),
                                    new SqlParameter("@UserName",lu.UserName)};
            return SqlHelper.ExecuteNonQuery(sql, paras) > 0;
        }
    }
}
