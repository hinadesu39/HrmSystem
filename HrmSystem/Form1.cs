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
using System.Configuration;
using HrmSystem.DAL;
using HrmSystem.Model;
using HrmSystem.BLL;
using static HrmSystem.BLL.SystemGuard;

namespace HrmSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public static string isAdmin;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string un = textBoxUserName.Text.Trim();
            string pwd = CommonHelper.GetMD5(textBoxPwd.Text.Trim());
            SystemGuard sg = new SystemGuard();
            UserType ut = sg.checkUser(un, pwd);

                if (ut == UserType.noUser)
                {
                    this.DialogResult = DialogResult.Cancel;
                    CommonHelper.ShowErrorMsg("用户不存在");
                }
                else if(ut == UserType.passwordError)
                {
                    this.DialogResult = DialogResult.Cancel;
                    CommonHelper.ShowErrorMsg("用户密码错误");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    CommonHelper.ShowSuccessMsg("登陆成功");
                }
                

                
            }

        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
