using Bank_Business;
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
    public partial class frmDashbord : Form
    {

        public clsClients _Client;

        private DataTable _GetAllUsers;

        private DataTable _GetAllClients;

        private DataTable _GetAllCurrencies;


        public frmDashbord()
        {
            InitializeComponent();
        }

        private void frmDashbord_Load(object sender, EventArgs e)
        {

           _GetAllUsers = clsUsers.GetAllUsers();

            lblUsers.Text = _GetAllUsers.Rows.Count.ToString();


            _GetAllClients = clsClients.GetAllClients();


            lblClients.Text = _GetAllClients.Rows.Count.ToString();

            _GetAllCurrencies = clsCurrency.GetAllCurrencies();


            lblCurrency.Text = _GetAllCurrencies.Rows.Count.ToString();










        }
    }
}
