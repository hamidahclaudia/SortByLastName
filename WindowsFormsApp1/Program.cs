using System;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.ApplicationService;
using WindowsFormsApp1.ApplicationShared.FileHelper;
using WindowsFormsApp1.ApplicationShared.SortName;

namespace SortByLastNameApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FileHelper fileHelper = new FileHelper();
            SortName sortName = new SortName();

            IFileHelper iFileHelper = fileHelper;
            ISortName iSortName = sortName;

            Application.Run(new Form1(iFileHelper, iSortName));
        }
    }
}
