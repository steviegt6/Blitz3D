using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerGUI
{
    public partial class ExtraOpts : Form
    {
        public ExtraOpts()
        {
            InitializeComponent();
            if (MainForm.laa == true) laaCheck.Checked = true;
            else laaCheck.Checked = false;
        }

        private void laaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (laaCheck.Checked == true) MainForm.laa = true;
            else MainForm.laa = false;
        }
    }
}
