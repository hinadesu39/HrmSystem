using HrmSystem.BLL;
using HrmSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        

        private void TSMChangePwd_Click(object sender, EventArgs e)
        {
            FormChangePwd fcp = new FormChangePwd();
            fcp.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            if(fl.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
            LoginUser lu = LoginUser.GetInstance();
            tsslInfo.Text = string.Format("欢迎用户{0}在{1}登陆本系统", lu.RealName, DateTime.Now);
            if (!lu.IsAdmin)
            {
                tsmiAdmin.Visible = false;
            }
            if (lu.IsLocked)
            {
                tsmiAdmin.Visible = false;
                tsmLog.Visible = false;
                tsmiStaffManage.Visible = false;
                tsmiSal.Visible = false;
                CommonHelper.ShowErrorMsg("您的账户已被锁定，请联系管理员!!");
            }
        }

     

        

        private void tsmiStaffList_Click(object sender, EventArgs e)
        {
            FormEmployeeList fel = new FormEmployeeList();
            fel.Show();
        }

        private void tsmiLogMig_Click(object sender, EventArgs e)
        {
            FormMigrateLog fml = new FormMigrateLog();
            fml.Show();
        }

        private void tsmiLog_Click(object sender, EventArgs e)
        {
            FormLogQuery flg = new FormLogQuery();
            flg.Show();
        }

        private void tsmSalGenerate_Click(object sender, EventArgs e)
        {
            FormSalarySheet fss = new FormSalarySheet();
            fss.Show();
        }

        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            FormPrintSalarySheet fpss = new FormPrintSalarySheet();
            fpss.Show();
        }

        private void tsmiManage_Click(object sender, EventArgs e)
        {
            FormOperaterManage fom = new FormOperaterManage();
            fom.Show();
        }
    }
}
