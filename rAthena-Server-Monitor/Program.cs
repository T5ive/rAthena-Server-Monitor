global using Newtonsoft.Json;
global using rAthena_Server_Monitor.Helper;
global using rAthena_Server_Monitor.Properties;
global using System.Diagnostics;
global using System.Reflection;
global using System.Text;

namespace rAthena_Server_Monitor;

internal static class Program
{
    public static FrmMain FrmMain;
    public static FrmLog FrmLog = new FrmLog();

    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        PublicClass.MySettings = AppSettings.Load();
        Application.Run(FrmMain = new FrmMain());
    }
}