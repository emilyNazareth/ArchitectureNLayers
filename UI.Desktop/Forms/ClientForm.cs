using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.ApplicationController;

namespace UI.Desktop.Forms
{
    public partial class ClientForm : Form
    {
        private ClientController client;
        public ClientForm()
        {
            InitializeComponent();
            client = new ClientController();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.GetClients("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.remove(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));            
            dataGridView1.DataSource = client.GetClients("");
            txtName.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {      
            client.add(txtName.Text, txtLastName.Text, txtAddress.Text, txtCity.Text, 
               txtEmail.Text, txtPhone.Text,txtJob.Text);
            dataGridView1.DataSource = client.GetClients("");
            txtName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtEmail.Clear();
            txtJob.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
