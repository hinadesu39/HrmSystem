using HrmSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmSystem.DAL
{
    public class OperationLogServ
    {
        private string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public OperationLogServ()
        {

        }

        public DataTable GetRealName()
        {
            string sql = "select RealName,Id from Operator";
            return SqlHelper.DataAdapter_dt(sql);
        }
        public bool Add(OperationLog log)
        {

            string sql = "insert into OperationLog values(@Id,@OperatorId,@ActionDate,@ActionDesc)";

            SqlParameter[] parameters = {new SqlParameter("@Id",log.id),
                                         new SqlParameter("@OperatorId",log.OperatorId),
                                         new SqlParameter("@ActionDate",log.ActionDate),
                                         new SqlParameter("@ActionDesc",log.ActionDesc)

            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;

        }

        public DataTable GetOperationLogList(int pageNo, int numPage)
        {
            string sql = "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员, Temp.ActionDate AS 操作时间, Temp.ActionDesc AS 描述 FROM (SELECT TOP(@LogNum) * FROM OperationLog WHERE Id NOT IN(SELECT TOP(@BeforeNum) Id FROM OperationLog)) AS Temp, Operator WHERE Temp.OperatorId = Operator.Id";
            SqlParameter paraLogNum = new SqlParameter("@LogNum", numPage);
            SqlParameter paraBeforeNum = new SqlParameter("@BeforeNum", (pageNo - 1) * numPage);

            return SqlHelper.DataAdapter_dt(sql, paraLogNum, paraBeforeNum);
        }



        public int GetTotalPages(int NUM_PER_PAGE)
        {
            string sql = "select count(*) from OperationLog";
            return (int)Math.Ceiling((int)SqlHelper.ExecuteScalar(sql) * 1.0 / NUM_PER_PAGE);

        }

        



        public DataTable GetOperationLogList(int pageNo, int numPage,LogSearchWhere lsw)
        {
            string sql = "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员, Temp.ActionDate AS 操作时间, Temp.ActionDesc AS 描述 FROM (SELECT TOP(@LogNum) * FROM OperationLog WHERE Id NOT IN(SELECT TOP(@BeforeNum) Id FROM OperationLog)) AS Temp, Operator";
            List<SqlParameter> whereParas = new List<SqlParameter>();
            whereParas.Add(new SqlParameter("@LogNum", numPage));
            whereParas.Add(new SqlParameter("@BeforeNum", (pageNo - 1) * numPage));
            if (lsw != null)
            {
                List<string> whereStr = new List<string>();
                if (lsw.Name!=Guid.Empty)
                {
                    whereStr.Add(string.Format("Temp.OperatorId = @Name")); //"Operator.RealName like N'%' + @Name + '%'"
                    whereParas.Add(new SqlParameter("@Name", lsw.Name));
                }

                if(lsw.IsDateExit)
                {
                    whereStr.Add(string.Format("Temp.ActionDate >= @Begin AND Temp.ActionDate <= @End"));
                    whereParas.Add(new SqlParameter("@Begin", lsw.Begin));
                    whereParas.Add(new SqlParameter("@End", lsw.End));
                }

                if (!string.IsNullOrEmpty(lsw.Key))
                {
                    whereStr.Add(string.Format("Temp.ActionDesc = @key"));
                    whereParas.Add(new SqlParameter("@Key", lsw.Key));
                }

                string sqlStr = string.Join(" AND ", whereStr);
                if (sqlStr != null && sqlStr.Length > 0)
                {
                    sql += " Where " + sqlStr;
                }
            }
            return SqlHelper.DataAdapter_dt(sql, whereParas.ToArray());

        }
    }
}
