namespace rAthena_Server_Monitor;

public class AppSettings : JsonHelper<AppSettings>
{
    public bool ColorMode { get; set; } = true;
    public bool ColorOldRev { get; set; }

    public Color Status { get; set; } = Color.Lime;
    public Color Info { get; set; } = Color.White;
    public Color Notice { get; set; } = Color.White;
    public Color Warning { get; set; } = Color.Yellow;
    public Color Sql { get; set; } = Color.PaleVioletRed;
    public Color Debug { get; set; } = Color.Cyan;
    public Color Error { get; set; } = Color.Red;

    public string LoginExePath { get; set; } = "./login-server.exe";
    public string CharExePath { get; set; } = "./char-server.exe";
    public string MapExePath { get; set; } = "./map-server.exe";
    public string WebExePath { get; set; } = "./web-server.exe";

    public bool WebExe { get; set; }
}

public class JsonHelper<T> where T : new()
{
    private const string DefaultFilename = "settings.json";

    public void Save(string fileName = DefaultFilename)
    {
        File.WriteAllText(fileName, JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented));
    }

    public static T Load(string fileName = DefaultFilename)
    {
        var t = new T();
        if (File.Exists(fileName))
            t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
        return t;
    }
}