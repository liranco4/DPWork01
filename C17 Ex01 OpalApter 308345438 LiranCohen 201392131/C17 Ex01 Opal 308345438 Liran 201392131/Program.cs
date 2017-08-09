using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
        }
    }
}
