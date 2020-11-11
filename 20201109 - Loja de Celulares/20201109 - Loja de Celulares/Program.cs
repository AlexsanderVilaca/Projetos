using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _20201109___Loja_de_Celulares
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
            Application.Run(new Form1());
        }
    }
}
