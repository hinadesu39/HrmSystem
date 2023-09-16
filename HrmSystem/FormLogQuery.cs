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
    public partial class FormLogQuery : Form
    {
        private int currentPageNo;
        private const int NUM_PER_PAGE = 15;
        private int totalPages;
        OperationLogServ oplServ = new OperationLogServ();
        LogSearchWhere lsw;
        //DataTable dt = new DataTable();
        public FormLogQuery()
        {
            InitializeComponent();
        }

        public enum UserType { validUser, passwordError, noUser }
        private void FormLogQuery_Load(object sender, EventArgs e)
        {
            currentPageNo = 1;
            totalPages = oplServ.GetTotalPages(NUM_PER_PAGE);
            showOnePage();
            labelTotalPage.Text = Convert.ToString(totalPages);

            comboBoxName.DataSource = oplServ.GetRealName();
            comboBoxName.DisplayMember = "RealName";
            comboBoxName.ValueMember = "Id";
            comboBoxName.SelectedIndex = -1;

            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Key");
            dt.Columns.Add(dc);
            DataRow dr1 = dt.NewRow();
            dr1["Key"] = "非法登陆，无效用户！！！";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["Key"] = "非法登陆，密码错误！！！";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["Key"] = "合法登陆，登陆成功！！！";
            dt.Rows.Add(dr3);

            comboBoxKey.DataSource = dt;
            comboBoxKey.DisplayMember = "Key";
            comboBoxKey.ValueMember = "Key";
            comboBoxKey.SelectedIndex = -1;
        }

        private void linkLabelHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPageNo = 1;
            showOnePage();
        }

        private void linkLabelPrePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPageNo = Math.Max(currentPageNo - 1, 1);
            showOnePage();
        }

        private void linkLabelNextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            currentPageNo = Math.Min(currentPageNo + 1, totalPages);
            showOnePage();
        }

        private void linkLabeLastPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPageNo = totalPages;
            showOnePage();
        }

        private void showOnePage()
        {
            if (lsw == null)
            {
                dgvLogQuery.DataSource = oplServ.GetOperationLogList(currentPageNo, NUM_PER_PAGE);
            }
            else
            {
                dgvLogQuery.DataSource = oplServ.GetOperationLogList(currentPageNo, NUM_PER_PAGE,lsw);
            }
            
            labelCurrentPage.Text = Convert.ToString(currentPageNo);
        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            currentPageNo = 1;
            lsw = new LogSearchWhere();
            lsw.IsDateExit = false;
            if (checkBoxName.Checked)
            {
                lsw.Name =(Guid) comboBoxName.SelectedValue;
                if (lsw.Name==Guid.Empty)
                {
                    CommonHelper.ShowErrorMsg("请选择员工姓名");
                    return;
                }
            }
            if (checkBoxTime.Checked)
            {
                lsw.IsDateExit = true;
                lsw.Begin = dtpBegin.Value;
                lsw.End = dtpEnd.Value;
            }

            if (checkBoxKey.Checked)
            {
                if (comboBoxKey.SelectedIndex == -1)
                {
                    CommonHelper.ShowErrorMsg("请选择登录关键信息");
                    return;
                }
                lsw.Key = comboBoxKey.SelectedValue.ToString();
            }
            DataTable dt = oplServ.GetOperationLogList(currentPageNo, NUM_PER_PAGE, lsw);
            totalPages = (int)Math.Ceiling(dt.Rows.Count * 1.0 / NUM_PER_PAGE);
            labelTotalPage.Text = Convert.ToString(totalPages);
            dgvLogQuery.DataSource = oplServ.GetOperationLogList(currentPageNo, NUM_PER_PAGE, lsw);
            
        }
    }
}
