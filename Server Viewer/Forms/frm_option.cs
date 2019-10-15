using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Server_Viewer;
using System.IO;

namespace Server_Viewer.forms
{
    public partial class frm_option : Form
    {
        public frm_option()
        {
            InitializeComponent();
        }

        TextDatei c_textdatei = new TextDatei();
        string configmainpath = Application.StartupPath + @"\ServerMonitor.txt";

        private void bt_loginpath_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Login (*.exe)|*.exe|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;
                Handler.LoginExePath = Pfad;
                this.tb_loginpath.Text = Pfad;
            }
        }

        private void bt_charpath_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Char (*.exe)|*.exe|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;
                Handler.CharExePath = Pfad;
                this.tb_charpath.Text = Pfad;
            }
        }

        private void bt_mappath_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Map (*.exe)|*.exe|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;
                Handler.MapExePath = Pfad;
                this.tb_mappath.Text = Pfad;
            }
        }

        private void start_Load(object sender, EventArgs e)
        {
            lb_status.ForeColor = Handler.Status;
            lb_debug.ForeColor = Handler.Debug;
            lb_error.ForeColor = Handler.Error;
            lb_info.ForeColor = Handler.Info;
            lb_notice.ForeColor = Handler.Notice;
            lb_sql.ForeColor = Handler.Sql;
            lb_warning.ForeColor = Handler.Warning;

            lb_status.BackColor = Color.Transparent;
            lb_debug.BackColor = Color.Transparent;
            lb_error.BackColor = Color.Transparent;
            lb_info.BackColor = Color.Transparent;
            lb_notice.BackColor = Color.Transparent;
            lb_sql.BackColor = Color.Transparent;
            lb_warning.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            gb_color.BackColor = Color.Transparent;

            tb_loginpath.Text = Handler.LoginExePath;
            tb_charpath.Text = Handler.CharExePath;
            tb_mappath.Text = Handler.CharExePath;

            if (Handler.ColorMode)
                cb_coloronoff.Checked = true;

            if (Handler.ColorOldRev)
                cb_oldrev.Checked = true;
        }
        #region buttons and loads
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_coloronoff.Checked)
                Handler.ColorMode = true;
            else
                Handler.ColorMode = false;
        }

        private void cb_oldrev_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_oldrev.Checked)
                Handler.ColorOldRev = true;
            else
                Handler.ColorOldRev = false;
        }

        private void lb_status_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_status.ForeColor = colorDlg.Color;
            Handler.Status = colorDlg.Color;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_okey_Click(object sender, EventArgs e)
        {
            Handler.SaveOpt();
            Close();
        }

        private void lb_warning_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_warning.ForeColor = colorDlg.Color;
            Handler.Warning = colorDlg.Color;
        }

        private void lb_error_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_error.ForeColor = colorDlg.Color;
            Handler.Error = colorDlg.Color;
        }

        private void lb_info_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_info.ForeColor = colorDlg.Color;
            Handler.Info = colorDlg.Color;
        }

        private void lb_notice_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_notice.ForeColor = colorDlg.Color;
            Handler.Notice = colorDlg.Color;
        }

        private void lb_sql_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_sql.ForeColor = colorDlg.Color;
            Handler.Sql = colorDlg.Color;
        }

        private void lb_debug_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
            lb_debug.ForeColor = colorDlg.Color;
            Handler.Debug = colorDlg.Color;
        }
        #endregion

        private void frm_option_FormClosing(object sender, FormClosingEventArgs e)
        {
            Handler.OpenOpt = false;
        }
    }
}
