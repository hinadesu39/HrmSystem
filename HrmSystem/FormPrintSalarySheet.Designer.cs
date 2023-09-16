namespace HrmSystem
{
    partial class FormPrintSalarySheet
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
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "部门";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(237, 32);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDept.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "月";
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(153, 32);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(55, 20);
            this.comboBoxM.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "年";
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(24, 32);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(100, 20);
            this.comboBoxY.TabIndex = 10;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(442, 30);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 9;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HrmSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 350);
            this.reportViewer1.TabIndex = 18;
            // 
            // FormPrintSalarySheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 441);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.buttonQuery);
            this.Name = "FormPrintSalarySheet";
            this.Text = "打印工资单";
            this.Load += new System.EventHandler(this.FormPrintSalarySheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Button buttonQuery;
        private DataSet1 DataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}