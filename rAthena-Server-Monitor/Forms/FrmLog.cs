namespace rAthena_Server_Monitor;

public partial class FrmLog : Form
{
    public FrmLog()
    {
        InitializeComponent();
    }

    private void FrmLog_Shown(object sender, EventArgs e)
    {
        LoadValue();
    }

    private void LoadValue()
    {
        var value = PublicClass.LogType switch
        {
            MyEnum.LogType.ErrorAll => PublicClass.LogErrorAll,
            MyEnum.LogType.ErrorChar => PublicClass.LogErrorChar,
            MyEnum.LogType.ErrorMap => PublicClass.LogErrorMap,
            MyEnum.LogType.ErrorLogin => PublicClass.LogErrorLogin,
            MyEnum.LogType.Warning => PublicClass.LogWarning,
            MyEnum.LogType.SQL => PublicClass.LogSql,
            MyEnum.LogType.Debug => PublicClass.LogDebug,
            _ => ""
        };

        txtLog.Text = value;
        Text = "Log - " + PublicClass.LogType.TypeString();
    }

    public void UpdateValue()
    {
        LoadValue();
    }

    private void FrmLog_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        Hide();
    }
}