using System;
using System.Drawing;
using System.Windows.Forms;
using Server_Viewer.Class;

namespace Server_Viewer
{
    public static class Handler
    {
        #region Variable
    
        public static bool ColorMode = true;
        public static bool ColorOldRev;

        public static Color Status = Color.Lime;
        public static Color Info = Color.White;
        public static Color Notice = Color.White;
        public static Color Warning = Color.Yellow;
        public static Color Sql = Color.PaleVioletRed;
        public static Color Debug = Color.Cyan;
        public static Color Error = Color.Red;

        public static Color SStatus = Color.Lime;
        public static Color SInfo = Color.White;
        public static Color SNotice = Color.White;
        public static Color SWarning = Color.Yellow;
        public static Color SSql = Color.PaleVioletRed;
        public static Color SDebug = Color.Cyan;
        public static Color SError = Color.Red;

        public static string LoginExePath = "/debug/location.exe";
        public static string CharExePath = "/debug/location.exe";
        public static string MapExePath = "/debug/location.exe";

        #endregion

        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }


        public static void IniCreate()
        {
            var ini = new IniFile(Application.StartupPath + @"\SM_config.ini");
            ini.IniWriteValue("path", "login", "login-server.exe");
            ini.IniWriteValue("path", "char", "char-server.exe");
            ini.IniWriteValue("path", "map", "map-server.exe");

            ini.IniWriteValue("color", "usecolor", "true");
            ini.IniWriteValue("color", "oldrev", "false");
            ini.IniWriteValue("color", "color-status", "124,252,0");
            ini.IniWriteValue("color", "color-info", "255,255,255");
            ini.IniWriteValue("color", "color-notice", "255,255,255");
            ini.IniWriteValue("color", "color-warning", "255,255,0");
            ini.IniWriteValue("color", "color-error", "255,0,0");
            ini.IniWriteValue("color", "color-sql", "208,32,144");
            ini.IniWriteValue("color", "color-debug", "0,255,255");
            IniRead();
        }


        public static void IniRead()
        {
            var ini = new IniFile(Application.StartupPath + @"\SM_config.ini");
            LoginExePath = ini.IniReadValue("path", "login");
            CharExePath = ini.IniReadValue("path", "char");
            MapExePath = ini.IniReadValue("path", "map");

            ColorMode = Convert.ToBoolean(ini.IniReadValue("color", "usecolor"));
            ColorOldRev = Convert.ToBoolean(ini.IniReadValue("color", "oldrev"));

            string[] colorRgb;

            #region Get Color INI
            try
            {
                colorRgb = ini.IniReadValue("color", "color-status").Split(',');
                Status = Color.FromArgb(255, Convert.ToInt32(colorRgb[0]), Convert.ToInt32(colorRgb[1]), Convert.ToInt32(colorRgb[2]));
            }
            catch
            {
                Status = SStatus;
            }

            try
            {
                colorRgb = ini.IniReadValue("color", "color-info").Split(',');
                Info = Color.FromArgb(255, Convert.ToInt32(colorRgb[0]), Convert.ToInt32(colorRgb[1]), Convert.ToInt32(colorRgb[2]));
            }
            catch
            {
                Info = SInfo;
            }

            try
            {
                colorRgb = ini.IniReadValue("color", "color-notice").Split(',');
                Notice = Color.FromArgb(255, Convert.ToInt32(colorRgb[0]), Convert.ToInt32(colorRgb[1]), Convert.ToInt32(colorRgb[2]));
            }
            catch
            {
                Notice = SNotice;
            }

            try
            {
                colorRgb = ini.IniReadValue("color", "color-warning").Split(',');
                Warning = Color.FromArgb(255, Convert.ToInt32(colorRgb[0]), Convert.ToInt32(colorRgb[1]), Convert.ToInt32(colorRgb[2]));
            }
            catch
            {
                Warning = SWarning;
            }

            try
            {
                colorRgb = ini.IniReadValue("color", "color-error").Split(',');
                Error = Color.FromArgb(255, Convert.ToInt32(colorRgb[0]), Convert.ToInt32(colorRgb[1]), Convert.ToInt32(colorRgb[2]));
            }
            catch
            {
                Error = SError;
            }

            try
            {
                colorRgb = ini.IniReadValue("color", "color-sql").Split(',');
                Sql = Color.FromArgb(255, Convert.ToInt32(colorRgb[0]), Convert.ToInt32(colorRgb[1]), Convert.ToInt32(colorRgb[2]));
            }
            catch
            {
                Sql = SSql;
            }

            try
            {
                colorRgb = ini.IniReadValue("color", "color-debug").Split(',');
                Debug = Color.FromArgb(255, Convert.ToInt32(colorRgb[0]), Convert.ToInt32(colorRgb[1]), Convert.ToInt32(colorRgb[2]));
            }
            catch
            {
                Debug = SDebug;
            }
            #endregion

        }

        public static void SaveOpt()
        {
            var ini = new IniFile(Application.StartupPath + @"\SM_config.ini");
            ini.IniWriteValue("path", "login", LoginExePath);
            ini.IniWriteValue("path", "char", CharExePath);
            ini.IniWriteValue("path", "map", MapExePath);
            ini.IniWriteValue("color", "usecolor", Convert.ToString(ColorMode));
            ini.IniWriteValue("color", "oldrev", Convert.ToString(ColorOldRev));
            ini.IniWriteValue("color", "color-status", Status.R + "," + Status.G + "," + Status.B);
            ini.IniWriteValue("color", "color-info", Info.R + "," + Info.G + "," + Info.B);
            ini.IniWriteValue("color", "color-notice", Notice.R + "," + Notice.G + "," + Notice.B);
            ini.IniWriteValue("color", "color-warning", Warning.R + "," + Warning.G + "," + Warning.B);
            ini.IniWriteValue("color", "color-error", Error.R + "," + Error.G + "," + Error.B);
            ini.IniWriteValue("color", "color-sql", Sql.R + "," + Sql.G + "," + Sql.B);
            ini.IniWriteValue("color", "color-debug", Debug.R + "," + Debug.G + "," + Debug.B);
        }
    }
}