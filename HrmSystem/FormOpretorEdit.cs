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
    public partial class FormOpretorEdit : Form
    {
        OperatorService opServ = new OperatorService();
        private Guid Id;
        public FormOpretorEdit(Guid Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void FormOpretorEdit_Load(object sender, EventArgs e)
        {
            
            Operator op = opServ.GetOpById(Id);

            textBoxRealname.Text = op.RealName;
            textBoxUserName.Text = op.UserName;
            checkBoxIsDel.Checked = op.IsDeleted;
            checkBoxIsLocked.Checked = op.IsLocked;
            checkBoxIsAdmin.Checked = op.IsAdmin;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Operator op = new Operator();
            op.RealName = textBoxRealname.Text;
            op.UserName = textBoxUserName.Text;
            op.IsDeleted = checkBoxIsDel.Checked;
            op.IsLocked = checkBoxIsLocked.Checked;
            op.IsAdmin = checkBoxIsAdmin.Checked;
            op.Id = Id;
            if (opServ.UpdateOp(op))
            {
                CommonHelper.ShowSuccessMsg("修改成功");
                
            }
            else
            {
                CommonHelper.ShowErrorMsg("修改失败");
            }
            this.Dispose();
        }
    }
}
