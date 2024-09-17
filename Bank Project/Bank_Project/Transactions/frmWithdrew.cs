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
    public partial class frmWithdrew : Form
    {

        clsClients _Client;

        public frmWithdrew()
        {
            InitializeComponent();
        }

        private void btnWithdrew_Click(object sender, EventArgs e)
        {

            if(decimal.TryParse(txtAmount.Text,out decimal Amount))
            {

                _Client.AccountBalance -= Amount;


                if(_Client.Save())
                {




                    MessageBox.Show("Withdrew  " + _Client.AccountBalance);
                      

                }

            }
            else
            {


                MessageBox.Show("Withdrew  Failed  (:",
                    "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            _Client = clsClients.Find(txtAccountNumber.Text);

            if (_Client != null)
            {


                txtAmount.Enabled = true;
                btnWithdrew.Enabled = true;



                MessageBox.Show("AccountNumber Found Successfully :-)", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("AccountNumber is not Found  ", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }














        }
    }
}
