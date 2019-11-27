using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server_Viewer.Forms
{
    public partial class FrmLog : Form
    {
        public string Value;
        public FrmLog()
        {
            InitializeComponent();
        }
        private void FrmLog_Load(object sender, EventArgs e)
        {
            txtLog.Text = Value;
        }
    }
}
