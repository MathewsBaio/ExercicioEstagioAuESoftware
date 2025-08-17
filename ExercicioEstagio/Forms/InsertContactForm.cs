using ExercicioEstagio.Models;
using ExercicioEstagio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioEstagio.Forms
{
    public partial class InsertContactForm : Form
    {
        private Contact contact;
        private ListContactsForm parent;
        private ContactService contactService;
        private bool isLoading = true;

        public InsertContactForm(ListContactsForm parent, ContactService contactService)
        {
            InitializeComponent();
            contact = new Contact();
            this.parent = parent;
            this.contactService = contactService;
        }

        private void InsertContactForm_Load(object sender, EventArgs e)
        {
            isLoading = true;

            btn_confirm.BackColor = Color.FromArgb(124, 58, 237);
            btn_confirm.MouseEnter += (s, ev) => { btn_confirm.BackColor = Color.FromArgb(124, 58, 237); };
            btn_confirm.MouseLeave += (s, ev) => { btn_confirm.BackColor = Color.FromArgb(124, 58, 237); };
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn_confirm.Cursor = Cursors.Hand;

            btn_cancel.BackColor = Color.FromArgb(124, 58, 237);
            btn_cancel.MouseEnter += (s, ev) => { btn_cancel.BackColor = Color.FromArgb(124, 58, 237); };
            btn_cancel.MouseLeave += (s, ev) => { btn_cancel.BackColor = Color.FromArgb(124, 58, 237); };
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn_cancel.Cursor = Cursors.Hand;

            cb_masculino.Checked = contact.Gender == GenderEnum.Masculino;
            cb_feminino.Checked = contact.Gender == GenderEnum.Feminino;

            isLoading = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                await contactService.InsertContactAsync(contact);
                MessageBox.Show("Contato inserido com sucesso!");
                await parent.LoadContacts();
                this.Close();
                this.Dispose(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir contato: " + ex.Message);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            contact.Name = txt_name.Text;
        }

        private void cbox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox combo = (ComboBox)sender;


            contact.Gender = (GenderEnum)combo.SelectedItem;
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            contact.City = txt_city.Text;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void cb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            if (cb_masculino.Checked)
            {
                contact.Gender = GenderEnum.Masculino;
                cb_feminino.Checked = false;
            }
        }

        private void cb_feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            if (cb_feminino.Checked)
            {
                contact.Gender = GenderEnum.Feminino;
                cb_masculino.Checked = false;
            }
        }
    }
}
