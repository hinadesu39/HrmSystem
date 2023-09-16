namespace HrmSystem
{
    partial class FormLogQuery
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
            this.dgvLogQuery = new System.Windows.Forms.DataGridView();
            this.linkLabelHomePage = new System.Windows.Forms.LinkLabel();
            this.linkLabelPrePage = new System.Windows.Forms.LinkLabel();
            this.linkLabelNextPage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalPage = new System.Windows.Forms.Label();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabeLastPage = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxKey = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogQuery)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogQuery
            // 
            this.dgvLogQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogQuery.Location = new System.Drawing.Point(12, 12);
            this.dgvLogQuery.Name = "dgvLogQuery";
            this.dgvLogQuery.RowTemplate.Height = 23;
            this.dgvLogQuery.Size = new System.Drawing.Size(444, 366);
            this.dgvLogQuery.TabIndex = 0;
            // 
            // linkLabelHomePage
            // 
            this.linkLabelHomePage.AutoSize = true;
            this.linkLabelHomePage.Location = new System.Drawing.Point(13, 385);
            this.linkLabelHomePage.Name = "linkLabelHomePage";
            this.linkLabelHomePage.Size = new System.Drawing.Size(29, 12);
            this.linkLabelHomePage.TabIndex = 1;
            this.linkLabelHomePage.TabStop = true;
            this.linkLabelHomePage.Text = "首页";
            this.linkLabelHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHomePage_LinkClicked);
            // 
            // linkLabelPrePage
            // 
            this.linkLabelPrePage.AutoSize = true;
            this.linkLabelPrePage.Location = new System.Drawing.Point(83, 385);
            this.linkLabelPrePage.Name = "linkLabelPrePage";
            this.linkLabelPrePage.Size = new System.Drawing.Size(41, 12);
            this.linkLabelPrePage.TabIndex = 2;
            this.linkLabelPrePage.TabStop = true;
            this.linkLabelPrePage.Text = "上一页";
            this.linkLabelPrePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPrePage_LinkClicked);
            // 
            // linkLabelNextPage
            // 
            this.linkLabelNextPage.AutoSize = true;
            this.linkLabelNextPage.Location = new System.Drawing.Point(136, 385);
            this.linkLabelNextPage.Name = "linkLabelNextPage";
            this.linkLabelNextPage.Size = new System.Drawing.Size(41, 12);
            this.linkLabelNextPage.TabIndex = 3;
            this.linkLabelNextPage.TabStop = true;
            this.linkLabelNextPage.Text = "下一页";
            this.linkLabelNextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNextPage_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // labelTotalPage
            // 
            this.labelTotalPage.AutoSize = true;
            this.labelTotalPage.Location = new System.Drawing.Point(727, 385);
            this.labelTotalPage.Name = "labelTotalPage";
            this.labelTotalPage.Size = new System.Drawing.Size(17, 12);
            this.labelTotalPage.TabIndex = 5;
            this.labelTotalPage.Text = "14";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Location = new System.Drawing.Point(687, 385);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(17, 12);
            this.labelCurrentPage.TabIndex = 6;
            this.labelCurrentPage.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "当前页数：";
            // 
            // linkLabeLastPage
            // 
            this.linkLabeLastPage.AutoSize = true;
            this.linkLabeLastPage.Location = new System.Drawing.Point(48, 385);
            this.linkLabeLastPage.Name = "linkLabeLastPage";
            this.linkLabeLastPage.Size = new System.Drawing.Size(29, 12);
            this.linkLabeLastPage.TabIndex = 8;
            this.linkLabeLastPage.TabStop = true;
            this.linkLabeLastPage.Text = "末页";
            this.linkLabeLastPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabeLastPage_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxName);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpBegin);
            this.groupBox1.Controls.Add(this.comboBoxKey);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.checkBoxTime);
            this.groupBox1.Controls.Add(this.checkBoxKey);
            this.groupBox1.Controls.Add(this.checkBoxName);
            this.groupBox1.Location = new System.Drawing.Point(462, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 366);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "From";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(98, 30);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 20);
            this.comboBoxName.TabIndex = 10;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(98, 200);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 21);
            this.dtpEnd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(98, 147);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(130, 21);
            this.dtpBegin.TabIndex = 6;
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Location = new System.Drawing.Point(98, 67);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(121, 20);
            this.comboBoxKey.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(98, 270);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "检索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(7, 110);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTime.TabIndex = 2;
            this.checkBoxTime.Text = "操作时间";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxKey
            // 
            this.checkBoxKey.AutoSize = true;
            this.checkBoxKey.Location = new System.Drawing.Point(7, 69);
            this.checkBoxKey.Name = "checkBoxKey";
            this.checkBoxKey.Size = new System.Drawing.Size(72, 16);
            this.checkBoxKey.TabIndex = 1;
            this.checkBoxKey.Text = "操作描述";
            this.checkBoxKey.UseVisualStyleBackColor = true;
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
            // FormLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabeLastPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.labelTotalPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelNextPage);
            this.Controls.Add(this.linkLabelPrePage);
            this.Controls.Add(this.linkLabelHomePage);
            this.Controls.Add(this.dgvLogQuery);
            this.Name = "FormLogQuery";
            this.Text = "登录日志信息";
            this.Load += new System.EventHandler(this.FormLogQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogQuery)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogQuery;
        private System.Windows.Forms.LinkLabel linkLabelHomePage;
        private System.Windows.Forms.LinkLabel linkLabelPrePage;
        private System.Windows.Forms.LinkLabel linkLabelNextPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalPage;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabeLastPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.CheckBox checkBoxKey;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxName;
    }
}