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
    public partial class frmSpeechRecogInit : Form
    {
        //Form PinEntryInit = new frmPinInit();
        public frmSpeechRecogInit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            publicVariables.PinEntryInit.Show();               
        }

        private void frmSpeechRecogInit_Load(object sender, EventArgs e)
        {
           
        }
    }
}
