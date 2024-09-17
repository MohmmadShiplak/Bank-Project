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
    public partial class ctrlUsersInfo : UserControl
    {













        private int _UserID = -1;

        private clsUsers _User;

        public int UserID
        {
            get { return _UserID; }
        }

        public ctrlUsersInfo()
        {
            InitializeComponent();
        }
        public void LoadUsersInfo(int UserID)
        {

            _User = clsUsers.Find(UserID);

            if(_User==null)
            {

                MessageBox.Show("No Users with UserID " + UserID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FillUsersInfo();
        }








        private void FillUsersInfo()
        {

         //   _UserID = _User.UserID;
            lblUserID.Text = _User.UserID.ToString();
            lblFirstName.Text = _User.FirstName;
            lblLastName.Text = _User.LastName;
            lblEmail.Text = _User.Email;
            lblPhone.Text = _User.Phone;
            lblUserName.Text = _User.UserName;
            lblPassword.Text = _User.Password;


        }







    }
}
