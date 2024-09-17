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
    public partial class frmClientsInfo : Form
    {

        private int _ClientID=-1;



        public frmClientsInfo(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;
        }

        private void frmClientsInfo_Load(object sender, EventArgs e)
        {
            ctrlClientsInfo1.LoadClientsInfo(_ClientID);
        }
    }
}
