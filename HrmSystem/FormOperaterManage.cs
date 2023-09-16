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
    public partial class FormOperaterManage : Form
    {
        OperatorService opServ = new OperatorService();
        public FormOperaterManage()
        {
            InitializeComponent();
        }

        private void FormOperaterManage_Load(object sender, EventArgs e)
        {
            dgvOp.DataSource = opServ.GetOpList();
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            if (dgvOp.SelectedRows.Count == 0)
            {
                CommonHelper.ShowErrorMsg("请选择一个员工");
            }
            else
            {
                if (CommonHelper.ShowYesNoMsg("你确定要删除这个用户吗?") == DialogResult.Yes)
                {
                    if (opServ.DelOp((Guid)dgvOp.Rows[dgvOp.CurrentRow.Index].Cells[0].Value))
                    {
                        CommonHelper.ShowSuccessMsg("删除成功");
                        dgvOp.DataSource = opServ.GetOpList();

                    }
                    else
                    {
                        CommonHelper.ShowSuccessMsg("删除失败");
                    }
                }
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FormOperatorAdd foa= new FormOperatorAdd();
            foa.ShowDialog();
            dgvOp.DataSource = opServ.GetOpList();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvOp.SelectedRows.Count == 0)
            {
                CommonHelper.ShowErrorMsg("请选择一个员工");
            }else
            {
                FormOpretorEdit foe = new FormOpretorEdit((Guid)dgvOp.Rows[dgvOp.CurrentRow.Index].Cells[0].Value);
                foe.ShowDialog();
                dgvOp.DataSource = opServ.GetOpList();
            }
        }
            
    }
}
