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
    public partial class FormEmployeeList : Form
    {
        EmpolyeeServ empServ = new EmpolyeeServ();

        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            comboBoxDept.DataSource = empServ.GetDept();

            comboBoxDept.DisplayMember = "Name";
            comboBoxDept.ValueMember = "Id";
            comboBoxDept.SelectedIndex = -1;

            dgvEmp.DataSource = empServ.GetEmpolyee();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            EmployeeSearchWhere esw = new EmployeeSearchWhere();
            esw.IsDateExit = false;

            if (checkBoxName.Checked)
            {
                esw.Name = textBoxName.Text.Trim();
                if (string.IsNullOrEmpty(esw.Name))
                {
                    CommonHelper.ShowErrorMsg("请输入一个员工姓名的关键字");
                    return;
                }
            }
            if (checkBoxTime.Checked)
            {
                esw.IsDateExit = true;
                esw.Begin = dtpBegin.Value;
                esw.End = dtpEnd.Value;
            }

            if (checkBoxDept.Checked)
            {
                if (comboBoxDept.SelectedIndex == -1)
                {
                    CommonHelper.ShowErrorMsg("请选择员工部门信息");
                    return;
                }
                esw.Dept = (Guid)comboBoxDept.SelectedValue;
            }

            dgvEmp.DataSource = empServ.GetEmpolyee(esw);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FormEmpAdd fae = new FormEmpAdd();
            fae.ShowDialog();
            if (fae.DialogResult == DialogResult.OK)
            {
                dgvEmp.DataSource = empServ.GetEmpolyee();
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dgvEmp.DataSource = empServ.GetEmpolyee();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmp.SelectedRows.Count == 0)
            {
                CommonHelper.ShowErrorMsg("请选择一个员工");
            }
            else
            {
                Guid Id = (Guid)dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[0].Value;
                FormEmpEdit fed = new FormEmpEdit(Id);
                fed.ShowDialog();

                if (fed.DialogResult == DialogResult.OK)
                {
                    dgvEmp.DataSource = empServ.GetEmpolyee();
                }
            }

        }

        private void tsbDel_Click(object sender, EventArgs e)
        {

            if (dgvEmp.SelectedRows.Count == 1)
            {
                Guid Id = (Guid)dgvEmp.Rows[dgvEmp.CurrentRow.Index].Cells[0].Value;
                if(CommonHelper.ShowYesNoMsg("你确定要删除这个员工吗?(不可恢复)") == DialogResult.Yes)
                {
                    if (empServ.DelEmployee(Id))
                    {
                        CommonHelper.ShowSuccessMsg("删除成功");
                        dgvEmp.DataSource = empServ.GetEmpolyee();

                    }
                    else
                    {
                        CommonHelper.ShowSuccessMsg("删除失败");
                    }
                }
            }
            else 
            {
                
                CommonHelper.ShowErrorMsg("请选择一个员工");
            }
       
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            ExcleHelper eh = new ExcleHelper();
            DataTable dt = (DataTable)dgvEmp.DataSource;
            bool i = eh.ExportDataToExcel(dt, "员工信息");
            if(i == false)
            {
                CommonHelper.ShowErrorMsg("导出失败");
            }
            else
            {
                CommonHelper.ShowSuccessMsg("导出成功");
            }

        }
    }
}

