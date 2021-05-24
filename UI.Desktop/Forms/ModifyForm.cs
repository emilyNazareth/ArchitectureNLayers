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
    public partial class ModifyForm : Form
    {
        private ClientController clientController;
        private ClientViewModel client;
        public ModifyForm()
        {
            InitializeComponent();
            clientController = new ClientController();
        }
        public ModifyForm(ClientViewModel clientModel)
        {
            InitializeComponent();
            clientController = new ClientController();
            client = clientModel;
            Set_data();

        }

        private void Set_data()
        {
            txtName.Text = client.Name;
            txtLastName.Text = client.LastName;
            txtAddress.Text = client.Address;
            txtCity.Text = client.City;
            txtEmail.Text = client.Email;
            txtJob.Text = client.Job;
            txtPhone.Text = client.Phone;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var changed = false;
            
            if (txtName.Text != "" && txtName.Text != client.Name)
            {
                client.Name = txtName.Text;
                changed = true;
            }
            if (txtLastName.Text != "" && txtLastName.Text != client.LastName)
                client.LastName = txtLastName.Text; changed = true;
            if (txtAddress.Text != "" && txtAddress.Text != client.Address)
                client.Address = txtAddress.Text; changed = true;
            if (txtCity.Text != "" && txtCity.Text != client.City)
                client.City = txtCity.Text; changed = true;
            if (txtEmail.Text != "" && txtEmail.Text != client.Email)
                client.Email = txtEmail.Text; changed = true;
            if (txtJob.Text != "" && txtJob.Text != client.Job)
                client.Job = txtJob.Text; changed = true;
            if (txtPhone.Text != "" && txtPhone.Text != client.Phone)
                client.Phone = txtPhone.Text; changed = true;
            if (!changed)
            {
                MessageBox.Show("Please make at least one change.");
            }
            else
            {
                clientController.edit(client);
                txtName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtCity.Clear();
                txtEmail.Clear();
                txtJob.Clear();
                txtPhone.Clear();
                this.Dispose();
            }
            
            
        }
    }
}
