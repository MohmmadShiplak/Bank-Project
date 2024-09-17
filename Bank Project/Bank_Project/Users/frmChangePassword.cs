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

   





    public partial class frmChangePassword : Form
    {

        private int _UserID;

        private clsUsers _User;







        public frmChangePassword( )
        {
            InitializeComponent();

          

           
            
        }






   

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

            //_User = clsUsers.Find(_UserID);


            //if(_User==null)
            //{

            //    MessageBox.Show("No Users with UserID " + _UserID.ToString()
            //        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    this.Close();


            //    return;
            //}

         
           
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password can not be Blank ");


            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }



        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

if(txtConfirmPassword.Text.Trim()!=txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Passowrd Confirmation does not match New Password");

            }
else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {





        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
  





        }

        private void btnSave_Click_2(object sender, EventArgs e)
        {

            _User.Password = txtNewPassword.Text;


            if (_User.Save())
            {

                MessageBox.Show("Password Changed Successfully :-)"
                    , "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("An Error Occured , Password did not Change "
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }
    }
}
