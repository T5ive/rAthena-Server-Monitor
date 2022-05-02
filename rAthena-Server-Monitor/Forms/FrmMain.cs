namespace rAthena_Server_Monitor;

public partial class FrmMain : Form
{
    #region Variable

    private static bool _status;
    private static bool _trayMsg;

    private static int _errorAll, _errorChar, _errorLogin, _errorMap, _warning, _sql, _debug, _online;

    public int ErrorAll
    {
        get => _errorAll;
        set
        {
            _errorAll = value;
            Invoke(delegate
            {
                errorToolStripMenuItem.Text = "Error: " + value;
                errorToolStripMenuItem1.Text = "Error: " + value;
                allToolStripMenuItem.Text = "All: " + value;
                all0ToolStripMenuItem.Text = "All: " + value;
            });
        }
    }

    public int ErrorChar
    {
        get => _errorChar;
        set
        {
            _errorChar = value;
            Invoke(delegate
            {
                charToolStripMenuItem.Text = "Char: " + value;
                char0ToolStripMenuItem.Text = "Char: " + value;
            });
        }
    }

    public int ErrorLogin
    {
        get => _errorLogin;
        set
        {
            _errorLogin = value;
            Invoke(delegate
            {
                loginToolStripMenuItem.Text = "Login: " + value;
                login0ToolStripMenuItem.Text = "Login: " + value;
            });
        }
    }

    public int ErrorMap
    {
        get => _errorMap;
        set
        {
            _errorMap = value;
            Invoke(delegate
            {
                mapToolStripMenuItem.Text = "Map: " + value;
                map0ToolStripMenuItem.Text = "Map: " + value;
            });
        }
    }

    public int Warning
    {
        get => _warning;
        set
        {
            _warning = value;
            Invoke(delegate
            {
                warningToolStripMenuItem.Text = "Warning: " + value;
                warningToolStripMenuItem1.Text = "Warning: " + value;
            });
        }
    }

    public int Sql
    {
        get => _sql;
        set
        {
            _sql = value;
            Invoke(delegate
            {
                sQLToolStripMenuItem.Text = "Sql: " + value;
                sQLToolStripMenuItem1.Text = "Sql: " + value;
            });
        }
    }

    public int IDebug
    {
        get => _debug;
        set
        {
            _debug = value;
            Invoke(delegate
            {
                debugToolStripMenuItem.Text = "Debug: " + value;
                debugToolStripMenuItem1.Text = "Debug: " + value;
            });
        }
    }

    public int Online
    {
        get => _online;
        set
        {
            _online = value;
            Invoke(delegate
            {
                onlineToolStripMenuItem.Text = "Online: " + value;
                onlineToolStripMenuItem1.Text = "Online: " + value;
            });
        }
    }

    #endregion Variable

    public FrmMain()
    {
        InitializeComponent();
    }

    #region Load/Save

    private void FrmMain_Load(object sender, EventArgs e)
    {
        LoadSettings();
    }

    private void LoadSettings()
    {
        LoadLocation();
    }

    private void LoadLocation()
    {
        switch (Settings.Default.windowState)
        {
            case (int)FormWindowState.Maximized:
                {
                    WindowState = FormWindowState.Maximized;
                    Location = Settings.Default.Location;
                    break;
                }
            case (int)FormWindowState.Minimized:
                {
                    WindowState = FormWindowState.Minimized;
                    Location = Settings.Default.Location;
                    break;
                }
            default:
                {
                    if (Settings.Default.Location == new Point(0, 0))
                    {
                        CenterToScreen();
                        return;
                    }
                    break;
                }
        }
        Size = new Size(Settings.Default.sizeWidth, Settings.Default.sizeHeight);
        Location = Settings.Default.Location;
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        CloseLocation();
    }

