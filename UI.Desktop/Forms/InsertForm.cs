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
    public partial class InsertForm : Form
    {
        private ClientController clientController;
        public InsertForm()
        {
            InitializeComponent();
            clientController = new ClientController();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" ||
                txtCity.Text == "" || txtEmail.Text == "" || txtJob.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Complete el formulario");
            }
            else
            {
                clientController.add(txtName.Text, txtLastName.Text, txtAddress.Text, txtCity.Text,
               txtEmail.Text, txtPhone.Text, txtJob.Text);
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
