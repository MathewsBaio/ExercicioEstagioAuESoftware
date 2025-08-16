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
using ExercicioEstagio.Forms;

namespace ExercicioEstagio
{
    public partial class ListContactsForm : Form
    {
        private ConnectionService connectionService = new ConnectionService();
        public ListContactsForm()
        {
            InitializeComponent();
        }

        private void ListContactsForm_Load(object sender, EventArgs e)
        {
           
            MessageBox.Show("Carregando contatos...");


        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertContactForm modal = new InsertContactForm(this);
            modal.ShowDialog();
        }
    }
}
