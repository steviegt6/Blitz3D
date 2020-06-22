using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerGUI
{
    public partial class MainForm : Form
    {
        string fileToCompile;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "BlitzBasic files (*.bb)|*.bb";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileToCompile = openFileDialog1.FileName;
                textBox1.Text = fileToCompile;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string execute = "/k blitzcc.exe ";
            if(genExe.Checked == true && textBox2.Text == string.Empty)
            {
                error.Text = "Executable name can't be empty!";
                return;
            }
            else if(genExe.Checked == true && textBox2.Text != string.Empty)
            {
                execute += string.Format("-o {0} ", textBox2.Text);
            }
            if(quietMode.Checked == true)
            {
                execute += "-q ";
            }
            if(vQuietMode.Checked == true)
            {
                execute += "+q ";
            }
            if(compileOnly.Checked == true)
            {
                execute += "-c ";
            }
            if(debugCompile.Checked == true)
            {
                execute += "-d ";
            }
            if(dKeywords.Checked == true)
            {
                execute += "-k ";
            }
            if (dKeywordsSyntax.Checked == true)
            {
                execute += "+k ";
            }
            execute += fileToCompile;
            Trace.WriteLine(execute);
            Process.Start("CMD.exe", execute);
        }
    }
}
