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
    public partial class frmDeposit : Form
    {

        public clsClients _Client;






        public frmDeposit()
        {
            InitializeComponent();
        }

     

        private void btnSearch_Click(object sender, EventArgs e)
        {

            _Client = clsClients.Find(txtAccountNumber.Text);


            if(_Client!=null)
            {

                btnDeposit.Enabled = true;
                txtAmount.Enabled = true;


                MessageBox.Show("AccountNumber Found Successfully :-)"
                    , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {

                MessageBox.Show(" Error :AccountNumber is not Found  (-:"
                   , "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            if(decimal.TryParse(txtAmount.Text,out decimal Amount ))
            {

                _Client.AccountBalance += Amount;

                if(_Client.Save())
                {
                    MessageBox.Show(" New AccountBalance Added Sucessfully :-) :" + _Client.AccountBalance,"Success"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
             
            }
            else
            {
                MessageBox.Show("AccountBalance is not Found ", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}
