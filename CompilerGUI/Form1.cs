using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CompilerGUI
{
    public partial class MainForm : Form
    {
        string fileToCompile = string.Empty;
        string execute = "/k blitzcc.exe ";
        public MainForm()
        {
            InitializeComponent();
        }

        //I know this isnt the cleanest code, but come on, its just 2 functions.
        private void MainForm_Load(object sender, EventArgs e)
        {
            error.Text = string.Empty;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if (!File.Exists("blitzcc.exe"))
            {
                MessageBox.Show("blitzcc.exe must be in the same directory as the GUI!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2.Enabled = false;
            }
            else button2.Enabled = true;
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
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileToCompile = textBox1.Text;
            error.Text = string.Empty;
            fileToCompile = fixPathSpaces(fileToCompile);

            if(fileToCompile == string.Empty)
            {
                error.Text = "Choose a file to compile!";
                return;
            }
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
            execute = "/k blitzcc.exe ";
            fileToCompile = string.Empty;
        }

        string fixPathSpaces(string path)
        {
            if (path.Contains(" "))
            {
                return $"\"{path}\"";
            }
            else return path;
        }
    }
}
