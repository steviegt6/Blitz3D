using System;
using System.Windows.Forms;

namespace Installer
{
    internal static class Program
    {
        public static string langName = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Index());
        }
    }
}
