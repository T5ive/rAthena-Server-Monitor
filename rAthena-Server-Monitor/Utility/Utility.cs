namespace rAthena_Server_Monitor;

public static class Utility
{
    public static bool Starts(this string name, string value)
    {
        return name.StartsWith(value, StringComparison.CurrentCultureIgnoreCase);
    }
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }

    public static string CurrentVersion()
    {
        return Assembly.GetExecutingAssembly().GetName().Version?.ToString();
    }
}