namespace HrmSystem
{
    partial class FormEmployeeList
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
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxDept = new System.Windows.Forms.CheckBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(12, 178);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowTemplate.Height = 23;
            this.dgvEmp.Size = new System.Drawing.Size(866, 236);
            this.dgvEmp.TabIndex = 0;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(7, 34);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(48, 16);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "姓名";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxDept
            // 
            this.checkBoxDept.AutoSize = true;
            this.checkBoxDept.Location = new System.Drawing.Point(7, 69);
            this.checkBoxDept.Name = "checkBoxDept";
            this.checkBoxDept.Size = new System.Drawing.Size(48, 16);
            this.checkBoxDept.TabIndex = 1;
            this.checkBoxDept.Text = "部门";
            this.checkBoxDept.UseVisualStyleBackColor = true;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(293, 34);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTime.TabIndex = 2;
            this.checkBoxTime.Text = "入职时间";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(290, 65);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "检索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(61, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 21);
            this.textBoxName.TabIndex = 4;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(61, 67);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDept.TabIndex = 5;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(392, 32);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(130, 21);
            this.dtpBegin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "到";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(570, 32);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 21);
            this.dtpEnd.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpBegin);
            this.groupBox1.Controls.Add(this.comboBoxDept);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.checkBoxTime);
            this.groupBox1.Controls.Add(this.checkBoxDept);
            this.groupBox1.Controls.Add(this.checkBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(414, 65);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDel,
            this.tsbExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::HrmSystem.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "toolStripButton1";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::HrmSystem.Properties.Resources.edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "toolStripButton1";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDel.Image = global::HrmSystem.Properties.Resources.delete;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(23, 22);
            this.tsbDel.Text = "toolStripButton2";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = global::HrmSystem.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "toolStripButton3";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 426);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmp);
            this.Name = "FormEmployeeList";
            this.Text = "员工列表";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxDept;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.Button buttonRefresh;
    }
}