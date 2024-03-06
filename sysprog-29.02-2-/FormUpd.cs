using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysprog_29._02_2_
{
    public partial class FormUpd : Form
    {

        DB db; 
        Contact contact;

        public FormUpd(Contact contact)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            db = new DB("Host=localhost;Username=postgres;Password=11111;Database=contact");
            this.contact = contact;

            nameUpd.Text = contact.name;
            numberUpd.Text = contact.number;

        }

        private void textBoxNumberUpdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdt_Click(object sender, EventArgs e)
        {
            string name = nameUpd.Text;
            string number = numberUpd.Text;

            db.updateContact(contact.id, name, number);

            Form1 form = new Form1();
            form.Show();
            this.Close();


        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            db.deleteContact(contact.id);

            Form1 form = new Form1();
            form.Show();
            Close();
        }
    }
}
