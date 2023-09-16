namespace HrmSystem
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogMig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmLog,
            this.tsmiStaffManage,
            this.tsmiSal,
            this.其他ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 25);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManage});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(70, 21);
            this.tsmiAdmin.Text = "管理员(&F)";
            // 
            // tsmiManage
            // 
            this.tsmiManage.Name = "tsmiManage";
            this.tsmiManage.Size = new System.Drawing.Size(124, 22);
            this.tsmiManage.Text = "用户管理";
            this.tsmiManage.Click += new System.EventHandler(this.tsmiManage_Click);
            // 
            // tsmLog
            // 
            this.tsmLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogMig,
            this.tsmiLog});
            this.tsmLog.Name = "tsmLog";
            this.tsmLog.Size = new System.Drawing.Size(44, 21);
            this.tsmLog.Text = "日志";
            this.tsmLog.ToolTipText = "其它";
            // 
            // tsmiLogMig
            // 
            this.tsmiLogMig.Name = "tsmiLogMig";
            this.tsmiLogMig.Size = new System.Drawing.Size(152, 22);
            this.tsmiLogMig.Text = "日志迁移";
            this.tsmiLogMig.Click += new System.EventHandler(this.tsmiLogMig_Click);
            // 
            // tsmiLog
            // 
            this.tsmiLog.Name = "tsmiLog";
            this.tsmiLog.Size = new System.Drawing.Size(152, 22);
            this.tsmiLog.Text = "日志管理";
            this.tsmiLog.Click += new System.EventHandler(this.tsmiLog_Click);
            // 
            // tsmiStaffManage
            // 
            this.tsmiStaffManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStaffList});
            this.tsmiStaffManage.Name = "tsmiStaffManage";
            this.tsmiStaffManage.Size = new System.Drawing.Size(68, 21);
            this.tsmiStaffManage.Text = "员工管理";
            // 
            // tsmiStaffList
            // 
            this.tsmiStaffList.Name = "tsmiStaffList";
            this.tsmiStaffList.Size = new System.Drawing.Size(152, 22);
            this.tsmiStaffList.Text = "员工列表";
            this.tsmiStaffList.Click += new System.EventHandler(this.tsmiStaffList_Click);
            // 
            // tsmiSal
            // 
            this.tsmiSal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSalGenerate,
            this.tsmiPrint});
            this.tsmiSal.Name = "tsmiSal";
            this.tsmiSal.Size = new System.Drawing.Size(92, 21);
            this.tsmiSal.Text = "员工工资管理";
            // 
            // tsmSalGenerate
            // 
            this.tsmSalGenerate.Name = "tsmSalGenerate";
            this.tsmSalGenerate.Size = new System.Drawing.Size(152, 22);
            this.tsmSalGenerate.Text = "生成工资单";
            this.tsmSalGenerate.Click += new System.EventHandler(this.tsmSalGenerate_Click);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(152, 22);
            this.tsmiPrint.Text = "打印工资单";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMChangePwd});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // TSMChangePwd
            // 
            this.TSMChangePwd.Name = "TSMChangePwd";
            this.TSMChangePwd.Size = new System.Drawing.Size(124, 22);
            this.TSMChangePwd.Text = "修改密码";
            this.TSMChangePwd.Click += new System.EventHandler(this.TSMChangePwd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl,
            this.tsslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl
            // 
            this.tssl.Name = "tssl";
            this.tssl.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(131, 17);
            this.tsslInfo.Text = "toolStripStatusLabel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 465);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "员工管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffList;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogMig;
        private System.Windows.Forms.ToolStripMenuItem tsmiLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSal;
        private System.Windows.Forms.ToolStripMenuItem tsmSalGenerate;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMChangePwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiManage;
    }
}