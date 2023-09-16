namespace HrmSystem
{
    partial class FormSalarySheet
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
            this.dgvSal = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSal
            // 
            this.dgvSal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSal.Location = new System.Drawing.Point(12, 95);
            this.dgvSal.Name = "dgvSal";
            this.dgvSal.RowTemplate.Height = 23;
            this.dgvSal.Size = new System.Drawing.Size(668, 262);
            this.dgvSal.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(605, 374);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(605, 44);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "生成工资单";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(12, 44);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(100, 20);
            this.comboBoxY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "年";
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(141, 44);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(55, 20);
            this.comboBoxM.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "月";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(225, 44);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDept.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "部门";
            // 
            // FormSalarySheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dgvSal);
            this.Name = "FormSalarySheet";
            this.Text = "生成工资单";
            this.Load += new System.EventHandler(this.FormSalarySheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSal;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label label3;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}