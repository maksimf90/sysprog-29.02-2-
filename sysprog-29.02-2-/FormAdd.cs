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
    public partial class FormAdd : Form
    {
        DB db;

        public FormAdd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            db = new DB("Host=localhost;Username=postgres;Password=11111;Database=contact");



        }

        private void textBoxNameAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string name = nameAdd.Text;
            string number = numberAdd.Text;
            db.addContact(name, number);
            
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Close();
        }
    }
}
