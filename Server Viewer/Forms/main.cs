using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Server_Viewer.forms;
using Server_Viewer.Forms;

/* 
 * ToDo Rewrite the Code Idiot!
 * You can make it smaller & Better!
 * But nooooo just sit there and look at the Wall!
 * Nice one Bro!
*/

namespace Server_Viewer
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            try
            {
                //frm_errorlog.tb_errors = new System.Windows.Forms.TextBox();
            }
            catch { }
        }

        private static Boolean onoff = false;
        private static Boolean traymsg = false;

        private static int debugmsgs = 0;
        private static int sqlmsgs = 0;
        private static int errormsgs = 0;
        private static int playermsgs = 0;
        private static int warnmsgs = 0;
        private Point p;

        private void main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\SM_config.ini"))
            {
                Handler.IniCreate();
            }
            else
            {
                Handler.IniRead();
            }

            frm_errorlog.tb_errors = new System.Windows.Forms.TextBox();
            //tray.Visible = true;

            lb_debug.BackColor = Color.Transparent;
            lb_sql.BackColor = Color.Transparent;
            lb_error.BackColor = Color.Transparent;
            lb_users.BackColor = Color.Transparent;
            lb_warnings.BackColor = Color.Transparent;
            //label2.BackColor = Color.Transparent;

            panel.BackColor = Color.Transparent;

            label1.Focus();

            lb_close.BackColor = Color.Transparent;
            lb_minimaze.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;


            lb_debug.Text = "Debug: " + debugmsgs;
            lb_sql.Text = "SQL: " + sqlmsgs;
            lb_error.Text = "Error: " + errormsgs;
            lb_users.Text = "" + playermsgs;
            lb_warnings.Text = "Warning: " + warnmsgs;
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (!onoff)
            {
                onoff = true;

                try
                {
                    try
                    {
                        KillAll(procnamecfg(Handler.LoginExePath));
                        KillAll(procnamecfg(Handler.CharExePath));
                        KillAll(procnamecfg(Handler.MapExePath));
                    }
                    catch
                    {

                    }
                    RTBLogin.Clear();
                    RTBChar.Clear();
                    RTBMap.Clear();
                    RunWithRedirect(Handler.LoginExePath);
                    RunWithRedirect(Handler.CharExePath);
                    RunWithRedirect(Handler.MapExePath);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n" + err.StackTrace);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                debugmsgs = 0;
                sqlmsgs = 0;
                errormsgs = 0;
                warnmsgs = 0;
                playermsgs = 0;
                lb_debug.Text = "Debug: " + debugmsgs;
                lb_sql.Text = "SQL: " + sqlmsgs;
                lb_error.Text = "Error: " + errormsgs;
                lb_users.Text = "" + playermsgs;
                lb_warnings.Text = "Warning: " + warnmsgs;
                KillAll(procnamecfg(Handler.LoginExePath));
                KillAll(procnamecfg(Handler.CharExePath));
                KillAll(procnamecfg(Handler.MapExePath));
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
                KillAll(procnamecfg(Handler.LoginExePath));
                KillAll(procnamecfg(Handler.CharExePath));
                KillAll(procnamecfg(Handler.MapExePath));
                Process me = Process.GetCurrentProcess();
                int i = 0;
                bool flag = true;
                while (flag)
                {
                    me.Threads[i].Dispose();
                    i++;
                    flag = i < me.Threads.Count;

                }
        }

        //VARS
        public Process _process = null;

        //Handlers and Functions
        public void KillAll(string ProcessName)
        {
            foreach (Process p in Process.GetProcesses())
            {
                try
                {
                    if (p.ProcessName.ToLower().Contains(ProcessName.ToLower()) == true)
                    {
                        p.Kill();
                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n" + err.StackTrace);
                }
            }
        }

        public string procnamecfg(string cfgname)
        {
                string ret = cfgname.Substring(cfgname.LastIndexOf("\\") + 1, (cfgname.LastIndexOf(".") - 1 - cfgname.LastIndexOf("\\")));
                return ret;
        }

        public void RunWithRedirect(string cmdPath)
        {
            try
            {
                var proc = new Process();

                proc.StartInfo.FileName = cmdPath;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.WorkingDirectory = cmdPath.Substring(0, cmdPath.Length - (cmdPath.Length - cmdPath.LastIndexOf('\\')));
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.EnableRaisingEvents = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.ErrorDataReceived += proc_DataReceived;
                proc.OutputDataReceived += proc_DataReceived;
                proc.Exited += proc_HasExited;
                proc.Start();
                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\n\n" + err.StackTrace);
            }
        }

        public void proc_HasExited(object sender, EventArgs e)
        {

            string loginn = procnamecfg(Handler.LoginExePath);
            string charr = procnamecfg(Handler.CharExePath);
            string mapp = procnamecfg(Handler.MapExePath);
            Process cproc = ((Process)sender);
            string switchval = cproc.ProcessName.ToLower();

            if (switchval == loginn.ToLower())
            {

                Invoke(new MethodInvoker(delegate { RTBLogin.AppendText(">>Login Server - stopped<<" + Environment.NewLine); }));

            }
            if (switchval == charr.ToLower())
            {

                Invoke(new MethodInvoker(delegate { RTBChar.AppendText(">>Char Server - stopped<<" + Environment.NewLine); }));

            }
            if (switchval == mapp.ToLower())
            {

                Invoke(new MethodInvoker(delegate { RTBMap.AppendText(">>Map Server - stopped<<" + Environment.NewLine); }));

            }

        }
        #region Empfänger, RTB Eintragungen
        public void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string loginn = procnamecfg(Handler.LoginExePath);
                string charr = procnamecfg(Handler.CharExePath);
                string mapp = procnamecfg(Handler.MapExePath);
                Process cproc = ((Process)sender);
                string switchval = cproc.ProcessName.ToLower();

                if (switchval == loginn.ToLower())
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        #region information
                        if (e.Data.Contains("[Error]"))
                        {
                            frm_errorlog.tb_errors.AppendText("[Login][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                            errormsgs = errormsgs + 1;
                            lb_error.Text = "Error: " + errormsgs;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            debugmsgs = debugmsgs + 1;
                            lb_debug.Text = "Debug: " + debugmsgs;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            sqlmsgs = sqlmsgs + 1;
                            lb_sql.Text = "SQL: " + sqlmsgs;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            warnmsgs = warnmsgs + 1;
                            lb_warnings.Text = "Warning: " + warnmsgs;
                        }
                        else if (e.Data.Contains("set users"))
                        {
                            try
                            {
                                if (Handler.ColorOldRev)
                                {
                                    string[] playercount = e.Data.Split(new Char[] { ':' });
                                    lb_users.Text = playercount[3];
                                }
                                else
                                {
                                    string[] playercount = e.Data.Split(new Char[] { ':' });
                                    lb_users.Text = playercount[2];
                                }
                            }
                            catch
                            {
                                lb_users.Text = "-GetFail-";
                            }
                        }
                        #endregion
                        if (Handler.ColorMode)
                        {
                            if (!Handler.ColorOldRev)
                            {
                                #region Color Text REV 16400+
                                if (e.Data.Contains("[Status]"))
                                {
                                    Handler.AppendText(RTBLogin, "[Status]", Handler.Status);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    Handler.AppendText(RTBLogin, "[Info]", Handler.Info);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 6);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    Handler.AppendText(RTBLogin, "[Notice]", Handler.Notice);

                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    Handler.AppendText(RTBLogin, "[Warning]", Handler.Warning);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 9);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    Handler.AppendText(RTBLogin, "[Error]", Handler.Error);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    Handler.AppendText(RTBLogin, "[SQL]", Handler.Sql);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 5);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    Handler.AppendText(RTBLogin, "[Debug]", Handler.Debug);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBLogin.AppendText(NewEData + Environment.NewLine);
                                }
                                else
                                {
                                    RTBLogin.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                            else
                            {
                                #region Color Text REV 16400-
                                string[] RTBLs = e.Data.Split(new Char[] { ']' });
                                if (e.Data.Contains("[Status]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBLogin, "[Status]", Handler.Status);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBLogin, "[Status]", Handler.Status);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBLogin, "[Info]", Handler.Info);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBLogin, "[Info]", Handler.Info);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBLogin, "[Notice]", Handler.Notice);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBLogin, "[Notice]", Handler.Notice);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBLogin, "[Warning]", Handler.Warning);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBLogin, "[Warning]", Handler.Warning);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBLogin, "[Error]", Handler.Error);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBLogin, "[Error]", Handler.Error);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBLogin, "[SQL]", Handler.Sql);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBLogin, "[SQL]", Handler.Sql);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBLogin, "[Debug]", Handler.Debug);
                                        RTBLogin.AppendText(RTBLs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBLogin, "[Debug]", Handler.Debug);
                                        RTBLogin.AppendText(RTBLs[1] + Environment.NewLine);
                                    }

                                }
                                else
                                {
                                    RTBLogin.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                        }
                        else
                        {
                            RTBLogin.AppendText(e.Data + Environment.NewLine);
                        }

                    }));

                }
                if (switchval == charr.ToLower())
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        #region information
                        if (e.Data.Contains("[Error]"))
                        {
                            errormsgs = errormsgs + 1;
                            lb_error.Text = "Error: " + errormsgs;
                            frm_errorlog.tb_errors.AppendText("[Char][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            debugmsgs = debugmsgs + 1;
                            lb_debug.Text = "Debug: " + debugmsgs;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            sqlmsgs = sqlmsgs + 1;
                            lb_sql.Text = "SQL: " + sqlmsgs;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            warnmsgs = warnmsgs + 1;
                            lb_warnings.Text = "Warning: " + warnmsgs;
                        }
                        #endregion
                        if (Handler.ColorMode)
                        {
                            if (!Handler.ColorOldRev)
                            {
                                #region Color Text REV 16400+
                                if (e.Data.Contains("[Status]"))
                                {
                                    Handler.AppendText(RTBChar, "[Status]", Handler.Status);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    Handler.AppendText(RTBChar, "[Info]", Handler.Info);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 6);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    Handler.AppendText(RTBChar, "[Notice]", Handler.Notice);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    Handler.AppendText(RTBChar, "[Warning]", Handler.Warning);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 9);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    Handler.AppendText(RTBChar, "[Error]", Handler.Error);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    Handler.AppendText(RTBChar, "[SQL]", Handler.Sql);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 5);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    Handler.AppendText(RTBChar, "[Debug]", Handler.Debug);
                                    String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                    RTBChar.AppendText(NewEData + Environment.NewLine);
                                }
                                else
                                {
                                    RTBChar.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                            else
                            {
                                #region Color Text REV 16400-
                                string[] RTBCs = e.Data.Split(new Char[] { ']' });
                                if (e.Data.Contains("[Status]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBChar, "[Status]", Handler.Status);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBChar, "[Status]", Handler.Status);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Info]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBChar, "[Info]", Handler.Info);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBChar, "[Info]", Handler.Info);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Notice]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBChar, "[Notice]", Handler.Notice);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBChar, "[Notice]", Handler.Notice);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Warning]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBChar, "[Warning]", Handler.Warning);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBChar, "[Warning]", Handler.Warning);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Error]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBChar, "[Error]", Handler.Error);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBChar, "[Error]", Handler.Error);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[SQL]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBChar, "[SQL]", Handler.Sql);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBChar, "[SQL]", Handler.Sql);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else if (e.Data.Contains("[Debug]"))
                                {
                                    try
                                    {
                                        Handler.AppendText(RTBChar, "[Debug]", Handler.Debug);
                                        RTBChar.AppendText(RTBCs[2] + Environment.NewLine);
                                    }
                                    catch
                                    {
                                        Handler.AppendText(RTBChar, "[Debug]", Handler.Debug);
                                        RTBChar.AppendText(RTBCs[1] + Environment.NewLine);
                                    }

                                }
                                else
                                {
                                    RTBChar.AppendText(e.Data + Environment.NewLine);
                                }
                                #endregion
                            }
                        }
                        else
                        {
                            RTBChar.AppendText(e.Data + Environment.NewLine);
                        }
                    }));

                }
                if (switchval == mapp.ToLower())
                {

                    Invoke(new MethodInvoker(delegate
                    {
                        #region information
                        if (e.Data.Contains("[Error]"))
                        {
                            frm_errorlog.tb_errors.AppendText("[Map][" + Convert.ToString(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes) + "] " + e.Data + Environment.NewLine);
                            errormsgs = errormsgs + 1;
                            lb_error.Text = "Error: " + errormsgs;
                        }
                        else if (e.Data.Contains("[Debug]"))
                        {
                            debugmsgs = debugmsgs + 1;
                            lb_debug.Text = "Debug: " + debugmsgs;
                        }
                        else if (e.Data.Contains("[SQL]"))
                        {
                            sqlmsgs = sqlmsgs + 1;
                            lb_sql.Text = "SQL: " + sqlmsgs;
                        }
                        else if (e.Data.Contains("[Warning]"))
                        {
                            warnmsgs = warnmsgs + 1;
                            lb_warnings.Text = "Warning: " + warnmsgs;
                        }
                        #endregion
                        if (Handler.ColorMode)
                        {
                            #region color text
                            if (e.Data.Contains("[Status]"))
                            {
                                Handler.AppendText(RTBMap, "[Status]", Handler.Status);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Info]"))
                            {
                                Handler.AppendText(RTBMap, "[Info]", Handler.Info);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 6);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Notice]"))
                            {
                                Handler.AppendText(RTBMap, "[Notice]", Handler.Notice);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 8);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Warning]"))
                            {
                                Handler.AppendText(RTBMap, "[Warning]", Handler.Warning);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 9);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Error]"))
                            {
                                Handler.AppendText(RTBMap, "[Error]", Handler.Error);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[SQL]"))
                            {
                                Handler.AppendText(RTBMap, "[SQL]", Handler.Sql);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 5);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else if (e.Data.Contains("[Debug]"))
                            {
                                Handler.AppendText(RTBMap, "[Debug]", Handler.Debug);
                                String OriEData = e.Data; String NewEData = OriEData.Remove(0, 7);
                                RTBMap.AppendText(NewEData + Environment.NewLine);
                            }
                            else
                            {
                                RTBMap.AppendText(e.Data + Environment.NewLine);
                            }
                            #endregion
                        }
                        else
                        {
                            RTBMap.AppendText(e.Data + Environment.NewLine);
                        }
                    }));

                }
            }
        }
        #endregion
        #region close smalli
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            KillAll(procnamecfg(Handler.LoginExePath));
            KillAll(procnamecfg(Handler.CharExePath));
            KillAll(procnamecfg(Handler.MapExePath));
        }

        private void RTBLogin_TextChanged(object sender, EventArgs e)
        {
            RTBLogin.ScrollToCaret();
        }

        private void RTBChar_TextChanged(object sender, EventArgs e)
        {
            RTBChar.ScrollToCaret();
        }

        private void RTBMap_TextChanged(object sender, EventArgs e)
        {
            RTBMap.ScrollToCaret();
        }

        private void option_Click(object sender, EventArgs e)
        {
            frm_option frm_opt = new frm_option();
            if (!Handler.OpenOpt)
            {
                frm_opt.Show();
                Handler.OpenOpt = true;
            }
            else
            {
                //int hwnd = frm_opt.Handle.ToInt32();
                //SetForegroundWindow(hwnd);
                Handler.SetForegroundWindowEx(frm_opt);
            }
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            p.X = e.X;
            p.Y = e.Y;
        }

        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_minimaze_Click(object sender, EventArgs e)
        {
            tray.Visible = true;
            if (!traymsg)
            {
                tray.BalloonTipTitle = "Server Monitor";
                tray.BalloonTipText = "Minimazed to tray.";
                traymsg = true;
                tray.ShowBalloonTip(250);
            }
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
         }
        #endregion

        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        private void tray_MouseClick(object sender, MouseEventArgs e)
        {
           /*if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("lol");
            }*/
        }
        #region Text Changed
        private void lb_users_TextChanged(object sender, EventArgs e)
        {
            tc_player.Text = "Player: " + lb_users.Text;
        }

        private void lb_warnings_TextChanged(object sender, EventArgs e)
        {
            tc_warning.Text = lb_warnings.Text;
        }

        private void lb_error_TextChanged(object sender, EventArgs e)
        {
            tc_error.Text = lb_error.Text;
        }

        private void lb_sql_TextChanged(object sender, EventArgs e)
        {
            tc_sql.Text = lb_sql.Text;
        }

        private void lb_debug_TextChanged(object sender, EventArgs e)
        {
            tc_debug.Text = lb_debug.Text;
        }
