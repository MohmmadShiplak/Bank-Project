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
    public partial class frmAddNewClients : Form
    {

        public enum enMode { AddNew = 0, UpdateNew = 1 };

        public enMode _Mode = enMode.AddNew;


        public int _ClientID = -1;

        clsClients _Client;



        public frmAddNewClients()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddNewClients(int ClientID)
        {


            InitializeComponent();

            _ClientID = ClientID;

            _Mode = enMode.UpdateNew;
        }

        private void LoadData()
        {
         



            if (_Mode == enMode.AddNew)
            {

                _Client = new clsClients();

                return;
            }
            else
            {
                //this will Execute 
            }


            _Client = clsClients.Find(_ClientID);


            if (_Client == null)
            {

                MessageBox.Show("Error : There is no Clients with ClientID " + _ClientID.ToString(), "Error "
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            lblClientID.Text = _ClientID.ToString();
            txtClientName.Text = _Client.ClientName;
            txtAccountNumber.Text = _Client.AccountNumber;
            txtAccountBalance.Text = _Client.AccountBalance.ToString();
            txtPhone.Text = _Client.Phone;
            txtPinCode.Text = _Client.PinCode;


            if (_Client.ImagePath != "")
            {
                pbClientImage.ImageLocation = _Client.ImagePath;
            }




        }













        private void txtAccountBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            _Client.ClientName = txtClientName.Text;
            _Client.AccountNumber = txtAccountNumber.Text;
            _Client.AccountBalance = Convert.ToDecimal(txtAccountBalance.Text);
            _Client.Phone = txtPhone.Text;
            _Client.PinCode = txtPinCode.Text;

            if (pbClientImage.ImageLocation != null)
                _Client.ImagePath = pbClientImage.ImageLocation;
            else
                _Client.ImagePath = "";





            if (_Client.Save())
            {


                lblClientID.Text = _Client.ClientID.ToString();


                MessageBox.Show("Data Saved ");

            }
            else
            {
                MessageBox.Show("Data is not Saved ");
            }




        }

        private void frmAddNewClients_Load(object sender, EventArgs e)
        {

           

         //   LoadData();
        }

        private void llsetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbClientImage.Load(selectedFilePath);

            }
        }
    }
}

    
