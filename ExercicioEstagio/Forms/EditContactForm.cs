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

namespace ExercicioEstagio.Forms
{
    
    public partial class EditContactForm : Form
    {
        private Contact contact;

        public EditContactForm(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
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
