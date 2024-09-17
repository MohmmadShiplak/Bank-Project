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
    public partial class frmTransfer : Form
    {

        clsClients Client1, Client2;

        public frmTransfer()
        {
            InitializeComponent();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {

            Client2 = clsClients.Find(txtAccountNumber2.Text);


            if (Client2 != null)
            {

                txtAmount.Enabled = true;
                btnTransform.Enabled = true;

                MessageBox.Show("AccountNumber 1 Found Successfully ", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("AcocountNumber 1 is not Found ", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

        private void btnTransform_Click(object sender, EventArgs e)
        {

            if(decimal.TryParse(txtAmount.Text,out decimal Amount))
            {

                Client1.AccountBalance -= Amount;
                Client2.AccountBalance += Amount;


                if(Client1.Save()&&Client2.Save())
                {

                    MessageBox.Show("AccountNumber 1 NewBalance " + Client1.AccountBalance + "\n" +
                         "AccountNumber 2 NewBalance " + Client2.AccountBalance);


                }

            }
            else
            {

                MessageBox.Show("Amount is not Found ", "Error "
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);


            }




        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {

            Client1 = clsClients.Find(txtAccountNumber1.Text);


            if(Client1!=null)
            {

                txtAccountNumber2.Enabled = true;
                btnSearch2.Enabled = true;

                MessageBox.Show("AccountNumber 1 Found Successfully ", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("AccountNumber 1 is not Found ", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
