using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EJJK_File_Security
{
    public partial class frmStartScreen : Form
    {
        //Form StartInit = new frmStartInit();
        //Form FaceRecogLogin = new frmFaceRecogLogin();
        //Form SpeechRecogLogin = new frmSpeechRecogLogin();
        //Form PinEntryLogin = new frmPinEntryLogin();
        //Form PasswordEntrylogin = new frmPasswordEntryLogin();
        public static publicVariables vars = new publicVariables();
        public frmStartScreen()
        {
            InitializeComponent();
        }

        private void frmStartScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            
          
                this.Hide();
                publicVariables.FaceRecogLogin.Show();
         
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            this.Hide();
            publicVariables.StartInit.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

           }
}
