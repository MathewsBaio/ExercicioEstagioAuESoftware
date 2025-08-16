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

        public InsertContactForm(ListContactsForm parent, ContactService contactService)
        {
            InitializeComponent();
            contact = new Contact();
            this.parent = parent;
            this.contactService = contactService;
        }

        private void InsertContactForm_Load(object sender, EventArgs e)
        {
            cbox_gender.DataSource = Enum.GetValues(typeof(GenderEnum));
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
                this.Close();
                parent.LoadContacts();
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
    }
}
