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
    public partial class frmUsersInfo : Form
    {

        private int _UserID = -1;

        public frmUsersInfo(int UserID)
           
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void frmUsersInfo_Load(object sender, EventArgs e)
        {
            ctrlUsersInfo1.LoadUsersInfo(_UserID);
        }
    }
}
