using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using ExercicioEstagio.Data;

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
            //ConnectionService connectionService = new ConnectionService();

            //using (var conn = connectionService.GetConnection())
            //{
            //    conn.Open();

            //    using (var command = new OleDbCommand("SELECT CodContato, Nome, Cidade, Sexo, [Data] FROM Contatos", conn))
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(
            //                $"Id: {reader["CodContato"]}, " +
            //                $"Nome: {reader["Nome"]}, " +
            //                $"Cidade: {reader["Cidade"]}, " +
            //                $"Sexo: {reader["Sexo"]}, " +
            //                $"Data: {reader["Data"]}"
            //            );
            //        }
            //    }
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListContactsForm());

        }
    }
}
