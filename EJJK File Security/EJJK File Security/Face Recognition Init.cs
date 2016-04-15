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
    public partial class frmFaceRecogInit : Form
    {

        public frmFaceRecogInit()
        {
            InitializeComponent();
        }
        
        private void frmFaceRecog_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
                publicVariables.SpeechRecogInit.Show();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
