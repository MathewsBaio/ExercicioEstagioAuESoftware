using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExercicioEstagio.Models;
using ExercicioEstagio.Services;

namespace ExercicioEstagio.Forms
{
    
    public partial class EditContactForm : Form
    {
        private Contact contact;
        private ListContactsForm parent;
        private ContactService contactService;

        public EditContactForm(ListContactsForm parent, Contact contact, ContactService contactService)
        {
            InitializeComponent();
            this.parent = parent;
            this.contact = contact;
            this.contactService = contactService;
        }


        private void EditContactForm_Load(object sender, EventArgs e)
        {

            cbox_gender.DataSource = Enum.GetValues(typeof(GenderEnum));


            txt_name.Text = contact.Name;
            txt_city.Text = contact.City;
            cbox_gender.SelectedItem = contact.Gender;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
