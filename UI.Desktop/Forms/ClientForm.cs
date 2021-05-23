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
using UI.Desktop.ViewModel;

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

        private void btnModify_Click(object sender, EventArgs e)
        {
            //btnInsert.Dispose();
            ClientViewModel clientModel = (ClientViewModel)dataGridView1.CurrentRow.DataBoundItem;
            if(txtName.Text != "")
                clientModel.Name = txtName.Text;
            if(txtLastName.Text != "")
                clientModel.LastName = txtLastName.Text;
            if (txtAddress.Text != "")
                clientModel.Address = txtAddress.Text;
            if (txtCity.Text != "")
                clientModel.City = txtCity.Text;
            if (txtEmail.Text != "")
                clientModel.Email = txtEmail.Text;
            if (txtJob.Text != "")
                clientModel.Job = txtJob.Text;
            if (txtPhone.Text != "")
                clientModel.Phone = txtPhone.Text;

            client.edit(clientModel);

            dataGridView1.DataSource = client.GetClients("");
            txtName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtEmail.Clear();
            txtJob.Clear();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchValue = searchtxt.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + searchtxt.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
