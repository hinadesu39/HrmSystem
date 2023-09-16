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
    
    public class EmpolyeeServ
    {
        DataTable dt = new DataTable();

        public DataTable GetDept()
        {
            string sql = "select * from Department";
            return SqlHelper.DataAdapter_dt(sql);
        }
        public DataTable GetInfo(string where)
        {
            string sql = "SELECT * from Dictionary where Category = @where";
            SqlParameter para = new SqlParameter("@where", where);
            return SqlHelper.DataAdapter_dt(sql,para);
        }

        public DataTable GetEmpolyee()
        {
            string sql = "SELECT Id as 编号,Number as 工号,Name as 姓名, InDay as 入职时间,Nation as 民族, NativePlace as 籍贯 FROM Employee";
            return SqlHelper.DataAdapter_dt(sql);
        }

        public Employee GetEmpolyee(Guid Id)
        {
            string sql = "SELECT * FROM Employee where Id = @Id";
            SqlParameter para = new SqlParameter("@Id",Id);
            DataTable dt = SqlHelper.DataAdapter_dt(sql,para);
            Employee emp = new Employee();
            DataRow row = dt.Rows[0];
            if (dt.Rows.Count > 0)
            {
                
                emp.Name = row["Name"].ToString();
                emp.InDay = (DateTime)row["InDay"];
                emp.NativePlace = row["NativePlace"].ToString();
                emp.Address = row["Address"].ToString();
                emp.Email = row["Email"].ToString();
                emp.Number = row["Number"].ToString();
                emp.GenderId = (Guid)row["GenderId"];
                emp.PartyId = (Guid)row["PartyId"];
                emp.MarriageId = (Guid)row["MarriageId"];
                emp.EducationId = (Guid)row["EducationId"];
                emp.DepartmentId = (Guid)row["DepartmentId"];
                emp.Telephone = row["Telephone"].ToString();
                emp.BirthDay = (DateTime)row["BirthDay"];
                emp.Nation = row["Nation"].ToString();
                emp.Remarks = row["Remarks"].ToString();
                emp.Id = (Guid)row["Id"];
                //emp.Photo = (byte[])row["Photo"];
                emp.Resume = row["Resume"].ToString();
            }
            if(row["Photo"] != DBNull.Value)
            {
                emp.Photo = (byte[])row["Photo"];
            }
            else
            {
                emp.Photo = null;
            }
            return emp;
        }

        public DataTable GetEmpolyee(EmployeeSearchWhere esw)
        {
            string sql = "SELECT Id as 编号,Number as 工号,Name as 姓名, InDay as 入职时间,Nation as 民族, NativePlace as 籍贯 FROM Employee";

            List<SqlParameter> whereParas = new List<SqlParameter>();
            if(esw != null){
                List<string> whereStr = new List<string>();

                if (!string.IsNullOrEmpty(esw.Name))
                {
                    whereStr.Add(string.Format("Name like N'%' + @Name + '%'"));
                    whereParas.Add(new SqlParameter("@Name", esw.Name));
                }
                if (esw.IsDateExit)
                {
                    whereStr.Add(string.Format("InDay >= @Begin and InDay <= @End"));
                    whereParas.Add(new SqlParameter("@Begin", esw.Begin));
                    whereParas.Add(new SqlParameter("@End", esw.End));
                }

                if(esw.Dept != Guid.Empty)
                {
                    whereStr.Add(string.Format("DepartMentId = @Dept"));
                    whereParas.Add(new SqlParameter("@Dept", esw.Dept));
                }

                string sqlStr = string.Join("AND", whereStr);
                if(sqlStr != null && sqlStr.Length > 0)
                {
                    sql += " where " + sqlStr;
                }
            }
            return SqlHelper.DataAdapter_dt(sql,whereParas.ToArray());
        }

        public bool AddEmployee(Employee emp)
        {
            string sql = "insert into Employee values(@Id,@Number,@Name,@BirthDay,@InDay,@MarriageId,@PartyId,@EducationId,@GenderId,@DepartmentId,@Telephone,@Address,@Email,@Remarks,@Resume,@Photo,@Nation,@NativePlace)";
            SqlParameter[] parameters = {new SqlParameter("@Id",emp.Id),
                                         new SqlParameter("@Number",emp.Number),
                                         new SqlParameter("@Name",emp.Name),
                                         new SqlParameter("@BirthDay",emp.BirthDay),
                                         new SqlParameter("@InDay",emp.InDay),
                                         new SqlParameter("@MarriageId",emp.MarriageId),
                                         new SqlParameter("@PartyId",emp.PartyId),
                                         new SqlParameter("@EducationId",emp.EducationId),
                                         new SqlParameter("@GenderId",emp.GenderId),
                                         new SqlParameter("@DepartmentId",emp.DepartmentId),
                                         new SqlParameter("@Telephone",emp.Telephone),
                                         new SqlParameter("@Address",emp.Address),
                                         new SqlParameter("@Email",emp.Email),
                                         new SqlParameter("@Remarks",emp.Remarks),
                                         new SqlParameter("@Resume",emp.Resume),
                                         new SqlParameter("@Nation",emp.Nation),
                                         new SqlParameter("@NativePlace",emp.NativePlace)};
            SqlParameter paramPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            if (emp.Photo == null)
            {
                paramPhoto.Value = DBNull.Value;
            }
            else
            {
                paramPhoto.Value = emp.Photo;
            }

            List<SqlParameter> list = new List<SqlParameter>(parameters);
            list.Add(paramPhoto);
            parameters = list.ToArray();
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;

        }

        public bool EditEmployee(Employee emp)
        {
            string sql = "update Employee set Number = @Number,Name = @Name,BirthDay = @BirthDay,InDay=@InDay,MarriageId=@MarriageId,PartyId=@PartyId,EducationId=@EducationId,GenderId=@GenderId,DepartmentId=@DepartmentId,Telephone=@Telephone,Address=@Address,Email=@Email,Remarks=@Remarks,Resume=@Resume,Photo=@Photo,Nation=@Nation,NativePlace=@NativePlace where Id = @Id";
            SqlParameter[] parameters = {new SqlParameter("@Id",emp.Id),
                                         new SqlParameter("@Number",emp.Number),
                                         new SqlParameter("@Name",emp.Name),
                                         new SqlParameter("@BirthDay",emp.BirthDay),
                                         new SqlParameter("@InDay",emp.InDay),
                                         new SqlParameter("@MarriageId",emp.MarriageId),
                                         new SqlParameter("@PartyId",emp.PartyId),
                                         new SqlParameter("@EducationId",emp.EducationId),
                                         new SqlParameter("@GenderId",emp.GenderId),
                                         new SqlParameter("@DepartmentId",emp.DepartmentId),
                                         new SqlParameter("@Telephone",emp.Telephone),
                                         new SqlParameter("@Address",emp.Address),
                                         new SqlParameter("@Email",emp.Email),
                                         new SqlParameter("@Remarks",emp.Remarks),
                                         new SqlParameter("@Resume",emp.Resume),
                                         new SqlParameter("@Nation",emp.Nation),
                                         new SqlParameter("@NativePlace",emp.NativePlace)};
            SqlParameter paramPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            if (emp.Photo == null)
            {
                paramPhoto.Value = DBNull.Value;
            }
            else
            {
                paramPhoto.Value = emp.Photo;
            }

            List<SqlParameter> list = new List<SqlParameter>(parameters);
            list.Add(paramPhoto);
            parameters = list.ToArray();
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool DelEmployee(Guid Id)
        {
            string sql = "delete from Employee where Id = @Id";
            SqlParameter para = new SqlParameter("@Id", Id);

            return SqlHelper.ExecuteNonQuery(sql,para) > 0;
        }
    }
}
