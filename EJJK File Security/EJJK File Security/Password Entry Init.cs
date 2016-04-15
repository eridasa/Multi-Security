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
    public partial class frmPasswordEntryInit : Form
    {

        //Form FileSelector = new frmFileSelector();
        public frmPasswordEntryInit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            publicVariables.FileSelector.Show();
        }

        private void frmPasswordEntryInit_Load(object sender, EventArgs e)
        {
            
        }
    }
}
