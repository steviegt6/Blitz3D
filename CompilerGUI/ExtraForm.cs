using System;
using System.Windows.Forms;

namespace CompilerGUI
{
    public partial class ExtraOpts : Form
    {
        public ExtraOpts()
        {
            InitializeComponent();
            laaCheck.Checked = MainForm.LargeAddressAware;
        }

        private void laaCheck_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.LargeAddressAware = laaCheck.Checked;
            if (laaCheck.Checked) MainForm.ArgumentList.Add("-laa");
            else MainForm.ArgumentList.Remove("-laa");
        }
    }
}
