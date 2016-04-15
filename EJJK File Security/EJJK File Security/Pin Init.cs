using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJJK_File_Security
{
    
    public partial class frmPinInit : Form
    {

        public frmPinInit()
        {
            InitializeComponent();
        }

        private void frmPinInit_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                this.Hide();
                    publicVariables.PasswordEntryInit.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
