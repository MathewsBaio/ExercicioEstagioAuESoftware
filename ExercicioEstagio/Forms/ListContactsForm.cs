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
using ExercicioEstagio.Services;
using ExercicioEstagio.Models;

namespace ExercicioEstagio
{
    public partial class ListContactsForm : Form
    {
        private ContactService contactService = new ContactService();
        private Contact selectedContact;
        public ListContactsForm()
        {
            InitializeComponent();
        }

        private void ListContactsForm_Load(object sender, EventArgs e)
        {

            LoadContacts();
            SetDataGrid();

        }

        public async Task LoadContacts()
        {
            dataGrid_contacts.DataSource = await contactService.GetAllContactsAsync();


        }

        private void SetDataGrid()
        {
            dataGrid_contacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_contacts.Columns["Id"].HeaderText = "Código";
            dataGrid_contacts.Columns["RegisterDate"].HeaderText = "Data de Registro";
            dataGrid_contacts.Columns["Name"].HeaderText = "Nome";
            dataGrid_contacts.Columns["City"].HeaderText = "Cidade";
            dataGrid_contacts.Columns["Gender"].HeaderText = "Sexo";

            dataGrid_contacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_contacts.MultiSelect = false;
            dataGrid_contacts.ReadOnly = true;
        }

        private void dataGrid_contacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_contacts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid_contacts.SelectedRows[0];
                
                selectedContact = (Contact)selectedRow.DataBoundItem;

                
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertContactForm modal = new InsertContactForm(this, contactService);
            modal.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditContactForm modal = new EditContactForm(this, selectedContact, contactService);
            modal.ShowDialog();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedContact == null)
            {
                MessageBox.Show("Selecione um contato da tabela para excluir.");
                return;
            }

            DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir o(a) contato {selectedContact.Name}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await contactService.DeleteContactAsync(selectedContact.Id);
                    MessageBox.Show("Contato excluído com sucesso!");
                    await LoadContacts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir contato: " + ex.Message);
                }
            }
        }
    }
}
