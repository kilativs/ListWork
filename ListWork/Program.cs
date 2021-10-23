using ListWork.Forms;
using System;
using System.Windows.Forms;

namespace ListWork
{
    internal static class Program
    {
        public const string Url = "https://localhost:5001/api";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ListWorkForm.GetInstance());
        }
    }
}
