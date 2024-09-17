using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project.Transactions
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer frm1 = new frmTransfer();
            frm1.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit frm1 = new frmDeposit();
                frm1.ShowDialog();
        }

        private void btnWithdrew_Click(object sender, EventArgs e)
        {
            frmWithdrew frm1 = new frmWithdrew();
            frm1.ShowDialog();
              

        }
    }
}
