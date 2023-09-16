using HrmSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HrmSystem.Model;
namespace HrmSystem
{
    public partial class FormAddEmp : Form
    {
        EmpolyeeServ empServ = new EmpolyeeServ();
        private byte[] photo;
        public FormAddEmp()
        {
            InitializeComponent();
        }


        private void FormAddEmp_Load(object sender, EventArgs e)
        {
            comboBoxSex.DataSource = empServ.GetInfo("性别");
            comboBoxMarrige.DataSource = empServ.GetInfo("婚姻状况");
            comboBoxParty.DataSource = empServ.GetInfo("政治面貌");
            comboBoxEb.DataSource = empServ.GetInfo("学历");
            comboBoxDept.DataSource = empServ.GetDept();

            List<ComboBox> comb = new List<ComboBox>();
            comb.Add(comboBoxSex);
            comb.Add(comboBoxMarrige);
            comb.Add(comboBoxParty);
            comb.Add(comboBoxEb);
            comb.Add(comboBoxDept);

            foreach (var com in comb)
            {
                com.DisplayMember = "Name";
                com.ValueMember = "Id";
                com.SelectedIndex = -1;
            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG图片|*.jpg|GIF图片|*.gif|位图|*.bmp|PNG图片|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = File.ReadAllBytes(ofd.FileName);
                picPhoto.Image = new Bitmap(ofd.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //string Name = textBoxName.Text.Trim();
            //DateTime IndDay = dtpInDay.Value;
            //string NativePlace = textBoxNativePlace.Text.Trim();
            //string Address = textBoxAd.Text.Trim();
            //string Email = textBoxEmile.Text.Trim();
            //string Number = textBoxNum.Text.Trim();
            //Guid GenderId = (Guid)comboBoxSex.SelectedValue;
            //Guid PartyId = (Guid)comboBoxParty.SelectedValue;
            //Guid MarriageId = (Guid)comboBoxMarrige.SelectedValue;
            //Guid EducationId = (Guid)comboBoxEb.SelectedValue;
            //Guid DepartmentId = (Guid)comboBoxDept.SelectedValue;
            //string Telephone = textBoxPhone.Text.Trim();
            //DateTime BirthDay = dtpBirthDay.Value;
            //string Nation = textBoxNation.Text.Trim();
            //string Remarks = richTextBoxRemarks.Text.Trim();
            //Guid Id = Guid.NewGuid();
            //string Resume
            Employee emp = new Employee();
            emp.Name = textBoxName.Text.Trim();
            emp.InDay = dtpInDay.Value;
            emp.NativePlace = textBoxNativePlace.Text.Trim();
            emp.Address = textBoxAd.Text.Trim();
            emp.Email = textBoxEmile.Text.Trim();
            emp.Number = textBoxNum.Text.Trim();
            emp.GenderId = (Guid)comboBoxSex.SelectedValue;
            emp.PartyId = (Guid)comboBoxParty.SelectedValue;
            emp.MarriageId = (Guid)comboBoxMarrige.SelectedValue;
            emp.EducationId = (Guid)comboBoxEb.SelectedValue;
            emp.DepartmentId = (Guid)comboBoxDept.SelectedValue;
            emp.Telephone = textBoxPhone.Text.Trim();
            emp.BirthDay = dtpBirthDay.Value;
            emp.Nation = textBoxNation.Text.Trim();
            emp.Remarks = richTextBoxRemarks.Text.Trim();
            emp.Id = Guid.NewGuid();
            emp.Photo = photo;

            if (empServ.AddEmployee(emp))
            {
                MessageBox.Show("操作成功", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("操作失败", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
