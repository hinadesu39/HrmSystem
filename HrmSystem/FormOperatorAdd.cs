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
    public partial class FormOperatorAdd : Form
    {
        OperatorService opServ = new OperatorService();
        public FormOperatorAdd()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Operator op = new Operator();
            op.RealName = textBoxRealname.Text.Trim();
            op.UserName = textBoxUserName.Text.Trim();
            op.Password = CommonHelper.GetMD5(textBoxPwd.Text.Trim());
            if (opServ.AddOperator(op))
            {
                CommonHelper.ShowSuccessMsg("添加用户成功");
                this.Dispose();
            }
            else
            {
                CommonHelper.ShowErrorMsg("添加用户失败,请联系工作人员");
            }

        }
    }
}
