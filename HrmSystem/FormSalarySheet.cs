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
    public partial class FormSalarySheet : Form
    {
        EmpolyeeServ empServ = new EmpolyeeServ();
        SalarySheetServ salSheetServ = new SalarySheetServ();
        SalarySheetItemServ salSheetItemServ = new SalarySheetItemServ();
        SalarySheet sheet;
        public FormSalarySheet()
        {
            InitializeComponent();
        }

        private void FormSalarySheet_Load(object sender, EventArgs e)
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


        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            sheet = new SalarySheet();
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
                sheet.Id = Guid.NewGuid();
                salSheetServ.BuildNewSalarySheetId(sheet);
                salSheetItemServ.BuildNewSalarySheetItems(sheet.Id, sheet.DepartmentId);
                dgvSal.DataSource = salSheetItemServ.GetSalarySheet(sheet);
            }
            else
            {
                var res = CommonHelper.ShowYesNoMsg("该月份该部门已存在工资表，是否要覆盖");

                if (res == DialogResult.Yes)
                {
                    sheet.Id = salSheetServ.GetSalarySheetId(sheet);
                    salSheetItemServ.RebuildSalarySheetItems(sheet.Id);
                    dgvSal.DataSource = salSheetItemServ.GetSalarySheet(sheet);
                }
                else
                {
                    sheet.Id = salSheetServ.GetSalarySheetId(sheet);
                    dgvSal.DataSource = salSheetItemServ.GetSalarySheet(sheet);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvSal.DataSource;
            salSheetItemServ.SaveSheetItems(dt);
            CommonHelper.ShowSuccessMsg("保存成功");
        }

    }
}
