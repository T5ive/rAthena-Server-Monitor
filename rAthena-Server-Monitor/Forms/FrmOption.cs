namespace rAthena_Server_Monitor;

public partial class FrmOption : Form
{
    public FrmOption()
    {
        InitializeComponent();
    }

    #region Load/Save

    private void FrmOption_Load(object sender, EventArgs e)
    {
        LoadSettings();
    }

    private void LoadSettings()
    {
        lbStatus.ForeColor = PublicClass.MySettings.Status;
        lbError.ForeColor = PublicClass.MySettings.Error;
        lbWarning.ForeColor = PublicClass.MySettings.Warning;
        lbSQL.ForeColor = PublicClass.MySettings.Sql;
        lbDebug.ForeColor = PublicClass.MySettings.Debug;
        lbInfo.ForeColor = PublicClass.MySettings.Info;
        lbNotice.ForeColor = PublicClass.MySettings.Notice;
        txtLogin.Text = PublicClass.MySettings.LoginExePath;
        txtChar.Text = PublicClass.MySettings.CharExePath;
        txtMap.Text = PublicClass.MySettings.MapExePath;
        txtWeb.Text = PublicClass.MySettings.WebExePath;
        chkWeb.Checked = PublicClass.MySettings.WebExe;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        SaveSettings();
    }

    private void SaveSettings()
    {
        try
        {
            if (!MyMessage.MsgOkCancel("Save Settings.\n\n" +
                                       "Click \"OK\" to confirm.\n\n" +
                                       "Click \"Cancel\" to cancel.")) return;
            PublicClass.MySettings.Status = lbStatus.ForeColor;
            PublicClass.MySettings.Error = lbError.ForeColor;
            PublicClass.MySettings.Warning = lbWarning.ForeColor;
            PublicClass.MySettings.Sql = lbSQL.ForeColor;
            PublicClass.MySettings.Debug = lbDebug.ForeColor;
            PublicClass.MySettings.Info = lbInfo.ForeColor;
            PublicClass.MySettings.Notice = lbNotice.ForeColor;

            PublicClass.MySettings.LoginExePath = txtLogin.Text;
            PublicClass.MySettings.CharExePath = txtChar.Text;
            PublicClass.MySettings.MapExePath = txtMap.Text;
            PublicClass.MySettings.WebExePath = txtWeb.Text;
            PublicClass.MySettings.WebExe = chkWeb.Checked;

            PublicClass.MySettings.Save();
            Close();
        }
        catch
        {
            //
        }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        try
        {
            if (!MyMessage.MsgOkCancel("Reset Settings.\n\n" +
                                       "Click \"OK\" to confirm.\n\n" +
                                       "Click \"Cancel\" to cancel.")) return;
            var defaultSettings = new AppSettings();
            PublicClass.MySettings.Status = defaultSettings.Status;
            PublicClass.MySettings.Error = defaultSettings.Error;
            PublicClass.MySettings.Warning = defaultSettings.Warning;
            PublicClass.MySettings.Sql = defaultSettings.Sql;
            PublicClass.MySettings.Debug = defaultSettings.Debug;
            PublicClass.MySettings.Info = defaultSettings.Info;
            PublicClass.MySettings.Notice = defaultSettings.Notice;
            PublicClass.MySettings.LoginExePath = defaultSettings.LoginExePath;
            PublicClass.MySettings.CharExePath = defaultSettings.CharExePath;
            PublicClass.MySettings.MapExePath = defaultSettings.MapExePath;
            PublicClass.MySettings.WebExePath = defaultSettings.WebExePath;
            PublicClass.MySettings.WebExe = defaultSettings.WebExe;
            LoadSettings();
        }
        catch
        {
            //
        }
    }

    #endregion Load/Save

    #region Events

    private void chkWeb_CheckedChanged(object sender, EventArgs e)
    {
        btnWeb.Enabled = chkWeb.Checked;
        txtWeb.Enabled = chkWeb.Checked;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var openFileDialog1 = new OpenFileDialog { Filter = @"login-server (*.exe)|*.exe|All files (*.*)|*.*" };
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var path = openFileDialog1.FileName;
            txtLogin.Text = path;
        }
    }

    private void btnChar_Click(object sender, EventArgs e)
    {
        var openFileDialog1 = new OpenFileDialog { Filter = @"char-server (*.exe)|*.exe|All files (*.*)|*.*" };
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var path = openFileDialog1.FileName;
            txtChar.Text = path;
        }
    }

    private void btnMap_Click(object sender, EventArgs e)
    {
        var openFileDialog1 = new OpenFileDialog { Filter = @"map-server (*.exe)|*.exe|All files (*.*)|*.*" };
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var path = openFileDialog1.FileName;
            txtMap.Text = path;
        }
    }

    private void btnWeb_Click(object sender, EventArgs e)
    {
        var openFileDialog1 = new OpenFileDialog { Filter = @"web-server (*.exe)|*.exe|All files (*.*)|*.*" };
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var path = openFileDialog1.FileName;
            txtWeb.Text = path;
        }
    }

    #endregion Events

    private void AllLabelClick(object sender, EventArgs e)
    {
        var lb = (Label)sender;
        var colorDlg = new ColorDialog();
        if (colorDlg.ShowDialog() == DialogResult.OK)
        {
            lb.ForeColor = colorDlg.Color;
        }
        colorDlg.Dispose();
    }
}