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
    public partial class frmAddUpdateUsers : Form
    {

        public enum enMode { AddNew=0,UpdateNew=1 };

        public enMode _Mode = enMode.AddNew;



        public int _UserID= -1;

        public clsUsers _User;


        public frmAddUpdateUsers()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUsers(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            _Mode = enMode.UpdateNew;
        }

      private void _LoadData()
        {

if(_Mode==enMode.AddNew)
            {


                _User = new clsUsers();

                return;
            }
else
            {
                //
            }


            _User = clsUsers.Find(_UserID);


            if(_User==null)
            {


                MessageBox.Show("There is No Users with UserID" + _UserID, "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

               // this.Close();

                return;
            }



            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtFirstName.Text = _User.FirstName;
            txtLastName.Text = _User.LastName;
            txtPhone.Text = _User.Phone;
            txtEmail.Text = _User.Email;
            txtPassword.Text = _User.Password;

        }
        private void _ResetDefualtValues()
        {

        
            txtUserName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";



        }





        private void btnSave_Click(object sender, EventArgs e)
        {


            _User.UserName = txtUserName.Text;
            _User.FirstName = txtFirstName.Text;
            _User.LastName = txtLastName.Text;
            _User.Phone = txtPhone.Text;
            _User.Email = txtEmail.Text;
            _User.Password = txtPassword.Text;


            if(_User.Save())
            {

                lblUserID.Text = _User.UserID.ToString();


                MessageBox.Show("Data Saved Successfully :-)", "Saved"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Data  is not Saved  (:-", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }









        }

        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
           //_ResetDefualtValues();

           // if(_Mode==enMode.UpdateNew)
            _LoadData();
        }
    }
}
