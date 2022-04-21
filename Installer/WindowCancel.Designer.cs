namespace Installer
{
    partial class WindowCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowCancel));
            this.TextWarn = new System.Windows.Forms.Label();
            this.ButtonCancelYes = new System.Windows.Forms.Button();
            this.ButtonCancelNo = new System.Windows.Forms.Button();
            this.WarningIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TextWarn
            // 
            this.TextWarn.AutoSize = true;
            this.TextWarn.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextWarn.Location = new System.Drawing.Point(76, 18);
            this.TextWarn.Name = "TextWarn";
            this.TextWarn.Size = new System.Drawing.Size(224, 14);
            this.TextWarn.TabIndex = 2;
            this.TextWarn.Text = "Are you sure to cancel install?";
            // 
            // ButtonCancelYes
            // 
            this.ButtonCancelYes.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonCancelYes.Location = new System.Drawing.Point(94, 48);
            this.ButtonCancelYes.Name = "ButtonCancelYes";
            this.ButtonCancelYes.Size = new System.Drawing.Size(70, 22);
            this.ButtonCancelYes.TabIndex = 1;
            this.ButtonCancelYes.Text = "&Yes";
            this.ButtonCancelYes.UseVisualStyleBackColor = true;
            this.ButtonCancelYes.Click += new System.EventHandler(this.ButtonCancelYes_Click);
            // 
            // ButtonCancelNo
            // 
            this.ButtonCancelNo.Font = new System.Drawing.Font("Consolas", 9F);
            this.ButtonCancelNo.Location = new System.Drawing.Point(198, 48);
            this.ButtonCancelNo.Name = "ButtonCancelNo";
            this.ButtonCancelNo.Size = new System.Drawing.Size(70, 22);
            this.ButtonCancelNo.TabIndex = 0;
            this.ButtonCancelNo.Text = "&No";
            this.ButtonCancelNo.UseVisualStyleBackColor = true;
            this.ButtonCancelNo.Click += new System.EventHandler(this.ButtonCancelNo_Click);
            // 
            // WarningIcon
            // 
            this.WarningIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WarningIcon.Image = global::Installer.Properties.Resources.warning;
            this.WarningIcon.Location = new System.Drawing.Point(12, 17);
            this.WarningIcon.Name = "WarningIcon";
            this.WarningIcon.Size = new System.Drawing.Size(50, 50);
            this.WarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WarningIcon.TabIndex = 0;
            this.WarningIcon.TabStop = false;
            // 
            // WindowCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 88);
            this.Controls.Add(this.ButtonCancelNo);
            this.Controls.Add(this.ButtonCancelYes);
            this.Controls.Add(this.TextWarn);
            this.Controls.Add(this.WarningIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowCancel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancel?";
            this.Load += new System.EventHandler(this.WindowCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WarningIcon;
        private System.Windows.Forms.Label TextWarn;
        private System.Windows.Forms.Button ButtonCancelYes;
        private System.Windows.Forms.Button ButtonCancelNo;
    }
}