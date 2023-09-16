using HrmSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem.DAL
{
    public class SalarySheetServ
    {
        public Guid GetSalarySheetId(SalarySheet sheet)
        {
            string sql = "select Id from SalarySheet where Year = @Year and Month = @Month and DepartmentId = @DepartmentId";
            SqlParameter[] paras = { new SqlParameter("@Year",sheet.Year),
                                     new SqlParameter("@Month",sheet.Month),
                                     new SqlParameter("@DepartmentId",sheet.DepartmentId)};
            var Id = SqlHelper.ExecuteScalar(sql, paras);
            if(Id != null)
            {
                return (Guid)Id;
            }
            else
            {
                return Guid.Empty;
            }
        }

        public void BuildNewSalarySheetId(SalarySheet sheet)
        {
            string sql = "insert into SalarySheet(Id,Year,Month,DepartmentId)values(@Id,@Year,@Month,@DepartmentId)";
            SqlParameter[] paras = { new SqlParameter("@Id",sheet.Id),
                                     new SqlParameter("@Year",sheet.Year),
                                     new SqlParameter("@Month",sheet.Month),
                                     new SqlParameter("@DepartmentId",sheet.DepartmentId)};
            SqlHelper.ExecuteNonQuery(sql, paras);
        }



    }
}