    private void CloseLocation()
    {
        Size size;
        switch (WindowState)
        {
            case FormWindowState.Maximized:
                Settings.Default.Location = RestoreBounds.Location;
                size = RestoreBounds.Size;
                break;

            case FormWindowState.Minimized:
            case FormWindowState.Normal:
                Settings.Default.Location = Location;
                size = Size;
                break;

            default:
                Settings.Default.Location = RestoreBounds.Location;
                size = RestoreBounds.Size;
                break;
        }
        Settings.Default.sizeWidth = size.Width;
        Settings.Default.sizeHeight = size.Height;
        Settings.Default.windowState = (int)WindowState;
        Settings.Default.Save();
    }

    #endregion Load/Save

    #region Menu

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void optionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var frmOption = new FrmOption();
        frmOption.ShowDialog();
        frmOption.Dispose();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MyMessage.MsgShowInfo($"rAthena Server Monitor Version {Utility.CurrentVersion()}\n\n" +

            "Powered by T5ive\n" +
            "Github: https://github.com/T5ive/rAthena-Server-Monitor\n\n" +

            "Base on: rAthena Server Monitor - JefteCosta\n\n" +

            "Note: Load status is not displayed. Makes it load as fast as the original");
    }

    #endregion Menu

    #region Tray

    private void FrmMain_Resize(object sender, EventArgs e)
    {
        if (WindowState != FormWindowState.Minimized) return;
        notifyIcon1.Visible = true;
        if (!_trayMsg)
        {
            notifyIcon1.BalloonTipTitle = @"rAthena Server Monitor";
            notifyIcon1.BalloonTipText = @"Minimized to tray.";
            _trayMsg = true;
            notifyIcon1.ShowBalloonTip(250);
        }
        Hide();
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        RestoreApp();
    }

    private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RestoreApp();
    }

    private void RestoreApp()
    {
        Show();
        WindowState = FormWindowState.Normal;
        notifyIcon1.Visible = false;
    }

    #endregion Tray

    private void AllLogs(object sender, EventArgs e)
    {
        var type = MyEnum.LogType.ErrorAll;
        var obj = (ToolStripMenuItem)sender;
        var name = obj.Name;
        if (name.Starts("All"))
        {
            type = MyEnum.LogType.ErrorAll;
        }
        if (name.Starts("Char"))
        {
            type = MyEnum.LogType.ErrorChar;
        }
        if (name.Starts("Login"))
        {
            type = MyEnum.LogType.ErrorLogin;
        }
        if (name.Starts("Map"))
        {
            type = MyEnum.LogType.ErrorMap;
        }
        if (name.Starts("Warning"))
        {
            type = MyEnum.LogType.Warning;
        }
        if (name.Starts("SQL"))
        {
            type = MyEnum.LogType.SQL;
        }
        if (name.Starts("Debug"))
        {
            type = MyEnum.LogType.Debug;
        }
        PublicClass.LogType = type;
        Program.FrmLog.Show();
        Program.FrmLog.UpdateValue();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        SetUpServer();
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabMain.SelectedIndex == 0)
        {
            txtChar.Refresh();
        }
        if (tabMain.SelectedIndex == 1)
        {
            txtLogin.Refresh();
        }
        if (tabMain.SelectedIndex == 2)
        {
            txtMap.Refresh();
        }
        if (tabMain.SelectedIndex == 3)
        {
            txtWeb.Refresh();
        }
    }

    private static bool CheckServerPath()
    {
        if (!File.Exists(PublicClass.MySettings.LoginExePath))
        {
            MyMessage.MsgShowError($"File \"login -server.exe\" at \"{PublicClass.MySettings.LoginExePath}\" is missing");
            return false;
        }
        if (!File.Exists(PublicClass.MySettings.CharExePath))
        {
            MyMessage.MsgShowError($"File \"char-server.exe\" at \"{PublicClass.MySettings.CharExePath}\" is missing");
            return false;
        }
        if (!File.Exists(PublicClass.MySettings.MapExePath))
        {
            MyMessage.MsgShowError($"File \"map-server.exe\" at \"{PublicClass.MySettings.MapExePath}\" is missing");
            return false;
        }

        if (PublicClass.MySettings.WebExe && !File.Exists(PublicClass.MySettings.WebExePath))
        {
            MyMessage.MsgShowError($"File \"web-server.exe\" at \"{PublicClass.MySettings.WebExePath}\" is missing");
            return false;
        }
        return true;
    }

    #region Run

    public void SetUpServer()
    {
        if (!CheckServerPath()) return;
        if (!_status)
        {
            SetupServer();
            return;
        }
        ShutDownServer();
    }

    private void SetupServer()
    {
        try
        {
            _status = true;
            btnStart.Text = "Stop";
            btnStart.Enabled = false;
            ClearTemp();
            RunServerAsync().ConfigureAwait(true);
            btnStart.Enabled = true;
        }
        catch (Exception err)
        {
            MyMessage.MsgShowError(err.Message + "\n" + err.StackTrace);
            btnStart.Enabled = true;
        }
    }

    private static async Task RunServerAsync()
    {
        var loginServer = PublicClass.ProcessHelper.RunWithRedirect(PublicClass.MySettings.LoginExePath);
        var charServer = PublicClass.ProcessHelper.RunWithRedirect(PublicClass.MySettings.CharExePath);
        var mapServer = PublicClass.ProcessHelper.RunWithRedirect(PublicClass.MySettings.MapExePath);

        if (PublicClass.MySettings.WebExe)
        {
            var webService = PublicClass.ProcessHelper.RunWithRedirect(PublicClass.MySettings.WebExePath);
            await webService.ConfigureAwait(false);
        }

        await loginServer.ConfigureAwait(false);
        await charServer.ConfigureAwait(false);
        await mapServer.ConfigureAwait(false);
    }

    #endregion Run

    private void All_TextChanged(object sender, EventArgs e)
    {
        var obj = (RichTextBox)sender;
        obj.ScrollToCaret();
    }

    private void ShutDownServer()
    {
        _status = false;
        btnStart.Text = "Start";
        ClearTemp(false);
    }

    private void ClearTemp(bool clearLogs = true)
    {
        try
        {
            ProcessHelper.KillProcess(PublicClass.MySettings.LoginExePath);
            ProcessHelper.KillProcess(PublicClass.MySettings.CharExePath);
            ProcessHelper.KillProcess(PublicClass.MySettings.MapExePath);
            if (PublicClass.MySettings.WebExe)
                ProcessHelper.KillProcess(PublicClass.MySettings.WebExePath);
        }
        catch
        {
            //
        }

        if (!clearLogs) return;

        txtLogin.Clear();
        txtChar.Clear();
        txtMap.Clear();
        txtWeb.Clear();

        _errorAll = 0;
        _errorChar = 0;
        _errorLogin = 0;
        _errorMap = 0;

        _warning = 0;
        _sql = 0;
        _debug = 0;
        _online = 0;

        PublicClass.LogErrorAll = string.Empty;
        PublicClass.LogErrorChar = string.Empty;
        PublicClass.LogErrorLogin = string.Empty;
        PublicClass.LogErrorMap = string.Empty;
        PublicClass.LogWarning = string.Empty;
        PublicClass.LogSql = string.Empty;
        PublicClass.LogDebug = string.Empty;

        errorToolStripMenuItem.Text = @"Error: " + _errorAll;
        charToolStripMenuItem.Text = @"Char: " + _errorChar;
        loginToolStripMenuItem.Text = @"Login: " + _errorLogin;
        mapToolStripMenuItem.Text = @"Map: " + _errorMap;
        allToolStripMenuItem.Text = @"All: " + _errorAll;

        warningToolStripMenuItem.Text = @"Warning: " + _warning;
        sQLToolStripMenuItem.Text = @"SQL: " + _sql;
        debugToolStripMenuItem.Text = @"Debug: " + _debug;

        onlineToolStripMenuItem.Text = "Online: " + _online;
    }
}