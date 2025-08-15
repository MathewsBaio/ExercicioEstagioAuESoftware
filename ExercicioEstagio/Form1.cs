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
using ExercicioEstagio.Data;

namespace ExercicioEstagio
{
    public partial class Form1 : Form
    {
        private ConnectionService connectionService = new ConnectionService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

  
            using (var conn = connectionService.GetConnection() )
            {
                try
                {
                    conn.Open();
                    checkConnection.Text = "Conexão aberta com sucesso!";
                }
                catch (Exception ex)
                {
                    checkConnection.Text = "Erro ao abrir a conexão: " + ex.Message;
                    return;
                }
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
