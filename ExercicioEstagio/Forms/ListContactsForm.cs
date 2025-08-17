using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExercicioEstagio.Forms;
using ExercicioEstagio.Services;
using ExercicioEstagio.Models;

namespace ExercicioEstagio
{
    public partial class ListContactsForm : Form
    {
        private ContactService contactService = new ContactService();
        private ReportService reportService = new ReportService();
        private Contact selectedContact;
        public ListContactsForm()
        {
            InitializeComponent();
        }

        private void ListContactsForm_Load(object sender, EventArgs e)
        {
            ConfigureBtn();
            ConfigureTxt();
            LoadContacts().Wait();
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


            // Estilos
            dataGrid_contacts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGrid_contacts.BackgroundColor = Color.FromArgb(60, 65, 87);
            dataGrid_contacts.BorderStyle = BorderStyle.None;

            dataGrid_contacts.DefaultCellStyle.BackColor = Color.FromArgb(60, 65, 87);
            dataGrid_contacts.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGrid_contacts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 33, 182);
            dataGrid_contacts.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGrid_contacts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 75, 97);
            dataGrid_contacts.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGrid_contacts.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 33, 182);
            dataGrid_contacts.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dataGrid_contacts.EnableHeadersVisualStyles = false;
            dataGrid_contacts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(91, 33, 182); 
            dataGrid_contacts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid_contacts.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGrid_contacts.ColumnHeadersDefaultCellStyle.BackColor;

            
            dataGrid_contacts.RowHeadersVisible = true;
            dataGrid_contacts.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 65, 87); 
            dataGrid_contacts.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGrid_contacts.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 33, 182);
            dataGrid_contacts.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dataGrid_contacts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid_contacts.GridColor = Color.FromArgb(80, 85, 107);
            dataGrid_contacts.AllowUserToOrderColumns = false;

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

        private async void btn_report_Click(object sender, EventArgs e)
        {
            txt_report.Clear();
            txt_report.Text = await reportService.GetContactsReport();
        }

        private void ConfigureTxt()
        {

            txt_report.ScrollBars = ScrollBars.Vertical;

            if (txt_report != null) // Verifica se a TextBox existe
            {
                txt_report.BackColor = Color.FromArgb(60, 65, 87); // Fundo azul escuro
                txt_report.ForeColor = Color.FromArgb(220, 220, 220); // Texto cinza claro
                txt_report.BorderStyle = BorderStyle.FixedSingle; // Borda fina
                txt_report.Font = new Font("Segoe UI", 10); // Fonte moderna

                // Efeito de foco
                txt_report.Enter += (s, ev) =>
                {
                    txt_report.BorderStyle = BorderStyle.Fixed3D; // Borda mais visível ao focar
                    txt_report.BackColor = Color.FromArgb(70, 75, 97); // Leve escurecimento
                };
                txt_report.Leave += (s, ev) =>
                {
                    txt_report.BorderStyle = BorderStyle.FixedSingle; // Volta à borda fina
                    txt_report.BackColor = Color.FromArgb(60, 65, 87); // Volta ao fundo original
                };
            }
        }
        private void ConfigureBtn()
        {
            BaseBtnConfiguration(btn_insert);
            btn_insert.BackColor = Color.FromArgb(124, 58, 237);
            btn_insert.MouseEnter += (s, ev) => { btn_insert.BackColor = Color.FromArgb(124, 58, 237); };
            btn_insert.MouseLeave += (s, ev) => { btn_insert.BackColor = Color.FromArgb(124, 58, 237); };

            BaseBtnConfiguration(btn_edit);
            btn_edit.BackColor = Color.FromArgb(124, 58, 237);
            btn_edit.MouseEnter += (s, ev) => { btn_edit.BackColor = Color.FromArgb(124, 58, 237); };
            btn_edit.MouseLeave += (s, ev) => { btn_edit.BackColor = Color.FromArgb(124, 58, 237); };

            BaseBtnConfiguration(btn_delete);
            btn_delete.BackColor = Color.FromArgb(239, 68, 68);
            btn_delete.MouseEnter += (s, ev) => { btn_delete.BackColor = Color.FromArgb(220, 38, 38); };
            btn_delete.MouseLeave += (s, ev) => { btn_delete.BackColor = Color.FromArgb(239, 68, 68); };

            BaseBtnConfiguration(btn_report);
            btn_report.BackColor = Color.FromArgb(234, 88, 12);
            btn_report.MouseEnter += (s, ev) => { btn_report.BackColor = Color.FromArgb(234, 88, 12); };
            btn_report.MouseLeave += (s, ev) => { btn_report.BackColor = Color.FromArgb(234, 88, 12); };

        }

        private void BaseBtnConfiguration(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            btn.Cursor = Cursors.Hand;
        }
    }
}