#endregion

        private void tc_restore_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        private void tc_startstop_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                debugmsgs = 0;
                sqlmsgs = 0;
                errormsgs = 0;
                warnmsgs = 0;
                playermsgs = 0;
                lb_debug.Text = "Debug: " + debugmsgs;
                lb_sql.Text = "SQL: " + sqlmsgs;
                lb_error.Text = "Error: " + errormsgs;
                lb_users.Text = "" + playermsgs;
                lb_warnings.Text = "Warning: " + warnmsgs;
                KillAll(procnamecfg(Handler.LoginExePath));
                KillAll(procnamecfg(Handler.CharExePath));
                KillAll(procnamecfg(Handler.MapExePath));
            }
            else
            {
                onoff = true;

                try
                {
                    try
                    {
                        KillAll(procnamecfg(Handler.LoginExePath));
                        KillAll(procnamecfg(Handler.CharExePath));
                        KillAll(procnamecfg(Handler.MapExePath));
                    }
                    catch
                    {

                    }
                    RTBLogin.Clear();
                    RTBChar.Clear();
                    RTBMap.Clear();
                    RunWithRedirect(Handler.LoginExePath);
                    RunWithRedirect(Handler.CharExePath);
                    RunWithRedirect(Handler.MapExePath);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n" + err.StackTrace);
                }
            }
        }

        private void tc_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tc_about_Click(object sender, EventArgs e)
        {
            frm_about frm_abt = new frm_about();
            if (!Handler.OpenAbt)
            {
                frm_abt.Show();
                Handler.OpenAbt = true;
            }
            else
            {
                Handler.SetForegroundWindowEx(frm_abt);
            }
            
        }

        private void tc_options_Click(object sender, EventArgs e)
        {
            frm_option frm_opt = new frm_option();
            if (!Handler.OpenOpt)
            {
                frm_opt.Show();
                Handler.OpenOpt = true;
            }
            else
            {
                Handler.SetForegroundWindowEx(frm_opt);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            frm_errorlog error = new frm_errorlog();
            error.Show();
        }
    }
}
