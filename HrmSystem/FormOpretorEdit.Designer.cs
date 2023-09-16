namespace HrmSystem
{
    partial class FormOpretorEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRealname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.checkBoxIsLocked = new System.Windows.Forms.CheckBox();
            this.checkBoxIsDel = new System.Windows.Forms.CheckBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "真实姓名";
            // 
            // textBoxRealname
            // 
            this.textBoxRealname.Location = new System.Drawing.Point(95, 74);
            this.textBoxRealname.Name = "textBoxRealname";
            this.textBoxRealname.Size = new System.Drawing.Size(100, 21);
            this.textBoxRealname.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "用户名";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(95, 37);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserName.TabIndex = 14;
            // 
            // checkBoxIsLocked
            // 
            this.checkBoxIsLocked.AutoSize = true;
            this.checkBoxIsLocked.Location = new System.Drawing.Point(280, 39);
            this.checkBoxIsLocked.Name = "checkBoxIsLocked";
            this.checkBoxIsLocked.Size = new System.Drawing.Size(72, 16);
            this.checkBoxIsLocked.TabIndex = 18;
            this.checkBoxIsLocked.Text = "是否锁定";
            this.checkBoxIsLocked.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsDel
            // 
            this.checkBoxIsDel.AutoSize = true;
            this.checkBoxIsDel.Location = new System.Drawing.Point(280, 77);
            this.checkBoxIsDel.Name = "checkBoxIsDel";
            this.checkBoxIsDel.Size = new System.Drawing.Size(72, 16);
            this.checkBoxIsDel.TabIndex = 19;
            this.checkBoxIsDel.Text = "是否删除";
            this.checkBoxIsDel.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(280, 117);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(84, 16);
            this.checkBoxIsAdmin.TabIndex = 20;
            this.checkBoxIsAdmin.Text = "是否管理员";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(95, 129);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 21;
            this.buttonOk.Text = "保存";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormOpretorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 203);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.checkBoxIsDel);
            this.Controls.Add(this.checkBoxIsLocked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRealname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "FormOpretorEdit";
            this.Text = "FormOpretorEdit";
            this.Load += new System.EventHandler(this.FormOpretorEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRealname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.CheckBox checkBoxIsLocked;
        private System.Windows.Forms.CheckBox checkBoxIsDel;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Button buttonOk;
    }
}