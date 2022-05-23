namespace Installer
{
    partial class Index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.LabelArrow1 = new System.Windows.Forms.Label();
            this.LabelArrow2 = new System.Windows.Forms.Label();
            this.LabelDone = new System.Windows.Forms.Label();
            this.LabelConfirm = new System.Windows.Forms.Label();
            this.LabelDir = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.Panel();
            this.InstallerIcon = new System.Windows.Forms.PictureBox();
            this.TextBoxLicense = new System.Windows.Forms.RichTextBox();
            this.BoxDirectoryPath = new System.Windows.Forms.TextBox();
            this.BoxLicense = new System.Windows.Forms.GroupBox();
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.ButtonChoosePath = new System.Windows.Forms.Button();
            this.BoxPath = new System.Windows.Forms.GroupBox();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.PageDirectory = new System.Windows.Forms.Panel();
            this.PageConfirm = new System.Windows.Forms.Panel();
            this.PageDone = new System.Windows.Forms.Panel();
            this.CheckGithub = new System.Windows.Forms.CheckBox();
            this.CheckRun = new System.Windows.Forms.CheckBox();
            this.LabelThanks = new System.Windows.Forms.Label();
            this.LabelPageDone = new System.Windows.Forms.Label();
            this.CheckOpenCC = new System.Windows.Forms.CheckBox();
            this.CheckShortcut = new System.Windows.Forms.CheckBox();
            this.LabelFileWarn = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ProgressInstall = new System.Windows.Forms.ProgressBar();
            this.LableInstallWarn = new System.Windows.Forms.Label();
            this.CheckStartUpMenu = new System.Windows.Forms.CheckBox();
            this.CheckAssociation = new System.Windows.Forms.CheckBox();
            this.RBUnzip = new System.Windows.Forms.RadioButton();
            this.RBInstall = new System.Windows.Forms.RadioButton();
            this.LabelPath = new System.Windows.Forms.Label();
            this.LabelConfirmTitle = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstallerIcon)).BeginInit();
            this.BoxLicense.SuspendLayout();
            this.BoxPath.SuspendLayout();
            this.PageDirectory.SuspendLayout();
            this.PageConfirm.SuspendLayout();
            this.PageDone.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.EventCancel);
            // 
            // ButtonNext
            // 
            resources.ApplyResources(this.ButtonNext, "ButtonNext");
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.ButtonFinish);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.ButtonInstall);
            this.panel1.Controls.Add(this.LabelArrow1);
            this.panel1.Controls.Add(this.LabelArrow2);
            this.panel1.Controls.Add(this.LabelDone);
            this.panel1.Controls.Add(this.LabelConfirm);
            this.panel1.Controls.Add(this.LabelDir);
            this.panel1.Controls.Add(this.ButtonNext);
            this.panel1.Controls.Add(this.ButtonCancel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ButtonFinish
            // 
            resources.ApplyResources(this.ButtonFinish, "ButtonFinish");
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // ButtonBack
            // 
            resources.ApplyResources(this.ButtonBack, "ButtonBack");
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonInstall
            // 
            resources.ApplyResources(this.ButtonInstall, "ButtonInstall");
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.UseVisualStyleBackColor = true;
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // LabelArrow1
            // 
            resources.ApplyResources(this.LabelArrow1, "LabelArrow1");
            this.LabelArrow1.BackColor = System.Drawing.Color.Transparent;
            this.LabelArrow1.Name = "LabelArrow1";
            // 
            // LabelArrow2
            // 
            resources.ApplyResources(this.LabelArrow2, "LabelArrow2");
            this.LabelArrow2.BackColor = System.Drawing.Color.Transparent;
            this.LabelArrow2.Name = "LabelArrow2";
            // 
            // LabelDone
            // 
            resources.ApplyResources(this.LabelDone, "LabelDone");
            this.LabelDone.Name = "LabelDone";
            // 
            // LabelConfirm
            // 
            resources.ApplyResources(this.LabelConfirm, "LabelConfirm");
            this.LabelConfirm.Name = "LabelConfirm";
            // 
            // LabelDir
            // 
            resources.ApplyResources(this.LabelDir, "LabelDir");
            this.LabelDir.Name = "LabelDir";
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.Background.Controls.Add(this.InstallerIcon);
            resources.ApplyResources(this.Background, "Background");
            this.Background.Name = "Background";
            // 
            // InstallerIcon
            // 
            this.InstallerIcon.Image = global::Installer.Properties.Resources.logo1;
            resources.ApplyResources(this.InstallerIcon, "InstallerIcon");
            this.InstallerIcon.Name = "InstallerIcon";
            this.InstallerIcon.TabStop = false;
            // 
            // TextBoxLicense
            // 
            this.TextBoxLicense.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.TextBoxLicense, "TextBoxLicense");
            this.TextBoxLicense.Name = "TextBoxLicense";
            this.TextBoxLicense.ReadOnly = true;
            // 
            // BoxDirectoryPath
            // 
            resources.ApplyResources(this.BoxDirectoryPath, "BoxDirectoryPath");
            this.BoxDirectoryPath.Name = "BoxDirectoryPath";
            // 
            // BoxLicense
            // 
            this.BoxLicense.Controls.Add(this.TextBoxLicense);
            resources.ApplyResources(this.BoxLicense, "BoxLicense");
            this.BoxLicense.Name = "BoxLicense";
            this.BoxLicense.TabStop = false;
            // 
            // LabelWelcome
            // 
            resources.ApplyResources(this.LabelWelcome, "LabelWelcome");
            this.LabelWelcome.Name = "LabelWelcome";
            // 
            // ButtonChoosePath
            // 
            resources.ApplyResources(this.ButtonChoosePath, "ButtonChoosePath");
            this.ButtonChoosePath.Name = "ButtonChoosePath";
            this.ButtonChoosePath.UseVisualStyleBackColor = true;
            this.ButtonChoosePath.Click += new System.EventHandler(this.ButtonChoosePath_Click);
            // 
            // BoxPath
            // 
            this.BoxPath.Controls.Add(this.LabelWarning);
            this.BoxPath.Controls.Add(this.ButtonChoosePath);
            this.BoxPath.Controls.Add(this.BoxDirectoryPath);
            resources.ApplyResources(this.BoxPath, "BoxPath");
            this.BoxPath.Name = "BoxPath";
            this.BoxPath.TabStop = false;
            // 
            // LabelWarning
            // 
            this.LabelWarning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.LabelWarning, "LabelWarning");
            this.LabelWarning.Name = "LabelWarning";
            // 
            // PageDirectory
            // 
            this.PageDirectory.Controls.Add(this.LabelWelcome);
            this.PageDirectory.Controls.Add(this.BoxLicense);
            this.PageDirectory.Controls.Add(this.BoxPath);
            resources.ApplyResources(this.PageDirectory, "PageDirectory");
            this.PageDirectory.Name = "PageDirectory";
            // 
            // PageConfirm
            // 
            this.PageConfirm.Controls.Add(this.PageDone);
            this.PageConfirm.Controls.Add(this.CheckOpenCC);
            this.PageConfirm.Controls.Add(this.CheckShortcut);
            this.PageConfirm.Controls.Add(this.LabelFileWarn);
            this.PageConfirm.Controls.Add(this.LabelStatus);
            this.PageConfirm.Controls.Add(this.ProgressInstall);
            this.PageConfirm.Controls.Add(this.LableInstallWarn);
            this.PageConfirm.Controls.Add(this.CheckStartUpMenu);
            this.PageConfirm.Controls.Add(this.CheckAssociation);
            this.PageConfirm.Controls.Add(this.RBUnzip);
            this.PageConfirm.Controls.Add(this.RBInstall);
            this.PageConfirm.Controls.Add(this.LabelPath);
            this.PageConfirm.Controls.Add(this.LabelConfirmTitle);
            resources.ApplyResources(this.PageConfirm, "PageConfirm");
            this.PageConfirm.Name = "PageConfirm";
            // 
            // PageDone
            // 
            this.PageDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PageDone.Controls.Add(this.CheckGithub);
            this.PageDone.Controls.Add(this.CheckRun);
            this.PageDone.Controls.Add(this.LabelThanks);
            this.PageDone.Controls.Add(this.LabelPageDone);
            resources.ApplyResources(this.PageDone, "PageDone");
            this.PageDone.Name = "PageDone";
            // 
            // CheckGithub
            // 
            resources.ApplyResources(this.CheckGithub, "CheckGithub");
            this.CheckGithub.Name = "CheckGithub";
            this.CheckGithub.UseVisualStyleBackColor = true;
            // 
            // CheckRun
            // 
            resources.ApplyResources(this.CheckRun, "CheckRun");
            this.CheckRun.Checked = true;
            this.CheckRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRun.Name = "CheckRun";
            this.CheckRun.UseVisualStyleBackColor = true;
            // 
            // LabelThanks
            // 
            resources.ApplyResources(this.LabelThanks, "LabelThanks");
            this.LabelThanks.Name = "LabelThanks";
            // 
            // LabelPageDone
            // 
            resources.ApplyResources(this.LabelPageDone, "LabelPageDone");
            this.LabelPageDone.Name = "LabelPageDone";
            // 
            // CheckOpenCC
            // 
            resources.ApplyResources(this.CheckOpenCC, "CheckOpenCC");
            this.CheckOpenCC.Checked = true;
            this.CheckOpenCC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckOpenCC.Name = "CheckOpenCC";
            this.toolTip.SetToolTip(this.CheckOpenCC, resources.GetString("CheckOpenCC.ToolTip"));
            this.CheckOpenCC.UseVisualStyleBackColor = true;
            // 
            // CheckShortcut
            // 
            resources.ApplyResources(this.CheckShortcut, "CheckShortcut");
            this.CheckShortcut.Checked = true;
            this.CheckShortcut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckShortcut.Name = "CheckShortcut";
            this.CheckShortcut.UseVisualStyleBackColor = true;
            // 
            // LabelFileWarn
            // 
            resources.ApplyResources(this.LabelFileWarn, "LabelFileWarn");
            this.LabelFileWarn.ForeColor = System.Drawing.Color.Red;
            this.LabelFileWarn.Name = "LabelFileWarn";
            // 
            // LabelStatus
            // 
            resources.ApplyResources(this.LabelStatus, "LabelStatus");
            this.LabelStatus.Name = "LabelStatus";
            // 
            // ProgressInstall
            // 
            resources.ApplyResources(this.ProgressInstall, "ProgressInstall");
            this.ProgressInstall.Name = "ProgressInstall";
            this.ProgressInstall.Step = 50;
            // 
            // LableInstallWarn
            // 
            resources.ApplyResources(this.LableInstallWarn, "LableInstallWarn");
            this.LableInstallWarn.ForeColor = System.Drawing.Color.Red;
            this.LableInstallWarn.Name = "LableInstallWarn";
            // 
            // CheckStartUpMenu
            // 
            resources.ApplyResources(this.CheckStartUpMenu, "CheckStartUpMenu");
            this.CheckStartUpMenu.Checked = true;
            this.CheckStartUpMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckStartUpMenu.Name = "CheckStartUpMenu";
            this.CheckStartUpMenu.UseVisualStyleBackColor = true;
            // 
            // CheckAssociation
            // 
            resources.ApplyResources(this.CheckAssociation, "CheckAssociation");
            this.CheckAssociation.Checked = true;
            this.CheckAssociation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAssociation.Name = "CheckAssociation";
            this.CheckAssociation.UseVisualStyleBackColor = true;
            // 
            // RBUnzip
            // 
            resources.ApplyResources(this.RBUnzip, "RBUnzip");
            this.RBUnzip.Name = "RBUnzip";
            this.toolTip.SetToolTip(this.RBUnzip, resources.GetString("RBUnzip.ToolTip"));
            this.RBUnzip.UseVisualStyleBackColor = true;
            // 
            // RBInstall
            // 
            resources.ApplyResources(this.RBInstall, "RBInstall");
            this.RBInstall.Checked = true;
            this.RBInstall.Name = "RBInstall";
            this.RBInstall.TabStop = true;
            this.RBInstall.UseVisualStyleBackColor = true;
            this.RBInstall.CheckedChanged += new System.EventHandler(this.RBInstall_CheckedChanged);
            // 
            // LabelPath
            // 
            resources.ApplyResources(this.LabelPath, "LabelPath");
            this.LabelPath.Name = "LabelPath";
            // 
            // LabelConfirmTitle
            // 
            resources.ApplyResources(this.LabelConfirmTitle, "LabelConfirmTitle");
            this.LabelConfirmTitle.Name = "LabelConfirmTitle";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 3000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            this.toolTip.ShowAlways = true;
            // 
            // Index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.PageConfirm);
            this.Controls.Add(this.PageDirectory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InstallerIcon)).EndInit();
            this.BoxLicense.ResumeLayout(false);
            this.BoxPath.ResumeLayout(false);
            this.BoxPath.PerformLayout();
            this.PageDirectory.ResumeLayout(false);
            this.PageConfirm.ResumeLayout(false);
            this.PageConfirm.PerformLayout();
            this.PageDone.ResumeLayout(false);
            this.PageDone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox CheckOpenCC;
        public System.Windows.Forms.Button ButtonCancel;
        public System.Windows.Forms.Button ButtonNext;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LabelConfirm;
        public System.Windows.Forms.Label LabelDir;
        public System.Windows.Forms.Label LabelArrow2;
        public System.Windows.Forms.Label LabelDone;
        public System.Windows.Forms.Label LabelArrow1;
        public System.Windows.Forms.Panel Background;
        public System.Windows.Forms.PictureBox InstallerIcon;
        public System.Windows.Forms.RichTextBox TextBoxLicense;
        public System.Windows.Forms.TextBox BoxDirectoryPath;
        public System.Windows.Forms.GroupBox BoxLicense;
        public System.Windows.Forms.Label LabelWelcome;
        public System.Windows.Forms.Button ButtonChoosePath;
        public System.Windows.Forms.GroupBox BoxPath;
        public System.Windows.Forms.Label LabelWarning;
        public System.Windows.Forms.Panel PageDirectory;
        public System.Windows.Forms.Panel PageConfirm;
        public System.Windows.Forms.Button ButtonBack;
        public System.Windows.Forms.Button ButtonInstall;
        public System.Windows.Forms.Label LabelConfirmTitle;
        public System.Windows.Forms.RadioButton RBUnzip;
        public System.Windows.Forms.RadioButton RBInstall;
        public System.Windows.Forms.Label LabelPath;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.CheckBox CheckStartUpMenu;
        public System.Windows.Forms.CheckBox CheckAssociation;
        public System.Windows.Forms.Label LableInstallWarn;
        public System.Windows.Forms.Label LabelStatus;
        public System.Windows.Forms.ProgressBar ProgressInstall;
        public System.Windows.Forms.Label LabelFileWarn;
        public System.Windows.Forms.CheckBox CheckShortcut;
        public System.Windows.Forms.Label LabelThanks;
        public System.Windows.Forms.Label LabelPageDone;
        public System.Windows.Forms.Button ButtonFinish;
        public System.Windows.Forms.CheckBox CheckGithub;
        public System.Windows.Forms.CheckBox CheckRun;
        public System.Windows.Forms.Panel PageDone;
    }
}

