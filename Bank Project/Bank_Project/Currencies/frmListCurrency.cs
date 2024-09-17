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
    public partial class frmListCurrency : Form
    {

        private DataTable _dtCurrencies;






        public frmListCurrency()
        {
            InitializeComponent();
        }

        private void frmListCurrency_Load(object sender, EventArgs e)
        {

            _dtCurrencies = clsCurrency.GetAllCurrencies();
            dgvCurrencies.DataSource = _dtCurrencies;

        }

        private void addCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddUpdateCurrency frm1 = new frmAddUpdateCurrency();
            frm1.ShowDialog();
            frmListCurrency_Load(null, null);


        }

        private void updateCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int CurrencyID = (int)dgvCurrencies.CurrentRow.Cells[0].Value;


            frmAddUpdateCurrency frm1 = new frmAddUpdateCurrency(CurrencyID);
            frm1.ShowDialog();
            frmListCurrency_Load(null, null);


        }

        private void deleteCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int CurrencyID = (int)dgvCurrencies.CurrentRow.Cells[0].Value;


            if (clsCurrency.DeleteCurrency(CurrencyID))
            {
                MessageBox.Show("Currency Deleted Sucessfully :-)", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListCurrency_Load(null, null);

            }
            else
            {
                MessageBox.Show("Currency  is not Deleted  ", "Failed"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);



            }



        }
    }
}
