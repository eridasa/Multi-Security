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
    public partial class frmSpeechRecogLogin : Form
    {
        //Form PinEntryLogin = new frmPinEntryLogin();
        public frmSpeechRecogLogin()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            publicVariables.PinEntryLogin.Show();
        }
    }
}
