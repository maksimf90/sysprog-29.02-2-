using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace sysprog_29._02_2_
{
    public partial class Form1 : Form
    {
        DB db;

        public Form1()
        {
           InitializeComponent();
           StartPosition = FormStartPosition.CenterScreen;

            db = new DB("Host=localhost;Username=postgres;Password=11111;Database=contact");

            List<Contact> contacts = db.getContacts();

            for (int i = 0; i < contacts.Count; i++) 
            {
                dataGridView1.Rows.Add(contacts[i].id, contacts[i].name, contacts[i].number);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonUpdt_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void textBoxNameAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_Validated(object sender, EventArgs e)
        {
           
        }

        private void Form1_Validated(object sender, EventArgs e)
        {


        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            FormAdd FormAdd = new FormAdd();
            FormAdd.Show();
            this.Hide();
        }

        private void buttonUpdt_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSer_Click_1(object sender, EventArgs e)
        {
            string name = textBoxSer.Text;
            List<Contact> contacts = db.findContacts(name);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < contacts.Count; i++)
            {
                dataGridView1.Rows.Add(contacts[i].id, contacts[i].name, contacts[i].number);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string number = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Contact contact = new Contact(id, name, number);

            FormUpd form = new FormUpd(contact);
            form.Show();
            Hide();
        }
    }
}