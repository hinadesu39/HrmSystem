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
    public class SalarySheetItemServ
    {
        SalarySheetServ salSheetServ = new SalarySheetServ();
        public DataTable GetSalarySheet(SalarySheet sheet)
        {
            string sql = "select SalarySheetItem.Id as 编号, Employee.Name as 姓名, SalarySheetItem.BaseSalary as 基本工资, SalarySheetItem.Bonus as 奖金, SalarySheetItem.Fine as 罚款, SalarySheetItem.Other as 其他 from SalarySheetItem,Employee where SalarySheetItem.SheetId = @Id and Employee.Id = SalarySheetItem.EmployeeId";
            SqlParameter para = new SqlParameter("@Id", sheet.Id);
            return SqlHelper.DataAdapter_dt(sql, para);
        }

        public DataTable GetPrintSalarySheet(SalarySheet sheet)
        {
            string sql = "select Employee.Name as name, SalarySheetItem.BaseSalary as baseSalary, SalarySheetItem.Bonus as bonus, SalarySheetItem.Fine as fine, SalarySheetItem.Other as other from SalarySheetItem,Employee where SalarySheetItem.SheetId = @Id and Employee.Id = SalarySheetItem.EmployeeId";
            SqlParameter para = new SqlParameter("@Id", sheet.Id);
            return SqlHelper.DataAdapter_dt(sql, para);
        }
        public void BuildNewSalarySheetItems(Guid sheetId,Guid deptId)
        {
            string sqlId = "select Id from Employee where DepartmentId = @deptId";
            string sql = "insert into SalarySheetItem (Id,SheetId,EmployeeId,BaseSalary,Bonus,Fine,Other) values(@Id,@SheetId,@EmployeeId,0,0,0,0)";
            SqlParameter para = new SqlParameter("@deptId", deptId);
            SqlDataReader sdr = SqlHelper.ExecuteReader(sqlId, para);
            while (sdr.Read())
            {
                SqlParameter[] paras = {new SqlParameter("@Id",Guid.NewGuid()),
                                        new SqlParameter("@SheetId",sheetId),
                                        new SqlParameter("@EmployeeId",sdr["Id"])};
                SqlHelper.ExecuteNonQuery(sql, paras);
            }
            
        }

        public void RebuildSalarySheetItems(Guid sheetId)
        {
            
            string sql = "update SalarySheetItem set BaseSalary=0,Bonus=0,Fine=0,Other=0 where sheetId = @Id";
            SqlParameter para = new SqlParameter("@Id", sheetId);
            SqlHelper.ExecuteNonQuery(sql,para);
        }

        public void SaveSheetItems(DataTable dt)
        {
            SalarySheetItem item = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new SalarySheetItem();
                item.Id = (Guid)dt.Rows[i][0];
                item.BaseSalary = (decimal)dt.Rows[i][2];
                item.Bonus = (decimal)dt.Rows[i][3];
                item.Fine = (decimal)dt.Rows[i][4];
                item.Other = (decimal)dt.Rows[i][5];
                string sql = "update SalarySheetItem set BaseSalary=@BaseSalary,Bonus=@Bonus,Fine=@Fine,Other=@Other where Id = @Id";
                SqlParameter[] paras = {new SqlParameter("@BaseSalary",item.BaseSalary),
                                        new SqlParameter("@Bonus",item.Bonus),
                                        new SqlParameter("@Fine",item.Fine),
                                        new SqlParameter("@Other",item.Other),
                                        new SqlParameter("@Id",item.Id)};
                SqlHelper.ExecuteNonQuery(sql, paras);                
                
                                
            }




                                    
        }
    }
}
