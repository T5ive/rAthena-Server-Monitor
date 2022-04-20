namespace rAthena_Server_Monitor.Helper;

public class ProcessHelper
{
    public async Task<ProcessResult> RunWithRedirect(string command)
    {
        var result = new ProcessResult();

        using var process = new Process();
        process.StartInfo.FileName = command;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.WorkingDirectory =
            command.Substring(0,
                command.Length - (command.Length - command.LastIndexOf('\\')));
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;

        process.StartInfo.CreateNoWindow = true;

        process.EnableRaisingEvents = true;
        var outputBuilder = new StringBuilder();
        var outputCloseEvent = new TaskCompletionSource<bool>();
        process.OutputDataReceived += ProcDataReceived;
        process.ErrorDataReceived += ProcDataReceived;
        process.Exited += ProcHasExited;

        void ProcDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Data))
            {
                var proc = (Process)sender;
                var lower = proc.ProcessName.ToLower();
                LoginLog(sender, e, lower);
                CharLog(sender, e, lower);
                MapLog(sender, e, lower);
                WebLog(sender, e, lower);
                outputBuilder.AppendLine(e.Data);
            }
        }

        void LoginLog(object sender, DataReceivedEventArgs e, string lower)
        {
            var procLogin = ProcNameCfg(PublicClass.MySettings.LoginExePath);
            if (lower == procLogin.ToLower())
            {
                #region information

                if (e.Data.Contains("[Error]"))
                {
                    UpCount(MyEnum.LogType.ErrorLogin);
                    UpLogs(MyEnum.LogType.ErrorLogin, e.Data);
                }
                else if (e.Data.Contains("set users"))
                {
                    try
                    {
                        var playerCount = e.Data.Split(':');
                        Program.FrmMain.Online = int.Parse(playerCount[2]);
                    }
                    catch
                    {
                        Program.FrmMain.Online = 0;
                    }
                }

                OtherLog(sender, e);

                #endregion information

                if (e.Data.Contains("[Status]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Status, e.Data);
                }
                else if (e.Data.Contains("[Info]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Info, e.Data);
                }
                else if (e.Data.Contains("[Notice]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Notice, e.Data);
                }
                else if (e.Data.Contains("[Warning]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Warning, e.Data);
                }
                else if (e.Data.Contains("[Error]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Error, e.Data);
                }
                else if (e.Data.Contains("[SQL]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Sql, e.Data);
                }
                else if (e.Data.Contains("[Debug]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Debug, e.Data);
                }
                else
                {
                    WriteLogs(MyEnum.LogType.ErrorLogin, MyEnum.ConsoleType.Other, e.Data);
                }
            }
        }

        void CharLog(object sender, DataReceivedEventArgs e, string lower)
        {
            var procChar = ProcNameCfg(PublicClass.MySettings.CharExePath);
            if (lower == procChar.ToLower())
            {
                #region information

                if (e.Data.Contains("[Error]"))
                {
                    UpCount(MyEnum.LogType.ErrorChar);
                    UpLogs(MyEnum.LogType.ErrorChar, e.Data);
                }
                OtherLog(sender, e);

                #endregion information

                if (e.Data.Contains("[Status]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Status, e.Data);
                }
                else if (e.Data.Contains("[Info]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Info, e.Data);
                }
                else if (e.Data.Contains("[Notice]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Notice, e.Data);
                }
                else if (e.Data.Contains("[Warning]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Warning, e.Data);
                }
                else if (e.Data.Contains("[Error]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Error, e.Data);
                }
                else if (e.Data.Contains("[SQL]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Sql, e.Data);
                }
                else if (e.Data.Contains("[Debug]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Debug, e.Data);
                }
                else
                {
                    WriteLogs(MyEnum.LogType.ErrorChar, MyEnum.ConsoleType.Other, e.Data);
                }
            }
        }

        void MapLog(object sender, DataReceivedEventArgs e, string lower)
        {
            var procMap = ProcNameCfg(PublicClass.MySettings.MapExePath);
            if (lower == procMap.ToLower())
            {
                #region information

                if (e.Data.Contains("[Error]") || e.Data.Contains("script error"))
                {
                    UpCount(MyEnum.LogType.ErrorMap);
                    UpLogs(MyEnum.LogType.ErrorMap, e.Data);
                }
                OtherLog(sender, e);

                #endregion information

                if (e.Data.Contains("[Status]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Status, e.Data);
                }
                else if (e.Data.Contains("[Info]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Info, e.Data);
                }
                else if (e.Data.Contains("[Notice]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Notice, e.Data);
                }
                else if (e.Data.Contains("[Warning]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Warning, e.Data);
                }
                else if (e.Data.Contains("[Error]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Error, e.Data);
                }
                else if (e.Data.Contains("[SQL]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Sql, e.Data);
                }
                else if (e.Data.Contains("[Debug]"))
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Debug, e.Data);
                }
                else
                {
                    WriteLogs(MyEnum.LogType.ErrorMap, MyEnum.ConsoleType.Other, e.Data);
                }
            }
        }

        void OtherLog(object sender, DataReceivedEventArgs e)
        {
            if (e.Data.Contains("[Debug]"))
            {
                UpCount(MyEnum.LogType.Debug);
                UpLogs(MyEnum.LogType.Debug, e.Data);
            }
            else if (e.Data.Contains("[SQL]"))
            {
                UpCount(MyEnum.LogType.SQL);
                UpLogs(MyEnum.LogType.SQL, e.Data);
            }
            else if (e.Data.Contains("[Warning]"))
            {
                UpCount(MyEnum.LogType.Warning);
                UpLogs(MyEnum.LogType.Warning, e.Data);
            }
        }

        void WebLog(object sender, DataReceivedEventArgs e, string lower)
        {
            var procMap = ProcNameCfg(PublicClass.MySettings.WebExePath);
            if (lower == procMap.ToLower())
            {
                if (e.Data.Contains("[Status]"))
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Status, e.Data);
                }
                else if (e.Data.Contains("[Info]"))
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Info, e.Data);
                }
                else if (e.Data.Contains("[Notice]"))
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Notice, e.Data);
                }
                else if (e.Data.Contains("[Warning]"))
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Warning, e.Data);
                }
                else if (e.Data.Contains("[Error]"))
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Error, e.Data);
                }
                else if (e.Data.Contains("[SQL]"))
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Sql, e.Data);
                }
                else if (e.Data.Contains("[Debug]"))
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Debug, e.Data);
                }
                else
                {
                    WriteLogs(MyEnum.LogType.Web, MyEnum.ConsoleType.Other, e.Data);
                }
            }
        }

        bool isStarted;

        try
        {
            isStarted = process.Start();
        }
        catch (Exception error)
        {
            // Usually it occurs when an executable file is not found or is not executable

            result.Completed = true;
            result.ExitCode = -1;
            result.Output = error.Message;

            isStarted = false;
        }

        if (isStarted)
        {
            // Reads the output stream first and then waits because deadlocks are possible
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            // Creates task to wait for process exit using timeout
            var waitForExit = WaitForExitAsync(process, 50000);

            // Create task to wait for process exit and closing all output streams
            var processTask = Task.WhenAll(waitForExit, outputCloseEvent.Task);

            // Waits process completion and then checks it was not completed by timeout
            if (await Task.WhenAny(Task.Delay(50000), processTask).ConfigureAwait(false) == processTask && await waitForExit.ConfigureAwait(false))
            {
                result.Completed = true;
                result.ExitCode = process.ExitCode;

                // Adds process output if it was completed with error
                if (process.ExitCode != 0)
                {
                    result.Output = $"{outputBuilder}";
                }
            }
            else
            {
                try
                {
                    //process.Kill();
                }
                catch
                {
                    //
                }
            }
        }

        return result;
    }

    private void ProcHasExited(object sender, EventArgs e)
    {
        var proLogin = ProcNameCfg(PublicClass.MySettings.LoginExePath);
        var proChar = ProcNameCfg(PublicClass.MySettings.CharExePath);
        var proMap = ProcNameCfg(PublicClass.MySettings.MapExePath);

        var proc = (Process)sender;
        var lower = proc.ProcessName.ToLower();

        if (lower == proLogin.ToLower())
        {
            Program.FrmMain.txtLogin.Invoke(delegate
            {
                Program.FrmMain.txtLogin.AppendText(">>Login Server - stopped<<" + Environment.NewLine);
            });
        }

        if (lower == proChar.ToLower())
        {
            Program.FrmMain.txtChar.Invoke(delegate
            {
                Program.FrmMain.txtChar.AppendText(">>Char Server - stopped<<" + Environment.NewLine);
            });
        }

        if (lower == proMap.ToLower())
        {
            Program.FrmMain.txtMap.Invoke(delegate
            {
                Program.FrmMain.txtMap.AppendText(">>Map Server - stopped<<" + Environment.NewLine);
            });
        }
    }

    private static Task<bool> WaitForExitAsync(Process process, int timeout)
    {
        return Task.Run(() => process.WaitForExit(timeout));
    }

    public struct ProcessResult
    {
        public bool Completed;
        public int? ExitCode;
        public string Output;
    }

    public static void KillProcess(string processName)
    {
        foreach (var p in Process.GetProcesses())
        {
            try
            {
                if (p.ProcessName.IndexOf(ProcNameCfg(processName), StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    p.Kill();
                }
            }
            catch (Exception ex)
            {
                MyMessage.MsgShowError(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }

    public static string ProcNameCfg(string cfgName)
    {
        return cfgName.Substring(cfgName.LastIndexOf("\\", StringComparison.Ordinal) + 1,
            cfgName.LastIndexOf(".", StringComparison.Ordinal) - 1 - cfgName.LastIndexOf("\\", StringComparison.Ordinal));
    }

    private void UpCount(MyEnum.LogType type)
    {
        switch (type)
        {
            case MyEnum.LogType.ErrorChar:
                Program.FrmMain.ErrorAll += 1;
                Program.FrmMain.ErrorChar += 1;
                break;

            case MyEnum.LogType.ErrorMap:
                Program.FrmMain.ErrorAll += 1;
                Program.FrmMain.ErrorMap += 1;
                break;

            case MyEnum.LogType.ErrorLogin:
                Program.FrmMain.ErrorAll += 1;
                Program.FrmMain.ErrorLogin += 1;
                break;

            case MyEnum.LogType.Warning:
                Program.FrmMain.Warning += 1;
                break;

            case MyEnum.LogType.SQL:
                Program.FrmMain.Sql += 1;
                break;

            case MyEnum.LogType.Debug:
                Program.FrmMain.IDebug += 1;
                break;
        }
    }

    private void UpLogs(MyEnum.LogType type, string value)
    {
        var result = value + Environment.NewLine;
        switch (type)
        {
            case MyEnum.LogType.ErrorChar:
                PublicClass.LogErrorAll += result;
                PublicClass.LogErrorChar += result;
                break;

            case MyEnum.LogType.ErrorMap:
                PublicClass.LogErrorAll += result;
                PublicClass.LogErrorMap += result;
                break;

            case MyEnum.LogType.ErrorLogin:
                PublicClass.LogErrorAll += result;
                PublicClass.LogErrorLogin += result;
                break;

            case MyEnum.LogType.Warning:
                PublicClass.LogWarning += result;
                break;

            case MyEnum.LogType.SQL:
                PublicClass.LogSql += result;
                break;

            case MyEnum.LogType.Debug:
                PublicClass.LogDebug += result;
                break;
        }
    }

    private static void WriteLogs(MyEnum.LogType type, MyEnum.ConsoleType consoleType, string value)
    {
        if (value.Contains("Loading")) return;
        var txtLog = type switch
        {
            MyEnum.LogType.ErrorChar => Program.FrmMain.txtChar,
            MyEnum.LogType.ErrorMap => Program.FrmMain.txtMap,
            MyEnum.LogType.ErrorLogin => Program.FrmMain.txtLogin,
            MyEnum.LogType.Web => Program.FrmMain.txtWeb,
            _ => new RichTextBox()
        };
        var color = consoleType switch
        {
            MyEnum.ConsoleType.Status => PublicClass.MySettings.Status,
            MyEnum.ConsoleType.Info => PublicClass.MySettings.Info,
            MyEnum.ConsoleType.Notice => PublicClass.MySettings.Notice,
            MyEnum.ConsoleType.Warning => PublicClass.MySettings.Warning,
            MyEnum.ConsoleType.Sql => PublicClass.MySettings.Sql,
            MyEnum.ConsoleType.Debug => PublicClass.MySettings.Debug,
            MyEnum.ConsoleType.Error => PublicClass.MySettings.Error,
            _ => Color.Gainsboro
        };
        if (consoleType != MyEnum.ConsoleType.Other)
        {
            var header = $"[{consoleType}]";
            var newEData = value.Remove(0, header.Length);
            txtLog.Invoke(delegate
            {
                txtLog.AppendText(header, color);
                txtLog.AppendText(newEData + Environment.NewLine);
            });
            return;
        }

        txtLog.Invoke(delegate
        {
            txtLog.AppendText(value + Environment.NewLine);
        });
    }
}