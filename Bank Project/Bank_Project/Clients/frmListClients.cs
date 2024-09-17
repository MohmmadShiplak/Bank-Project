using Bank_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class frmListClients : Form
    {

        private DataTable _dtCleints;

        private clsClients _Client;



        public frmListClients()
        {
            InitializeComponent();
        }

        private void frmListClients_Load(object sender, EventArgs e)
        {

            _dtCleints = clsClients.GetAllClients();
            dgvClients.DataSource = _dtCleints;
            lblClients.Text = dgvClients.Rows.Count.ToString();


            if(dgvClients.Rows.Count>0)
            {

                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[0].Width = 130;


                dgvClients.Columns[1].HeaderText = "Client Name";
                dgvClients.Columns[1].Width = 130;

                dgvClients.Columns[2].HeaderText = "Account Number";
                dgvClients.Columns[2].Width = 140;

                dgvClients.Columns[3].HeaderText = "Account Balance";
                dgvClients.Columns[3].Width = 150;

                dgvClients.Columns[4].HeaderText = "Phone";
                dgvClients.Columns[4].Width = 140;

                dgvClients.Columns[5].HeaderText = "Pin Code";
                dgvClients.Columns[5].Width = 130;

            }

        }

        private void addNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddNewClients frm1 = new frmAddNewClients();
            frm1.ShowDialog();
            frmListClients_Load(null, null);
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ClientID = (int)dgvClients.CurrentRow.Cells[0].Value;

            frmAddNewClients frm1 = new frmAddNewClients(ClientID);
            frm1.ShowDialog();
            frmListClients_Load(null, null);

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int ClientID = (int)dgvClients.CurrentRow.Cells[0].Value;


            if(clsClients.DeleteClient(ClientID))
            {
                MessageBox.Show("Client Deleted Successfully :-)", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListClients_Load(null, null);

            }
            else
            {
                MessageBox.Show("Error : Client Failed ", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clientsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ClientID = (int)dgvClients.CurrentRow.Cells[0].Value;

            frmClientsInfo frm1 = new frmClientsInfo(ClientID);
            frm1.ShowDialog();

              




        }
    }
}
