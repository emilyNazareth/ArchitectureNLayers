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
        private InsertForm insertForm;
        private ModifyForm modifyForm;
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
            insertForm = new InsertForm();
            insertForm.ShowDialog();
            if (insertForm.IsDisposed)
            {
                dataGridView1.DataSource = client.GetClients("");
            }
            
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            ClientViewModel clientModel = (ClientViewModel)dataGridView1.CurrentRow.DataBoundItem;
            modifyForm = new ModifyForm(clientModel);
            modifyForm.ShowDialog();
            if (modifyForm.IsDisposed)
            {
                dataGridView1.DataSource = client.GetClients("");
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if(searchtxt.Text != "")
            {
                string searchValue = searchtxt.Text;
                int rowIndex = -1;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                        {
                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No solutions with that name.");
                }
            }
            else
            {
               // dataGridView1.DataSource = client.GetClients("");
            }
            
        }

    }
}
