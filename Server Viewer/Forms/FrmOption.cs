using System;
using System.Windows.Forms;

namespace Server_Viewer.Forms
{
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }
        private void FrmOption_Load(object sender, EventArgs e)
        {
            lbStatus.ForeColor = Handler.Status;
            lbDebug.ForeColor = Handler.Debug;
            lbError.ForeColor = Handler.Error;
            lbInfo.ForeColor = Handler.Info;
            lbNotice.ForeColor = Handler.Notice;
            lbSql.ForeColor = Handler.Sql;
            lbWarning.ForeColor = Handler.Warning;

            txtLoginPath.Text = Handler.LoginExePath;
            txtCharPath.Text = Handler.CharExePath;
            txtMapPath.Text = Handler.CharExePath;

            if (Handler.ColorMode)
                cbColorOnOff.Checked = true;

            if (Handler.ColorOldRev)
                cbOldRev.Checked = true;
        }

        #region Button Control

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Handler.SaveOpt();
            Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog { Filter = @"login-server (*.exe)|*.exe|All files (*.*)|*.*" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                Handler.LoginExePath = path;
                txtLoginPath.Text = path;
            }
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog { Filter = @"char-server (*.exe)|*.exe|All files (*.*)|*.*" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                Handler.CharExePath = path;
                txtCharPath.Text = path;
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog { Filter = @"map-server (*.exe)|*.exe|All files (*.*)|*.*" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                Handler.MapExePath = path;
                txtMapPath.Text = path;
            }
        }

        #endregion
        
        #region Label&Check Box

        private void cbColorOnOff_CheckedChanged(object sender, EventArgs e)
        {
            Handler.ColorMode = cbColorOnOff.Checked;
        }

        private void cbOldRev_CheckedChanged(object sender, EventArgs e)
        {
            Handler.ColorOldRev = cbOldRev.Checked;
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lbStatus.ForeColor = colorDlg.Color;
            Handler.Status = colorDlg.Color;
            colorDlg.Dispose();
        }
        private void lbWarning_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lbWarning.ForeColor = colorDlg.Color;
            Handler.Warning = colorDlg.Color;
            colorDlg.Dispose();
        }
        private void lbError_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lbError.ForeColor = colorDlg.Color;
            Handler.Error = colorDlg.Color;
            colorDlg.Dispose();
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lbInfo.ForeColor = colorDlg.Color;
            Handler.Info = colorDlg.Color;
            colorDlg.Dispose();
        }

        private void lbNotice_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lbNotice.ForeColor = colorDlg.Color;
            Handler.Notice = colorDlg.Color;
            colorDlg.Dispose();
        }

        private void lbSql_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lbSql.ForeColor = colorDlg.Color;
            Handler.Sql = colorDlg.Color;
            colorDlg.Dispose();
        }

        private void lbDebug_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lbDebug.ForeColor = colorDlg.Color;
            Handler.Debug = colorDlg.Color;
            colorDlg.Dispose();
        }
        #endregion

    }
}
