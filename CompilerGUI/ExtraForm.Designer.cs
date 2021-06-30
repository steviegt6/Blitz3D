namespace CompilerGUI
{
    partial class ExtraOpts
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
            this.label1 = new System.Windows.Forms.Label();
            this.laaCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "These options won\'t work in vanilla B3D!";
            // 
            // laaCheck
            // 
            this.laaCheck.AutoSize = true;
            this.laaCheck.Location = new System.Drawing.Point(12, 30);
            this.laaCheck.Name = "laaCheck";
            this.laaCheck.Size = new System.Drawing.Size(127, 17);
            this.laaCheck.TabIndex = 0;
            this.laaCheck.Text = "Large Address Aware";
            this.laaCheck.UseVisualStyleBackColor = true;
            this.laaCheck.CheckedChanged += new System.EventHandler(this.laaCheck_CheckedChanged);
            // 
            // ExtraOpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 59);
            this.Controls.Add(this.laaCheck);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExtraOpts";
            this.ShowIcon = false;
            this.Text = "Extra Blitz3D TSS Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox laaCheck;
    }
}