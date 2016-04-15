using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace EJJK_File_Security
{
   public class publicVariables
    {
        
        public static Form StartInit = new frmStartInit();
        public static Form FaceRecogInit = new frmFaceRecogInit();
        public static Form SpeechRecogInit = new frmSpeechRecogInit();
        public static Form PinEntryInit = new frmPinInit();
        public static Form PasswordEntryInit = new frmPasswordEntryInit();
        public static Form FileSelector = new frmFileSelector();
        public static Form ControlPanel = new frmControlPanel();
        public static Form Settings = new frmSettings();

        public static Form FaceRecogLogin = new frmFaceRecogLogin();
        public static Form SpeechRecogLogin = new frmSpeechRecogLogin();
        public static Form PinEntryLogin = new frmPinEntryLogin();
        public static Form PasswordEntryLogin = new frmPasswordEntryLogin();
        
    }
}
