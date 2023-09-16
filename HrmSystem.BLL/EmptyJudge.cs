using HrmSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrmSystem.DAL;
using System.Data.SqlClient;

namespace HrmSystem.BLL
{
    public class EmptyJudge
    {
        
        public bool isEmployeeExist(SalarySheet salSheet)
        {
            
            string sql = "select count(*) from Employee where DepartmentId = @DeptId";
            SqlParameter para = new SqlParameter("@DeptId", salSheet.DepartmentId);
            return (int)SqlHelper.ExecuteScalar(sql, para) > 0;
            
        }
        public bool isSheetExist(SalarySheet salSheet)
        {
            string sql = "select count(*) from SalarySheet where Year = @Year and Month = @Month and DepartmentId = @DeptId";
            SqlParameter[] parameters ={ new SqlParameter("@Year",salSheet.Year),
                                         new SqlParameter("@Month",salSheet.Month),
                                         new SqlParameter("@DeptId",salSheet.DepartmentId)

                                       };

            return (int)SqlHelper.ExecuteScalar(sql, parameters) > 0;
        }

    }
}
