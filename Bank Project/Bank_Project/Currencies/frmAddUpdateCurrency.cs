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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_Project
{
    public partial class frmAddUpdateCurrency : Form
    {

        private enum enMode { AddNew = 0, UpdateNew = 1 };
        private enMode _Mode = enMode.AddNew;


        int _CurrencyID = -1;

        clsCurrency _Currency;




        public frmAddUpdateCurrency()
        {
            InitializeComponent();


            _Mode = enMode.AddNew;
        }

        public frmAddUpdateCurrency(int CurrencyID )
        {
            InitializeComponent();

            _CurrencyID = CurrencyID;

            _Mode = enMode.UpdateNew;
        }


        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ResetDefualtValues()
        {

            FillCountriesInComboBox();


            if (_Mode == enMode.AddNew)
            {
                _Currency = new clsCurrency();

                return;
            }
            else
            {
                //this is Going to Implement
            }








        }







        private void LoadData()
        {

        






            _Currency = clsCurrency.Find(_CurrencyID);

            if (_Currency==null)
            {

                MessageBox.Show("No Currencies with CurrencyID " + _CurrencyID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }


            lblCurrecnyID.Text = _CurrencyID.ToString();
            txtCode.Text = _Currency.Code;
            txtName.Text = _Currency.Name;
            txtRate.Text = _Currency.Rate.ToString();
            cbCountry.SelectedIndex = cbCountry.FindString(_Currency.CountryInfo.CountryName);

        }










      private   void FillCountriesInComboBox()
        {

            DataTable dtCountry = clsCountry.GetAllCountries();


            foreach(DataRow  Row in dtCountry.Rows)
            {
                cbCountry.Items.Add(Row["CountryName"]);
            }


        }

        private void frmAddUpdateCurrency_Load(object sender, EventArgs e)
        {



            //if (_Mode == enMode.UpdateNew)

            ResetDefualtValues();


            if(_Mode==enMode.UpdateNew)
            LoadData();


           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        int CountryID=clsCountry.Find(cbCountry.Text).ID;



            _Currency.CountryID = CountryID;
            _Currency.Code = txtCode.Text;
            _Currency.Name = txtName.Text;
            _Currency.Rate = Convert.ToDecimal(txtRate.Text);


            if(_Currency.Save())
            {

                lblCurrecnyID.Text = _Currency.CurrencyID.ToString();

                _Mode = enMode.UpdateNew;

                MessageBox.Show("Data Saved Successfully :-)", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Data is not  Saved  (:-", "Failed"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }
    }
}
