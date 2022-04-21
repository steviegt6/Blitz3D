using System;
using System.Windows.Forms;

namespace Installer
{
    public partial class WindowCancel : Form
    {
        public WindowCancel()
        {
            InitializeComponent();
        }

        private void WindowCancel_Load(object sender, EventArgs e)
        {
        }

        private void ButtonCancelNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCancelYes_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
