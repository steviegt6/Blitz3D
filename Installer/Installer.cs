using System;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using System.Diagnostics;

/*
 * I don't like write comments because i need use translator to check me grammar   :((((
 * If you met incomprehensible words, they're chinese, because im chinese  :D
 * pls help me optimize codes, im not professional with c#
 * 
 * For best scroll page experience, all page are save in one window,
 * use ScroolPage method to change things its displaying
 * 
 * the only readable comment in codes, 
 * ZiYueCommentary
 */

namespace Installer
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            ScrollPage(1);
        }

        private void EventCancel(object sender, EventArgs e)
        {
            new WindowCancel().ShowDialog();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            LabelWarning.Show();
            if (BoxDirectoryPath.Text == "")
            {
                LabelWarning.Text = "Path is empty.";
                return;
            }
            else if (Directory.GetDirectoryRoot(BoxDirectoryPath.Text) == BoxDirectoryPath.Text)
            { 
                LabelWarning.Text = "You can't install Blitz3D TSS in root path.";
                return;
            }
            else if (BoxDirectoryPath.Text.Contains("Program Files") && BoxDirectoryPath.Text.Contains("C:\\"))
            {
                LabelWarning.Text = "Do not install Blitz3D TSS in Program Files.";
                return;
            }

            ScrollPage(2);
        }

        private void ButtonChoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) BoxDirectoryPath.Text = dialog.SelectedPath + "\\Blitz3D TSS";
        }

        private void ScrollPage(byte page)
        {
            switch (page)
            {
                case 1:
                    ButtonCancel.Show();
                    ButtonNext.Show();
                    panel1.Show();
                    LabelArrow1.Show();
                    LabelArrow2.Show();
                    LabelConfirm.Show();
                    LabelDir.Show();
                    Background.Show();
                    InstallerIcon.Show();
                    PageDirectory.Show();
                    PageConfirm.Hide();
                    ButtonInstall.Hide();
                    ButtonBack.Hide();
                    LabelWarning.Hide();
                    ButtonFinish.Hide();
                    PageDone.Hide();
                    LabelWelcome.Text = "Welcome to the Blitz3D TSS "+ProductVersion+" Setup Wizard";
                    LabelDir.Font = new System.Drawing.Font("Consolas", 9, System.Drawing.FontStyle.Bold);
                    LabelConfirm.Font = new System.Drawing.Font("Consolas", 9);
                    break;
                case 2:
                    PageDirectory.Hide();
                    PageConfirm.Show();
                    ButtonNext.Hide();
                    ButtonInstall.Show();
                    ButtonBack.Show();
                    LabelStatus.Hide();
                    ProgressInstall.Hide();
                    ButtonFinish.Hide();
                    PageDone.Hide();
                    LabelPath.Text = "Install Directory: " + BoxDirectoryPath.Text;
                    LabelStatus.Text = "Installing Blitz3D TSS " + ProductVersion + "...";
                    LabelDir.Font = new System.Drawing.Font("Consolas", 9);
                    LabelConfirm.Font = new System.Drawing.Font("Consolas", 9, System.Drawing.FontStyle.Bold);
                    break;
                case 3:
                    PageDone.Show();
                    //PageConfirm.Hide();
                    ButtonInstall.Hide();
                    ButtonBack.Hide();
                    ButtonCancel.Hide();
                    ButtonFinish.Show();
                    LabelConfirm.Font = new System.Drawing.Font("Consolas", 9);
                    LabelDone.Font = new System.Drawing.Font("Consolas", 9, System.Drawing.FontStyle.Bold);
                    LabelThanks.Text = "Thank you for installing Blitz3D TSS " + ProductVersion + "!";
                    break;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ScrollPage(1);
        }

        private void RBInstall_CheckedChanged(object sender, EventArgs e)
        {
            if (RBInstall.Checked)
            {
                CheckAssociation.Enabled = true;
                CheckStartUpMenu.Enabled = true;
            }
            else
            {
                CheckAssociation.Enabled = false;
                CheckStartUpMenu.Enabled = false;
                CheckAssociation.Checked = false;
                CheckStartUpMenu.Checked = false;
                CheckShortcut.Checked = false;
            }
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            PageConfirm.Enabled = false;
            ButtonBack.Enabled = false;
            ButtonInstall.Enabled = false;
            ButtonCancel.Enabled = false;

            ControlBox = false;
            LabelStatus.Show();
            ProgressInstall.Show();
            LabelStatus.Text = "Writing temporary file...";
            try
            {
                if (Directory.Exists(BoxDirectoryPath.Text)) Directory.Delete(BoxDirectoryPath.Text, true);
                if (!Directory.Exists(BoxDirectoryPath.Text)) Directory.CreateDirectory(BoxDirectoryPath.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A error encountered when creating/deleting folder!\r\nPlease try again with run as Administrator.", "Catastrophic error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            ProgressInstall.Value += 30;
            LabelStatus.Text = "Extracting zip file...";
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(Properties.Resources.zipFile.FullName, BoxDirectoryPath.Text);
            }
            catch (IOException)
            {
                MessageBox.Show("A error encountered when installing Blitz3D TSS!\r\nPlease delete target directory manual or run as Administrator.", "Catastrophic error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            ProgressInstall.Value += 20;
            Properties.Resources.zipFile.Delete(); //...delete it after extract

            ProgressInstall.Value += 20;

            LabelStatus.Text = "Last step...";
            if (CheckAssociation.Checked)
            {
                try
                {
                    SaveReg(BoxDirectoryPath.Text + "\\Blitz3D.exe", ".bb");
                    ProgressInstall.Value += 15;
                }
                catch (Exception)
                {
                }
            }
            if (CheckShortcut.Checked) CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Blitz3D TSS", BoxDirectoryPath.Text + "\\Blitz3D.exe");
            if (CheckStartUpMenu.Checked) CreateStartupMenuShortcut("Blitz3D TSS", BoxDirectoryPath.Text + "\\Blitz3D.exe", BoxDirectoryPath.Text + "\\Blitz3D.exe");
            ProgressInstall.Value += 15;
            ControlBox = true;
            ScrollPage(3); 
            PageConfirm.Enabled = true;
            ButtonBack.Enabled = true;
            ButtonInstall.Enabled = true;
            ButtonCancel.Enabled = true;
        }
        public static void CreateShortcut(string directory, string shortcutName, string targetPath,
           string description = null, string iconLocation = null)
        {
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

            string shortcutPath = Path.Combine(directory, string.Format("{0}.lnk", shortcutName));
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            shortcut.TargetPath = targetPath;
            shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);
            shortcut.WindowStyle = 1;
            shortcut.Description = description;
            shortcut.IconLocation = string.IsNullOrWhiteSpace(iconLocation) ? targetPath : iconLocation;
            shortcut.Save();
        }

        public static void CreateStartupMenuShortcut(string lnkName, string targetPath, string iconLocation)
        {
            string pathToExe = targetPath;
            string commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
            string appStartMenuPath = Path.Combine(commonStartMenuPath,"Programs"); 
            if(!Directory.Exists(appStartMenuPath)) Directory.CreateDirectory(appStartMenuPath); 
            string shortcutLocation = Path.Combine(appStartMenuPath,lnkName+".lnk"); 
            WshShell shell = new WshShell(); 
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation); 
            shortcut.Description = "Blitz3D TSS";
            shortcut.TargetPath = pathToExe; 
            shortcut.Save();
        }

        private static void SaveReg(string _FilePathString, string p_FileTypeName)
        {
            RegistryKey _RegKey = Registry.ClassesRoot.OpenSubKey("", true);
            RegistryKey _VRPkey = _RegKey.OpenSubKey(p_FileTypeName, true);
            if (_VRPkey != null)
            {
                _RegKey.DeleteSubKey(p_FileTypeName, true);
            }
            _RegKey.CreateSubKey(p_FileTypeName);
            _VRPkey = _RegKey.OpenSubKey(p_FileTypeName, true);
            _VRPkey.SetValue("", "Exec");
            _VRPkey = _RegKey.OpenSubKey("Exec", true);
            if (_VRPkey != null)
            {
                _RegKey.DeleteSubKeyTree("Exec");
            }
            _RegKey.CreateSubKey("Exec");
            _VRPkey = _RegKey.OpenSubKey("Exec", true);

            _VRPkey.CreateSubKey("shell");
            _VRPkey = _VRPkey.OpenSubKey("shell", true); 

            _VRPkey.CreateSubKey("open");
            _VRPkey = _VRPkey.OpenSubKey("open", true);

            _VRPkey.CreateSubKey("command");
            _VRPkey = _VRPkey.OpenSubKey("command", true);

            string _PathString = "\"" + _FilePathString + "\" \"%1\"";
            _VRPkey.SetValue("", _PathString); 

            _RegKey.CreateSubKey("DefaultIcon");
            _RegKey.SetValue("", Application.StartupPath + "\\" + "Blitz3D.exe");
            _VRPkey = _VRPkey.OpenSubKey("DefaultIcon", true);
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            if (CheckRun.Checked)
                Process.Start(BoxDirectoryPath.Text + "\\Blitz3D.exe");
            if (CheckGithub.Checked)
                Process.Start("https://github.com/ZiYueCommentary/Blitz3D");
            Environment.Exit(0);
        }
    }
}
