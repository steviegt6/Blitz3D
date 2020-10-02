namespace CompilerGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bbFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.quietMode = new System.Windows.Forms.CheckBox();
            this.vQuietMode = new System.Windows.Forms.CheckBox();
            this.compileOnly = new System.Windows.Forms.CheckBox();
            this.debugCompile = new System.Windows.Forms.CheckBox();
            this.dKeywords = new System.Windows.Forms.CheckBox();
            this.dKeywordsSyntax = new System.Windows.Forms.CheckBox();
            this.genExe = new System.Windows.Forms.CheckBox();
            this.exeName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.extrabutt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bbFile
            // 
            this.bbFile.Location = new System.Drawing.Point(8, 19);
            this.bbFile.Name = "bbFile";
            this.bbFile.Size = new System.Drawing.Size(331, 20);
            this.bbFile.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quietMode
            // 
            this.quietMode.AutoSize = true;
            this.quietMode.Location = new System.Drawing.Point(12, 18);
            this.quietMode.Name = "quietMode";
            this.quietMode.Size = new System.Drawing.Size(80, 17);
            this.quietMode.TabIndex = 4;
            this.quietMode.Text = "Quiet mode";
            this.quietMode.UseVisualStyleBackColor = true;
            // 
            // vQuietMode
            // 
            this.vQuietMode.AutoSize = true;
            this.vQuietMode.Location = new System.Drawing.Point(115, 18);
            this.vQuietMode.Name = "vQuietMode";
            this.vQuietMode.Size = new System.Drawing.Size(102, 17);
            this.vQuietMode.TabIndex = 5;
            this.vQuietMode.Text = "Very quiet mode";
            this.vQuietMode.UseVisualStyleBackColor = true;
            // 
            // compileOnly
            // 
            this.compileOnly.AutoSize = true;
            this.compileOnly.Location = new System.Drawing.Point(223, 18);
            this.compileOnly.Name = "compileOnly";
            this.compileOnly.Size = new System.Drawing.Size(85, 17);
            this.compileOnly.TabIndex = 6;
            this.compileOnly.Text = "Compile only";
            this.compileOnly.UseVisualStyleBackColor = true;
            // 
            // debugCompile
            // 
            this.debugCompile.AutoSize = true;
            this.debugCompile.Location = new System.Drawing.Point(12, 41);
            this.debugCompile.Name = "debugCompile";
            this.debugCompile.Size = new System.Drawing.Size(97, 17);
            this.debugCompile.TabIndex = 7;
            this.debugCompile.Text = "Debug compile";
            this.debugCompile.UseVisualStyleBackColor = true;
            // 
            // dKeywords
            // 
            this.dKeywords.AutoSize = true;
            this.dKeywords.Location = new System.Drawing.Point(115, 41);
            this.dKeywords.Name = "dKeywords";
            this.dKeywords.Size = new System.Drawing.Size(102, 17);
            this.dKeywords.TabIndex = 8;
            this.dKeywords.Text = "Dump keywords";
            this.dKeywords.UseVisualStyleBackColor = true;
            // 
            // dKeywordsSyntax
            // 
            this.dKeywordsSyntax.AutoSize = true;
            this.dKeywordsSyntax.Location = new System.Drawing.Point(223, 41);
            this.dKeywordsSyntax.Name = "dKeywordsSyntax";
            this.dKeywordsSyntax.Size = new System.Drawing.Size(144, 17);
            this.dKeywordsSyntax.TabIndex = 9;
            this.dKeywordsSyntax.Text = "Dump keywords + syntax";
            this.dKeywordsSyntax.UseVisualStyleBackColor = true;
            // 
            // genExe
            // 
            this.genExe.AutoSize = true;
            this.genExe.Location = new System.Drawing.Point(12, 64);
            this.genExe.Name = "genExe";
            this.genExe.Size = new System.Drawing.Size(96, 17);
            this.genExe.TabIndex = 10;
            this.genExe.Text = "Generate .exe:";
            this.genExe.UseVisualStyleBackColor = true;
            // 
            // exeName
            // 
            this.exeName.Location = new System.Drawing.Point(115, 62);
            this.exeName.Name = "exeName";
            this.exeName.Size = new System.Drawing.Size(255, 20);
            this.exeName.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Compile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(217, 190);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(62, 13);
            this.error.TabIndex = 13;
            this.error.Text = "placeholder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exeName);
            this.groupBox1.Controls.Add(this.genExe);
            this.groupBox1.Controls.Add(this.dKeywordsSyntax);
            this.groupBox1.Controls.Add(this.dKeywords);
            this.groupBox1.Controls.Add(this.debugCompile);
            this.groupBox1.Controls.Add(this.compileOnly);
            this.groupBox1.Controls.Add(this.vQuietMode);
            this.groupBox1.Controls.Add(this.quietMode);
            this.groupBox1.Location = new System.Drawing.Point(9, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 94);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flags";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bbFile);
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 56);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // extrabutt
            // 
            this.extrabutt.Location = new System.Drawing.Point(113, 185);
            this.extrabutt.Name = "extrabutt";
            this.extrabutt.Size = new System.Drawing.Size(98, 23);
            this.extrabutt.TabIndex = 16;
            this.extrabutt.Text = "TSS Options";
            this.extrabutt.UseVisualStyleBackColor = true;
            this.extrabutt.Click += new System.EventHandler(this.extrabutt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 220);
            this.Controls.Add(this.extrabutt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BlitzCC 1.118 GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bbFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox quietMode;
        private System.Windows.Forms.CheckBox vQuietMode;
        private System.Windows.Forms.CheckBox compileOnly;
        private System.Windows.Forms.CheckBox debugCompile;
        private System.Windows.Forms.CheckBox dKeywords;
        private System.Windows.Forms.CheckBox dKeywordsSyntax;
        private System.Windows.Forms.CheckBox genExe;
        private System.Windows.Forms.TextBox exeName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button extrabutt;
    }
}

