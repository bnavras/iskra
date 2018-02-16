using System;
using System.Windows.Forms;

namespace Iskra.App
{
    static class Program
    {
        /// <summary>
        /// Iskra Information System
        /// Developer: Bokiev Navras
        /// Application Layer
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
