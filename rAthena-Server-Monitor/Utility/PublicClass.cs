namespace rAthena_Server_Monitor;

public class PublicClass
{
    public static ProcessHelper ProcessHelper = new ProcessHelper();
    public static AppSettings MySettings { get; set; }
    public static MyEnum.LogType LogType;
    public static string LogErrorAll, LogErrorMap, LogErrorLogin, LogErrorChar, LogWarning, LogSql, LogDebug;
}