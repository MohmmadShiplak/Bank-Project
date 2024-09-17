using Bank_Project.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class frmMain : Form
    {

       

        public frmMain()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

         
        }

        private void btnChangePassowrd_Click(object sender, EventArgs e)
        {
         




        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            frmDashbord frm1 = new frmDashbord();
            frm1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmListCurrency frm1 = new frmListCurrency();
            frm1.ShowDialog();




        }

        private void btnTrnsactions_Click(object sender, EventArgs e)
        {

            frmTransactions frm1 = new frmTransactions();
            frm1.ShowDialog();


        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmListUsers frm1 = new frmListUsers();
            frm1.ShowDialog();




        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmListClients frm1 = new frmListClients();
            frm1.ShowDialog();



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
