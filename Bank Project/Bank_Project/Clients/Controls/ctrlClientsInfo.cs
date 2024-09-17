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
    public partial class ctrlClientsInfo : UserControl
    {


        private int _ClientID = -1;

        private clsClients _Client;


        public int ClientID
        {
            get { return _ClientID; }
        }
        public void LoadClientsInfo(int ClientID)
        {

            _Client = clsClients.Find(ClientID);

            if(_Client==null)
            {

                MessageBox.Show("No Clients wiht ClientID " + _ClientID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            FillClientsInfo();
        }



        public ctrlClientsInfo()
        {
            InitializeComponent();
        }


       private void FillClientsInfo()
        {

            _ClientID = _Client.ClientID;
            lblClientName.Text = _Client.ClientName;
            lblAccountNumber.Text = _Client.AccountNumber;
            lblAccountBalance.Text = _Client.AccountBalance.ToString();
            lblPinCode.Text = _Client.PinCode;
            lblPhone.Text = _Client.Phone;
        }






        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
