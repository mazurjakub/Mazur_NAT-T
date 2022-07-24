using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mazur_NAT_T
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Setting scale to DPI, so it wouldn't be blurry on high-DPI monitors
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
