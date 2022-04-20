namespace rAthena_Server_Monitor;

public static class MyEnum
{
    public enum ConsoleType
    {
        Status,
        Info,
        Notice,
        Warning,
        Sql,
        Debug,
        Error,
        Other
    }

    public enum LogType
    {
        ErrorAll,
        ErrorMap,
        ErrorChar,
        ErrorLogin,
        Warning,
        SQL,
        Debug,
        Web
    }

    public static string TypeString(this LogType type)
    {
        return type switch
        {
            LogType.ErrorAll => "Error All",
            LogType.ErrorMap => "Error Map",
            LogType.ErrorChar => "Error Char",
            LogType.ErrorLogin => "Error Login",
            LogType.Warning => type.ToString(),
            LogType.SQL => type.ToString(),
            LogType.Debug => type.ToString(),
            _ => type.ToString()
        };
    }

    public static string ConsoleString(this ConsoleType type)
    {
        return type switch
        {
            ConsoleType.Status => type.ToString(),
            ConsoleType.Info => type.ToString(),
            ConsoleType.Notice => type.ToString(),
            ConsoleType.Warning => type.ToString(),
            ConsoleType.Sql => type.ToString(),
            ConsoleType.Debug => type.ToString(),
            ConsoleType.Error => type.ToString(),
            ConsoleType.Other => "",
            _ => type.ToString()
        };
    }
}