using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Server_Viewer.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Variable

        public static string ErrorLog;
        public static string WarningLog;
        public static string SqlLog;
        public static string DebugLog;

        private static bool _onOff;
        private static bool _trayMsg;

        private static int _debugMsg;
        private static int _sqlMsg;
        private static int _errorMsg;
        private static int _playerMsg;
        private static int _warnMsg;
        private Point _p;

        #endregion Variable

        #region Form Control

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\SM_config.ini"))
            {
                Handler.IniCreate();
            }
            else
            {
                Handler.IniRead();
            }

            lbDebug.Text = @"Debug: " + _debugMsg;
            lbSql.Text = @"SQL: " + _sqlMsg;
            lbError.Text = @"Error: " + _errorMsg;
            lbUsers.Text = "" + _playerMsg;
            lbWarning.Text = @"Warning: " + _warnMsg;

            lbVersion.Text = $@"v.{Application.ProductVersion}";
            lbVersion.Focus();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            KillProcess(ProcNameCfg(Handler.LoginExePath));
            KillProcess(ProcNameCfg(Handler.CharExePath));
            KillProcess(ProcNameCfg(Handler.MapExePath));
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            _p.X = e.X;
            _p.Y = e.Y;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _p.X;
                Top += e.Y - _p.Y;
            }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbMinimize_Click(object sender, EventArgs e)
        {
            tray.Visible = true;
            if (!_trayMsg)
            {
                tray.BalloonTipTitle = @"Server Monitor";
                tray.BalloonTipText = @"Minimized to tray.";
                _trayMsg = true;
                tray.ShowBalloonTip(250);
            }
            WindowState = FormWindowState.Minimized;
            Hide();
        }

        #endregion Form Control

        #region Button

        private void BtnRunServer(object sender, EventArgs e)
        {
            RunServer();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Option();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            var frmLog = new FrmLog { Text = @"Error Log", Value = ErrorLog };
            frmLog.ShowDialog();
            frmLog.Dispose();
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            var frmLog = new FrmLog { Text = @"Warning Log", Value = WarningLog };
            frmLog.ShowDialog();
            frmLog.Dispose();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            var frmLog = new FrmLog { Text = @"SQL Log", Value = SqlLog };
            frmLog.ShowDialog();
            frmLog.Dispose();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            var frmLog = new FrmLog { Text = @"Debug Log", Value = DebugLog };
            frmLog.ShowDialog();
            frmLog.Dispose();
        }

        #endregion Button

        #region Function Control

        private void RunServer()
        {
            if (!File.Exists(Handler.LoginExePath))
            {
                MessageBox.Show(@"File ""login-server.exe"" is missing!!", @"Server Monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!File.Exists(Handler.CharExePath))
            {
                MessageBox.Show(@"File ""char-server.exe"" is missing!!", @"Server Monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!File.Exists(Handler.MapExePath))
            {
                MessageBox.Show(@"File ""map-server.exe"" is missing!!", @"Server Monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!_onOff)
            {
                _onOff = true;

                try
                {
                    try
                    {
                        KillProcess(ProcNameCfg(Handler.LoginExePath));
                        KillProcess(ProcNameCfg(Handler.CharExePath));
                        KillProcess(ProcNameCfg(Handler.MapExePath));
                    }
                    catch
                    {
                        //
                    }
                    LoginLog.Clear();
                    CharLog.Clear();
                    MapLog.Clear();

                    serverWorker.RunWorkerAsync();

                    btnStart.Text = @"Stop";
                    tcControl.Text = @"Stop";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n" + err.StackTrace);
                }
            }
            else
            {
                _onOff = false;
                btnStart.Text = @"Start";
                tcControl.Text = @"Start";
                _debugMsg = 0;
                _sqlMsg = 0;
                _errorMsg = 0;
                _warnMsg = 0;
                _playerMsg = 0;
                ErrorLog = string.Empty;
                WarningLog = string.Empty;
                SqlLog = string.Empty;
                DebugLog = string.Empty;

                lbDebug.Text = @"Debug: " + _debugMsg;
                lbSql.Text = @"SQL: " + _sqlMsg;
                lbError.Text = @"Error: " + _errorMsg;
                lbUsers.Text = "" + _playerMsg;
                lbWarning.Text = @"Warning: " + _warnMsg;
                KillProcess(ProcNameCfg(Handler.LoginExePath));
                KillProcess(ProcNameCfg(Handler.CharExePath));
                KillProcess(ProcNameCfg(Handler.MapExePath));
            }
        }

        private void Option()
        {
            var frmOpt = new FrmOption();
            frmOpt.ShowDialog();
            frmOpt.Dispose();
        }

        #endregion Function Control

        #region Log Control

        private void LoginLog_TextChanged(object sender, EventArgs e)
        {
            LoginLog.ScrollToCaret();
        }

        private void CharLog_TextChanged(object sender, EventArgs e)
        {
            CharLog.ScrollToCaret();
        }

        private void MapLog_TextChanged(object sender, EventArgs e)
        {
            MapLog.ScrollToCaret();
        }

        #endregion Log Control

        #region Update Context Menu Values

        private void lbUsers_TextChanged(object sender, EventArgs e)
        {
            tcPlayer.Text = @"Player: " + lbUsers.Text;
        }

        private void lbWarnings_TextChanged(object sender, EventArgs e)
        {
            tcWarning.Text = lbWarning.Text;
        }

        private void lbError_TextChanged(object sender, EventArgs e)
        {
            tcError.Text = lbError.Text;
        }

        private void lbSql_TextChanged(object sender, EventArgs e)
        {
            tcSql.Text = lbSql.Text;
        }

        private void lbDebug_TextChanged(object sender, EventArgs e)
        {
            tcDebug.Text = lbDebug.Text;
        }

        #endregion Update Context Menu Values

        #region Tray&Context Menu Control

        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        private void tcRestore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        private void tcControl_Click(object sender, EventArgs e)
        {
            RunServer();
        }

        private void tcExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tcAbout_Click(object sender, EventArgs e)
        {
            var frmAbt = new FrmAbout();
            frmAbt.ShowDialog();
            frmAbt.Dispose();
        }

        private void tc_options_Click(object sender, EventArgs e)
        {
            Option();
        }

        #endregion Tray&Context Menu Control

        #region Server Manager

        private void serverWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                RunWithRedirect(Handler.LoginExePath);
                RunWithRedirect(Handler.CharExePath);
                RunWithRedirect(Handler.MapExePath);
            }
            catch
            {
                serverWorker.CancelAsync();
            }
        }

        public void KillProcess(string processName)
        {
            foreach (var p in Process.GetProcesses())
            {
                try
                {
                    if (p.ProcessName.IndexOf(processName, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        p.Kill();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
            }
        }

        public string ProcNameCfg(string cfgName)
        {
            var ret = cfgName.Substring(cfgName.LastIndexOf("\\", StringComparison.Ordinal) + 1, (cfgName.LastIndexOf(".", StringComparison.Ordinal) - 1 - cfgName.LastIndexOf("\\", StringComparison.Ordinal)));
            return ret;
        }

        public void RunWithRedirect(string cmdPath)
        {
            try
            {
                var proc = new Process
                {
                    StartInfo =
                    {
                        FileName = cmdPath,
                        UseShellExecute = false,
                        WorkingDirectory = cmdPath.Substring(0,
                            cmdPath.Length - (cmdPath.Length - cmdPath.LastIndexOf('\\'))),
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    },
                    EnableRaisingEvents = true
                };

                proc.StartInfo.CreateNoWindow = true;
                proc.ErrorDataReceived += ProcDataReceived;
                proc.OutputDataReceived += ProcDataReceived;
                proc.Exited += ProcHasExited;
                proc.Start();
                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                RunServer();
            }
        }

        public void ProcHasExited(object sender, EventArgs e)
        {
            var proLogin = ProcNameCfg(Handler.LoginExePath);
            var proChar = ProcNameCfg(Handler.CharExePath);
            var proMap = ProcNameCfg(Handler.MapExePath);

            var process = (Process)sender;
            var lower = process.ProcessName.ToLower();

            if (lower == proLogin.ToLower())
            {
                Invoke(new MethodInvoker(delegate { LoginLog.AppendText(">>Login Server - stopped<<" + Environment.NewLine); }));
            }

            if (lower == proChar.ToLower())
            {
                Invoke(new MethodInvoker(delegate { CharLog.AppendText(">>Char Server - stopped<<" + Environment.NewLine); }));
            }

            if (lower == proMap.ToLower())
            {
                Invoke(new MethodInvoker(delegate { MapLog.AppendText(">>Map Server - stopped<<" + Environment.NewLine); }));
            }
        }

        public void ProcDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                var procLogin = ProcNameCfg(Handler.LoginExePath);
                var procChar = ProcNameCfg(Handler.CharExePath);
                var procMap = ProcNameCfg(Handler.MapExePath);
                var process = ((Process)sender);
                var lower = process.ProcessName.ToLower();

                if (lower == procLogin.ToLower())
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        #region information

                        if (e.Data.Contains("[Error]"))
                        {
                            _errorMsg = _errorMsg + 1;
                            lbError.Text = @"Error: " + _errorMsg;
                            ErrorLog += "[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            _debugMsg = _debugMsg + 1;
                            lbDebug.Text = @"Debug: " + _debugMsg;
                            DebugLog += "[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            _sqlMsg = _sqlMsg + 1;
                            lbSql.Text = @"SQL: " + _sqlMsg;
                            SqlLog += "[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            _warnMsg = _warnMsg + 1;
                            lbWarning.Text = @"Warning: " + _warnMsg;
                            WarningLog += "[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("set users"))
                        {
                            try
                            {
                                if (Handler.ColorOldRev)
                                {
                                    var playerCount = e.Data.Split(':');
                                    lbUsers.Text = playerCount[3];
                                }
                                else
                                {
                                    var playerCount = e.Data.Split(':');
                                    lbUsers.Text = playerCount[2];
                                }
                            }
                            catch
                            {
                                lbUsers.Text = @"-GetFail-";
                            }
                        }

                        #endregion information

                        if (Handler.ColorMode)
                        {
                            if (!Handler.ColorOldRev)
                            {
                                #region Color Text REV 16400+

                                if (e.Data.Contains("[Status]"))
                                {
                                    LoginLog.AppendText("[Status]", Handler.Status);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 8);
                                    LoginLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    LoginLog.AppendText("[Info]", Handler.Info);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 6);
                                    LoginLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    LoginLog.AppendText("[Notice]", Handler.Notice);

                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 8);
                                    LoginLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    LoginLog.AppendText("[Warning]", Handler.Warning);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 9);
                                    LoginLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    LoginLog.AppendText("[Error]", Handler.Error);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 7);
                                    LoginLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    LoginLog.AppendText("[SQL]", Handler.Sql);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 5);
                                    LoginLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    LoginLog.AppendText("[Debug]", Handler.Debug);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 7);
                                    LoginLog.AppendText(newEData + Environment.NewLine);
                                }
                                else
                                {
                                    LoginLog.AppendText(e.Data + Environment.NewLine);
                                }

                                #endregion Color Text REV 16400+
                            }
                            else
                            {
                                #region Color Text REV 16400-

                                var rtbLs = e.Data.Split(']');
                                if (e.Data.Contains("[Status]"))
                                {
                                    try
                                    {
                                        LoginLog.AppendText("[Status]", Handler.Status);
                                        LoginLog.AppendText(rtbLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        LoginLog.AppendText("[Status]", Handler.Status);
                                        LoginLog.AppendText(rtbLs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    try
                                    {
                                        LoginLog.AppendText("[Info]", Handler.Info);
                                        LoginLog.AppendText(rtbLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        LoginLog.AppendText("[Info]", Handler.Info);
                                        LoginLog.AppendText(rtbLs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    try
                                    {
                                        LoginLog.AppendText("[Notice]", Handler.Notice);
                                        LoginLog.AppendText(rtbLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        LoginLog.AppendText("[Notice]", Handler.Notice);
                                        LoginLog.AppendText(rtbLs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    try
                                    {
                                        LoginLog.AppendText("[Warning]", Handler.Warning);
                                        LoginLog.AppendText(rtbLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        LoginLog.AppendText("[Warning]", Handler.Warning);
                                        LoginLog.AppendText(rtbLs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    try
                                    {
                                        LoginLog.AppendText("[Error]", Handler.Error);
                                        LoginLog.AppendText(rtbLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        LoginLog.AppendText("[Error]", Handler.Error);
                                        LoginLog.AppendText(rtbLs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    try
                                    {
                                        LoginLog.AppendText("[SQL]", Handler.Sql);
                                        LoginLog.AppendText(rtbLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        LoginLog.AppendText("[SQL]", Handler.Sql);
                                        LoginLog.AppendText(rtbLs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    try
                                    {
                                        LoginLog.AppendText("[Debug]", Handler.Debug);
                                        LoginLog.AppendText(rtbLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        LoginLog.AppendText("[Debug]", Handler.Debug);
                                        LoginLog.AppendText(rtbLs[1] + Environment.NewLine);
                                    }
                                }
                                else
                                {
                                    LoginLog.AppendText(e.Data + Environment.NewLine);
                                }

                                #endregion Color Text REV 16400-
                            }
                        }
                        else
                        {
                            LoginLog.AppendText(e.Data + Environment.NewLine);
                        }
                    }));
                }
                if (lower == procChar.ToLower())
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        #region information

                        if (e.Data.Contains("[Error]"))
                        {
                            _errorMsg = _errorMsg + 1;
                            lbError.Text = @"Error: " + _errorMsg;
                            ErrorLog += "[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            _debugMsg = _debugMsg + 1;
                            lbDebug.Text = @"Debug: " + _debugMsg;
                            DebugLog += "[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            _sqlMsg = _sqlMsg + 1;
                            lbSql.Text = @"SQL: " + _sqlMsg;
                            SqlLog += "[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            _warnMsg = _warnMsg + 1;
                            lbWarning.Text = @"Warning: " + _warnMsg;
                            WarningLog += "[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }

                        #endregion information

                        if (Handler.ColorMode)
                        {
                            if (!Handler.ColorOldRev)
                            {
                                #region Color Text REV 16400+

                                if (e.Data.Contains("[Status]"))
                                {
                                    CharLog.AppendText("[Status]", Handler.Status);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 8);
                                    CharLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    CharLog.AppendText("[Info]", Handler.Info);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 6);
                                    CharLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    CharLog.AppendText("[Notice]", Handler.Notice);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 8);
                                    CharLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    CharLog.AppendText("[Warning]", Handler.Warning);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 9);
                                    CharLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    CharLog.AppendText("[Error]", Handler.Error);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 7);
                                    CharLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    CharLog.AppendText("[SQL]", Handler.Sql);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 5);
                                    CharLog.AppendText(newEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    CharLog.AppendText("[Debug]", Handler.Debug);
                                    var oriEData = e.Data;
                                    var newEData = oriEData.Remove(0, 7);
                                    CharLog.AppendText(newEData + Environment.NewLine);
                                }
                                else
                                {
                                    CharLog.AppendText(e.Data + Environment.NewLine);
                                }

                                #endregion Color Text REV 16400+
                            }
                            else
                            {
                                #region Color Text REV 16400-

                                var rtbCs = e.Data.Split(']');
                                if (e.Data.Contains("[Status]"))
                                {
                                    try
                                    {
                                        CharLog.AppendText("[Status]", Handler.Status);
                                        CharLog.AppendText(rtbCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        CharLog.AppendText("[Status]", Handler.Status);
                                        CharLog.AppendText(rtbCs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    try
                                    {
                                        CharLog.AppendText("[Info]", Handler.Info);
                                        CharLog.AppendText(rtbCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        CharLog.AppendText("[Info]", Handler.Info);
                                        CharLog.AppendText(rtbCs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    try
                                    {
                                        CharLog.AppendText("[Notice]", Handler.Notice);
                                        CharLog.AppendText(rtbCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        CharLog.AppendText("[Notice]", Handler.Notice);
                                        CharLog.AppendText(rtbCs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    try
                                    {
                                        CharLog.AppendText("[Warning]", Handler.Warning);
                                        CharLog.AppendText(rtbCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        CharLog.AppendText("[Warning]", Handler.Warning);
                                        CharLog.AppendText(rtbCs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    try
                                    {
                                        CharLog.AppendText("[Error]", Handler.Error);
                                        CharLog.AppendText(rtbCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        CharLog.AppendText("[Error]", Handler.Error);
                                        CharLog.AppendText(rtbCs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    try
                                    {
                                        CharLog.AppendText("[SQL]", Handler.Sql);
                                        CharLog.AppendText(rtbCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        CharLog.AppendText("[SQL]", Handler.Sql);
                                        CharLog.AppendText(rtbCs[1] + Environment.NewLine);
                                    }
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    try
                                    {
                                        CharLog.AppendText("[Debug]", Handler.Debug);
                                        CharLog.AppendText(rtbCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        CharLog.AppendText("[Debug]", Handler.Debug);
                                        CharLog.AppendText(rtbCs[1] + Environment.NewLine);
                                    }
                                }
                                else
                                {
                                    CharLog.AppendText(e.Data + Environment.NewLine);
                                }

                                #endregion Color Text REV 16400-
                            }
                        }
                        else
                        {
                            CharLog.AppendText(e.Data + Environment.NewLine);
                        }
                    }));
                }
                if (lower == procMap.ToLower())
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        #region information

                        if (e.Data.Contains("[Error]"))
                        {
                            _errorMsg = _errorMsg + 1;
                            lbError.Text = @"Error: " + _errorMsg;
                            ErrorLog += "[Map][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("script error")) // special error
                        {
                            _errorMsg = _errorMsg + 1;
                            lbError.Text = @"Error: " + _errorMsg;
                            ErrorLog += "[Map][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            _debugMsg = _debugMsg + 1;
                            lbDebug.Text = @"Debug: " + _debugMsg;
                            DebugLog += "[Map][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            _sqlMsg = _sqlMsg + 1;
                            lbSql.Text = @"SQL: " + _sqlMsg;
                            SqlLog += "[Map][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            _warnMsg = _warnMsg + 1;
                            lbWarning.Text = @"Warning: " + _warnMsg;
                            WarningLog += "[Map][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine;
                        }

                        #endregion information

                        if (Handler.ColorMode)
                        {
                            #region color text

                            if (e.Data.Contains("[Status]"))
                            {
                                MapLog.AppendText("[Status]", Handler.Status);
                                var oriEData = e.Data; var newEData = oriEData.Remove(0, 8);
                                MapLog.AppendText(newEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Info]"))
                            {
                                MapLog.AppendText("[Info]", Handler.Info);
                                var oriEData = e.Data; var newEData = oriEData.Remove(0, 6);
                                MapLog.AppendText(newEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Notice]"))
                            {
                                MapLog.AppendText("[Notice]", Handler.Notice);
                                var oriEData = e.Data; var newEData = oriEData.Remove(0, 8);
                                MapLog.AppendText(newEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Warning]"))
                            {
                                MapLog.AppendText("[Warning]", Handler.Warning);
                                var oriEData = e.Data; var newEData = oriEData.Remove(0, 9);
                                MapLog.AppendText(newEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Error]"))
                            {
                                MapLog.AppendText("[Error]", Handler.Error);
                                var oriEData = e.Data; var newEData = oriEData.Remove(0, 7);
                                MapLog.AppendText(newEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[SQL]"))
                            {
                                MapLog.AppendText("[SQL]", Handler.Sql);
                                var oriEData = e.Data; var newEData = oriEData.Remove(0, 5);
                                MapLog.AppendText(newEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Debug]"))
                            {
                                MapLog.AppendText("[Debug]", Handler.Debug);
                                var oriEData = e.Data; var newEData = oriEData.Remove(0, 7);
                                MapLog.AppendText(newEData + Environment.NewLine);
                            }
                            else
                            {
                                MapLog.AppendText(e.Data + Environment.NewLine);
                            }

                            #endregion color text
                        }
                        else
                        {
                            MapLog.AppendText(e.Data + Environment.NewLine);
                        }
                    }));
                }
            }
        }

        #endregion Server Manager
    }
}