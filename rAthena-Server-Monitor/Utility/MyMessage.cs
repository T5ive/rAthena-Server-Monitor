namespace rAthena_Server_Monitor;

public static class MyMessage
{
    private const string Caption = "rAthena Server Monitor";

    public static void MsgShowError(string text)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void MsgShowWarning(string text)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void MsgShowInfo(string text)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void MsgShow(string text, MessageBoxIcon icon = MessageBoxIcon.None)
    {
        MessageBox.Show(text, Caption, MessageBoxButtons.OK, icon);
    }

    public static bool MsgOkCancel(string text)
    {
        return MessageBox.Show(text, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
    }

    public static DialogResult MsgYesNoCancel(string text)
    {
        return MessageBox.Show(text, Caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
    }
}