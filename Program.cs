using System;
using System.Windows.Forms;
using DataGrid.Framework.ApplicantManager;
using DataGrid.Storage.Memory;

namespace DataGrid
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storage = new MemoryApplicantStorage();
            var manager = new ApplicantManager(storage);

            Application.Run(new Form1(manager));
        }
    }
}
