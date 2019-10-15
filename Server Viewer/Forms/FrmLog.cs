using System;
using System.Windows.Forms;

namespace Server_Viewer.Forms
{
    public partial class FrmLog : Form
    {
       
        public FrmLog()
        {
            InitializeComponent();
        }
        private void FrmLog_Load(object sender, EventArgs e)
        {
            txtLog.Text = FrmMain.ErrorLog;
        }

        
    }
}
