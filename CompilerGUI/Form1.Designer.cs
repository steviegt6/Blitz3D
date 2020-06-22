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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.quietMode = new System.Windows.Forms.CheckBox();
            this.vQuietMode = new System.Windows.Forms.CheckBox();
            this.compileOnly = new System.Windows.Forms.CheckBox();
            this.debugCompile = new System.Windows.Forms.CheckBox();
            this.dKeywords = new System.Windows.Forms.CheckBox();
            this.dKeywordsSyntax = new System.Windows.Forms.CheckBox();
            this.genExe = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "File to compile:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compiler flags:";
            // 
            // quietMode
            // 
            this.quietMode.AutoSize = true;
            this.quietMode.Location = new System.Drawing.Point(18, 110);
            this.quietMode.Name = "quietMode";
            this.quietMode.Size = new System.Drawing.Size(80, 17);
            this.quietMode.TabIndex = 4;
            this.quietMode.Text = "Quiet mode";
            this.quietMode.UseVisualStyleBackColor = true;
            // 
            // vQuietMode
            // 
            this.vQuietMode.AutoSize = true;
            this.vQuietMode.Location = new System.Drawing.Point(104, 110);
            this.vQuietMode.Name = "vQuietMode";
            this.vQuietMode.Size = new System.Drawing.Size(102, 17);
            this.vQuietMode.TabIndex = 5;
            this.vQuietMode.Text = "Very quiet mode";
            this.vQuietMode.UseVisualStyleBackColor = true;
            // 
            // compileOnly
            // 
            this.compileOnly.AutoSize = true;
            this.compileOnly.Location = new System.Drawing.Point(212, 110);
            this.compileOnly.Name = "compileOnly";
            this.compileOnly.Size = new System.Drawing.Size(85, 17);
            this.compileOnly.TabIndex = 6;
            this.compileOnly.Text = "Compile only";
            this.compileOnly.UseVisualStyleBackColor = true;
            // 
            // debugCompile
            // 
            this.debugCompile.AutoSize = true;
            this.debugCompile.Location = new System.Drawing.Point(18, 133);
            this.debugCompile.Name = "debugCompile";
            this.debugCompile.Size = new System.Drawing.Size(97, 17);
            this.debugCompile.TabIndex = 7;
            this.debugCompile.Text = "Debug compile";
            this.debugCompile.UseVisualStyleBackColor = true;
            // 
            // dKeywords
            // 
            this.dKeywords.AutoSize = true;
            this.dKeywords.Location = new System.Drawing.Point(121, 133);
            this.dKeywords.Name = "dKeywords";
            this.dKeywords.Size = new System.Drawing.Size(102, 17);
            this.dKeywords.TabIndex = 8;
            this.dKeywords.Text = "Dump keywords";
            this.dKeywords.UseVisualStyleBackColor = true;
            // 
            // dKeywordsSyntax
            // 
            this.dKeywordsSyntax.AutoSize = true;
            this.dKeywordsSyntax.Location = new System.Drawing.Point(229, 133);
            this.dKeywordsSyntax.Name = "dKeywordsSyntax";
            this.dKeywordsSyntax.Size = new System.Drawing.Size(144, 17);
            this.dKeywordsSyntax.TabIndex = 9;
            this.dKeywordsSyntax.Text = "Dump keywords + syntax";
            this.dKeywordsSyntax.UseVisualStyleBackColor = true;
            // 
            // genExe
            // 
            this.genExe.AutoSize = true;
            this.genExe.Location = new System.Drawing.Point(18, 156);
            this.genExe.Name = "genExe";
            this.genExe.Size = new System.Drawing.Size(96, 17);
            this.genExe.TabIndex = 10;
            this.genExe.Text = "Generate .exe:";
            this.genExe.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 20);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Compile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(101, 190);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 220);
            this.Controls.Add(this.error);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.genExe);
            this.Controls.Add(this.dKeywordsSyntax);
            this.Controls.Add(this.dKeywords);
            this.Controls.Add(this.debugCompile);
            this.Controls.Add(this.compileOnly);
            this.Controls.Add(this.vQuietMode);
            this.Controls.Add(this.quietMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BlitzCC 1.118 GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox quietMode;
        private System.Windows.Forms.CheckBox vQuietMode;
        private System.Windows.Forms.CheckBox compileOnly;
        private System.Windows.Forms.CheckBox debugCompile;
        private System.Windows.Forms.CheckBox dKeywords;
        private System.Windows.Forms.CheckBox dKeywordsSyntax;
        private System.Windows.Forms.CheckBox genExe;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label error;
    }
}

