using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ExercicioEstagio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OleDbConnection connection = new OleDbConnection();

            string pathDB = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"auebd.mdb");
            pathDB = System.IO.Path.GetFullPath(pathDB);

            connection.ConnectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={pathDB};";

            try
            {
                connection.Open();
                checkConnection.Text = "Conexão aberta com sucesso!";
            }
            catch (Exception ex)
            {
                checkConnection.Text = "Erro ao abrir a conexão: " + ex.Message;
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
