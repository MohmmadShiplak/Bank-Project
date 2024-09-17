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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            clsUsers User = clsUsers.Find(txtUserName.Text, txtPassword.Text);

         //  txtPassword.Text = clsGlobal.DbConfig.encodePassword(txtPassword.Text);

         ////   User.Password = clsGlobal.DbConfig.encodePassword(txtPassword.Text) + txtPassword.Text;


            if(User!=null)
            {

                MessageBox.Show("Login Sucessfully ", "Sucess"
                   , MessageBoxButtons.OK, MessageBoxIcon.Information);



                this.Hide();
                frmMain frm1 = new frmMain();
                frm1.ShowDialog();






            }
            else
            {
                MessageBox.Show("UserName Or Password are Wrong", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


         


        }

        private void llForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword frm1 = new frmChangePassword();
            frm1.ShowDialog();
        }
    }
}
