using HrmSystem.DAL;
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
    public partial class FormMigrateLog : Form
    {
        LogMigrationServ lms = new LogMigrationServ();
        public FormMigrateLog()
        {
            InitializeComponent();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value;
            if (lms.LogMigration(date))
            {
                CommonHelper.ShowSuccessMsg("操作成功");
            }
            else
            {
                CommonHelper.ShowErrorMsg("操作失败");
            }

        }
    }
}
