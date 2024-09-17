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
    public partial class frmListUsers : Form
    {

        private DataTable _dtAllUsers;

        private clsUsers _User;


        public frmListUsers()
        {
            InitializeComponent();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {

            _dtAllUsers = clsUsers.GetAllUsers();
            dgvGetAllUsers.DataSource = _dtAllUsers;
            lblUsers.Text = dgvGetAllUsers.Rows.Count.ToString();

            ;



            lblUsers2.Text =_dtAllUsers.Rows.Count.ToString();



            if(dgvGetAllUsers.Rows.Count>0)
            {

                dgvGetAllUsers.Columns[0].HeaderText = "User ID";
                dgvGetAllUsers.Columns[0].Width = 120;

                dgvGetAllUsers.Columns[1].HeaderText = "User Name";
                dgvGetAllUsers.Columns[1].Width = 130;

                dgvGetAllUsers.Columns[2].HeaderText = "First Name";
                dgvGetAllUsers.Columns[2].Width = 130;

                dgvGetAllUsers.Columns[3].HeaderText = "Last Name";
                dgvGetAllUsers.Columns[3].Width = 130;

                dgvGetAllUsers.Columns[4].HeaderText = "Phone";
                dgvGetAllUsers.Columns[4].Width = 120;

                dgvGetAllUsers.Columns[5].HeaderText = "Email";
                dgvGetAllUsers.Columns[5].Width = 140;


                dgvGetAllUsers.Columns[6].HeaderText = "Password";
                dgvGetAllUsers.Columns[6].Width = 170;


            }

        }

        private void addClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddUpdateUsers frm1 = new frmAddUpdateUsers();
            frm1.ShowDialog();
           frmListUsers_Load(null, null);


        }

        private void updateCleintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID =(int) dgvGetAllUsers.CurrentRow.Cells[0].Value;

            frmAddUpdateUsers frm1 = new frmAddUpdateUsers(UserID);

            frm1.ShowDialog();
            frmListUsers_Load(null, null);

        }

        private void deleteClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure you want to delete this User", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;




            int UserID = (int)dgvGetAllUsers.CurrentRow.Cells[0].Value;


            if(clsUsers.DeleteUser(UserID))
            {

                MessageBox.Show("User Deleted Successfully :-)", "Success", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                frmListUsers_Load(null, null);


            }
            else
            {
                MessageBox.Show("User Could not Deleted ", "Failed"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showClientsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID =(int) dgvGetAllUsers.CurrentRow.Cells[0].Value;

            frmUsersInfo frm1 = new frmUsersInfo(UserID);
            frm1.ShowDialog();







        }
    }
}
