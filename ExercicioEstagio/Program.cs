using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using ExercicioEstagio.Data;
using ExercicioEstagio.Services;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioEstagio
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ReportService repo = new ReportService();

            //string report =  repo.GetContactsReport().GetAwaiter().GetResult();

            //Console.WriteLine(report);
            //Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListContactsForm());

        }

 
    }
}
