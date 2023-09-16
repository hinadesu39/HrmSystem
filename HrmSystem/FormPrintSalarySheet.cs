using HrmSystem.BLL;
using HrmSystem.DAL;
using HrmSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmSystem
{
    public partial class FormPrintSalarySheet : Form
    {
        EmpolyeeServ empServ = new EmpolyeeServ();
        public FormPrintSalarySheet()
        {
            InitializeComponent();
        }

        
        private void FormPrintSalarySheet_Load(object sender, EventArgs e)
        {
           
            comboBoxDept.DataSource = empServ.GetDept();            
            comboBoxDept.DisplayMember = "Name";
            comboBoxDept.ValueMember = "Id";
            comboBoxDept.SelectedIndex = 0;


            DataTable dtMonth = new DataTable();
            dtMonth.Columns.Add("Month");
            dtMonth.Columns.Add("Value");
            for (int i = 1; i <= 12; i++)
            {
                DataRow dr = dtMonth.NewRow();
                dr["Month"] = i.ToString();
                dr["Value"] = i;
                dtMonth.Rows.Add(dr);
            }
            comboBoxM.DataSource = dtMonth;
            comboBoxM.DisplayMember = "Month";
            comboBoxM.ValueMember = "Value";
            comboBoxM.SelectedValue = DateTime.Now.Month;


            DataTable dtYear = new DataTable();
            dtYear.Columns.Add("Year");
            dtYear.Columns.Add("Value");
            for (int i = 2010; i <= 2023; i++)
            {
                DataRow dr = dtYear.NewRow();
                dr["Year"] = i.ToString();
                dr["Value"] = i;
                dtYear.Rows.Add(dr);
            }
            comboBoxY.DataSource = dtYear;
            comboBoxY.DisplayMember = "Year";
            comboBoxY.ValueMember = "Value";
            comboBoxY.SelectedValue = DateTime.Now.Year;
            this.reportViewer1.RefreshReport();

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            SalarySheet sheet = new SalarySheet();
            SalarySheetServ salSheetServ = new SalarySheetServ();
            SalarySheetItemServ salSheetItemServ = new SalarySheetItemServ();
            sheet.Month = Convert.ToInt32(comboBoxM.SelectedValue);
            sheet.Year = Convert.ToInt32(comboBoxY.SelectedValue);
            sheet.DepartmentId = (Guid)comboBoxDept.SelectedValue;
            EmptyJudge ej = new EmptyJudge();
            if (!ej.isEmployeeExist(sheet))
            {
                CommonHelper.ShowErrorMsg("该部门没有员工");

            }
            if (!ej.isSheetExist(sheet))
            {
                CommonHelper.ShowErrorMsg("未找到工资表");
            }
            else
            {
                sheet.Id = salSheetServ.GetSalarySheetId(sheet);
                DataTable dtSheet = salSheetItemServ.GetPrintSalarySheet(sheet);
                DataTable dtInfo = new DataTable();
                dtInfo.Columns.Add("year");
                dtInfo.Columns.Add("month");
                dtInfo.Columns.Add("dept");
                DataRow dr = dtInfo.NewRow();
                dr["year"] = comboBoxY.SelectedValue;
                dr["month"] = comboBoxM.SelectedValue;
                dr["dept"] = comboBoxDept.Text;
                dtInfo.Rows.Add(dr);


                

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dtSheet));
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dtInfo));
                reportViewer1.RefreshReport();
            }
        }
    }
}
