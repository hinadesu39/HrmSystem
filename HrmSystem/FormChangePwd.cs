using HrmSystem.BLL;
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
    public partial class FormChangePwd : Form
    {
        public FormChangePwd()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string pwd1 = CommonHelper.GetMD5(textBoxPwd1.Text.Trim());
            string pwd2 = CommonHelper.GetMD5(textBoxPwd2.Text.Trim());
            if (pwd1 != pwd2)
            {
                CommonHelper.ShowErrorMsg("密码不一致，请重新输入");
                textBoxPwd1.Clear();
                textBoxPwd2.Clear();
            }
            else
            {
                bool bl = PwdChange.ChangePwd(LoginUser.GetInstance(), pwd1);
                if (bl)
                {
                    CommonHelper.ShowSuccessMsg("修改成功");
                    this.Dispose();
                }
                else
                {
                    CommonHelper.ShowErrorMsg("修改失败，请联系管理员");
                    this.Dispose();
                }
            }

        }
    }
}
