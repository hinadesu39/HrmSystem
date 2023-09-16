using HrmSystem.DAL;
using HrmSystem.Model;
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

namespace HrmSystem
{
    public partial class FormEmpEdit : Form
    {
        private Guid Id;
        private Employee emp = new Employee();
        EmpolyeeServ empServ = new EmpolyeeServ();
        private byte[] photo;

        public FormEmpEdit(Guid Id)
        {
            InitializeComponent();
            this.Id = Id;
            emp = empServ.GetEmpolyee(Id);
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

        private void FormEmpEdit_Load(object sender, EventArgs e)
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

            comboBoxSex.SelectedValue = emp.GenderId;
            comboBoxMarrige.SelectedValue = emp.MarriageId;
            comboBoxDept.SelectedValue = emp.DepartmentId;
            comboBoxEb.SelectedValue = emp.EducationId;
            comboBoxParty.SelectedValue = emp.PartyId;

            if (emp.Photo != null)
            {
                MemoryStream ms = new MemoryStream(emp.Photo);
                picPhoto.Image = new Bitmap(ms);
                photo = emp.Photo;
            }

            textBoxName.Text = emp.Name;
            dtpInDay.Value = emp.InDay;
            textBoxNativePlace.Text = emp.NativePlace;
            textBoxAd.Text = emp.Address;
            textBoxEmile.Text = emp.Email;
            textBoxNum.Text = emp.Number;
            textBoxPhone.Text = emp.Telephone;
            dtpBirthDay.Value = emp.BirthDay;
            textBoxNation.Text = emp.Nation;
            richTextBoxRemarks.Text = emp.Remarks;
            richTextBoxResume.Text = emp.Resume;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

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
            emp.Id = Id;
            emp.Photo = photo;
            emp.Resume = richTextBoxResume.Text.Trim();

            //更新修改
            if (empServ.EditEmployee(emp))
                
            {
                CommonHelper.ShowSuccessMsg("操作成功");
            }
            else
            {
                CommonHelper.ShowErrorMsg("操作失败");
            }
            this.DialogResult = DialogResult.OK;

        }
    }
}
