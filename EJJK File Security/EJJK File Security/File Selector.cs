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
using Microsoft.VisualBasic;

namespace EJJK_File_Security
{
    public partial class frmFileSelector : Form
    {
        //Form ControlPanel = new frmControlPanel();
        public frmFileSelector()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.Hide();
                publicVariables.ControlPanel.Show();
            
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            }
    
        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void frmFileSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

    }
 }

