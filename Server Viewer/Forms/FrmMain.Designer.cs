namespace Server_Viewer.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbSql = new System.Windows.Forms.Label();
            this.lbDebug = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.LoginLog = new System.Windows.Forms.RichTextBox();
            this.CharLog = new System.Windows.Forms.RichTextBox();
            this.MapLog = new System.Windows.Forms.RichTextBox();
            this.btnOption = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbMinimize = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.traycon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcControl = new System.Windows.Forms.ToolStripMenuItem();
            this.tcOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tcInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tcPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tcError = new System.Windows.Forms.ToolStripMenuItem();
            this.tcWarning = new System.Windows.Forms.ToolStripMenuItem();
            this.tcSql = new System.Windows.Forms.ToolStripMenuItem();
            this.tcDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.tcAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tcExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnError = new System.Windows.Forms.Button();
            this.panelUser.SuspendLayout();
            this.traycon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.BackColor = System.Drawing.Color.Transparent;
            this.lbWarning.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbWarning.Location = new System.Drawing.Point(43, 49);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(50, 13);
            this.lbWarning.TabIndex = 33;
            this.lbWarning.Text = "Warning:";
            this.lbWarning.TextChanged += new System.EventHandler(this.lbWarnings_TextChanged);
            // 
            // lbUsers
            // 
            this.lbUsers.BackColor = System.Drawing.Color.Transparent;
            this.lbUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUsers.Location = new System.Drawing.Point(0, 0);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(51, 19);
            this.lbUsers.TabIndex = 32;
            this.lbUsers.Text = "0";
            this.lbUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUsers.TextChanged += new System.EventHandler(this.lbUsers_TextChanged);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(214, 49);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(32, 13);
            this.lbError.TabIndex = 31;
            this.lbError.Text = "Error:";
            this.lbError.TextChanged += new System.EventHandler(this.lbError_TextChanged);
            // 
            // lbSql
            // 
            this.lbSql.AutoSize = true;
            this.lbSql.BackColor = System.Drawing.Color.Transparent;
            this.lbSql.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbSql.Location = new System.Drawing.Point(477, 49);
            this.lbSql.Name = "lbSql";
            this.lbSql.Size = new System.Drawing.Size(31, 13);
            this.lbSql.TabIndex = 30;
            this.lbSql.Text = "SQL:";
            this.lbSql.TextChanged += new System.EventHandler(this.lbSql_TextChanged);
            // 
            // lbDebug
            // 
            this.lbDebug.AutoSize = true;
            this.lbDebug.BackColor = System.Drawing.Color.Transparent;
            this.lbDebug.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbDebug.Location = new System.Drawing.Point(658, 49);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(42, 13);
            this.lbDebug.TabIndex = 29;
            this.lbDebug.Text = "Debug:";
            this.lbDebug.TextChanged += new System.EventHandler(this.lbDebug_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Location = new System.Drawing.Point(28, 467);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnRunServer);
            // 
            // LoginLog
            // 
            this.LoginLog.BackColor = System.Drawing.SystemColors.ControlText;
            this.LoginLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.LoginLog.Location = new System.Drawing.Point(211, 127);
            this.LoginLog.Name = "LoginLog";
            this.LoginLog.ReadOnly = true;
            this.LoginLog.Size = new System.Drawing.Size(512, 138);
            this.LoginLog.TabIndex = 39;
            this.LoginLog.Text = "Login Server... Waiting... ";
            this.LoginLog.TextChanged += new System.EventHandler(this.LoginLog_TextChanged);
            // 
            // CharLog
            // 
            this.CharLog.BackColor = System.Drawing.SystemColors.ControlText;
            this.CharLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.CharLog.Location = new System.Drawing.Point(211, 271);
            this.CharLog.Name = "CharLog";
            this.CharLog.ReadOnly = true;
            this.CharLog.Size = new System.Drawing.Size(512, 138);
            this.CharLog.TabIndex = 40;
            this.CharLog.Text = "Char Server... Waiting... ";
            this.CharLog.TextChanged += new System.EventHandler(this.CharLog_TextChanged);
            // 
            // MapLog
            // 
            this.MapLog.BackColor = System.Drawing.SystemColors.ControlText;
            this.MapLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.MapLog.Location = new System.Drawing.Point(211, 415);
            this.MapLog.Name = "MapLog";
            this.MapLog.ReadOnly = true;
            this.MapLog.Size = new System.Drawing.Size(512, 138);
            this.MapLog.TabIndex = 41;
            this.MapLog.Text = "Map Server... Waiting... ";
            this.MapLog.TextChanged += new System.EventHandler(this.MapLog_TextChanged);
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOption.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnOption.Location = new System.Drawing.Point(85, 513);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(120, 40);
            this.btnOption.TabIndex = 42;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Location = new System.Drawing.Point(709, 69);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(14, 13);
            this.lbClose.TabIndex = 43;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // lbMinimize
            // 
            this.lbMinimize.AutoSize = true;
            this.lbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lbMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinimize.Location = new System.Drawing.Point(697, 68);
            this.lbMinimize.Name = "lbMinimize";
            this.lbMinimize.Size = new System.Drawing.Size(12, 16);
            this.lbMinimize.TabIndex = 44;
            this.lbMinimize.Text = "-";
            this.lbMinimize.Click += new System.EventHandler(this.lbMinimize_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(56, 130);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(37, 13);
            this.lbVersion.TabIndex = 45;
            this.lbVersion.Text = "v2.2.6";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Transparent;
            this.panelUser.Controls.Add(this.lbUsers);
            this.panelUser.Location = new System.Drawing.Point(349, 34);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(51, 19);
            this.panelUser.TabIndex = 46;
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.ContextMenuStrip = this.traycon;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Server Monitor";
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // traycon
            // 
            this.traycon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcRestore,
            this.toolStripSeparator1,
            this.tcControl,
            this.tcOptions,
            this.tcInfo,
            this.tcAbout,
            this.tcExit});
            this.traycon.Name = "traycon";
            this.traycon.Size = new System.Drawing.Size(138, 142);
            // 
            // tcRestore
            // 
            this.tcRestore.Name = "tcRestore";
            this.tcRestore.Size = new System.Drawing.Size(137, 22);
            this.tcRestore.Text = "Restore";
            this.tcRestore.Click += new System.EventHandler(this.tcRestore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // tcControl
            // 
            this.tcControl.Name = "tcControl";
            this.tcControl.Size = new System.Drawing.Size(137, 22);
            this.tcControl.Text = "Start";
            this.tcControl.Click += new System.EventHandler(this.tcControl_Click);
            // 
            // tcOptions
            // 
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.Size = new System.Drawing.Size(137, 22);
            this.tcOptions.Text = "Options";
            this.tcOptions.Click += new System.EventHandler(this.tc_options_Click);
            // 
            // tcInfo
            // 
            this.tcInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcPlayer,
            this.toolStripSeparator2,
            this.tcError,
            this.tcWarning,
            this.tcSql,
            this.tcDebug});
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.Size = new System.Drawing.Size(137, 22);
            this.tcInfo.Text = "Information";
            // 
            // tcPlayer
            // 
            this.tcPlayer.Name = "tcPlayer";
            this.tcPlayer.Size = new System.Drawing.Size(131, 22);
            this.tcPlayer.Text = "Players: 0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // tcError
            // 
            this.tcError.Name = "tcError";
            this.tcError.Size = new System.Drawing.Size(131, 22);
            this.tcError.Text = "Error: 0";
            // 
            // tcWarning
            // 
            this.tcWarning.Name = "tcWarning";
            this.tcWarning.Size = new System.Drawing.Size(131, 22);
            this.tcWarning.Text = "Warning: 0";
            // 
            // tcSql
            // 
            this.tcSql.Name = "tcSql";
            this.tcSql.Size = new System.Drawing.Size(131, 22);
            this.tcSql.Text = "SQL: 0";
            // 
            // tcDebug
            // 
            this.tcDebug.Name = "tcDebug";
            this.tcDebug.Size = new System.Drawing.Size(131, 22);
            this.tcDebug.Text = "Debug: 0";
            // 
            // tcAbout
            // 
            this.tcAbout.Name = "tcAbout";
            this.tcAbout.Size = new System.Drawing.Size(137, 22);
            this.tcAbout.Text = "About";
            this.tcAbout.Click += new System.EventHandler(this.tcAbout_Click);
            // 
            // tcExit
            // 
            this.tcExit.Name = "tcExit";
            this.tcExit.Size = new System.Drawing.Size(137, 22);
            this.tcExit.Text = "Exit";
            this.tcExit.Click += new System.EventHandler(this.tcExit_Click);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(191)))), ((int)(((byte)(62)))));
            this.btnError.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnError.ForeColor = System.Drawing.Color.White;
            this.btnError.Location = new System.Drawing.Point(646, 99);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(77, 22);
            this.btnError.TabIndex = 49;
            this.btnError.Text = "Error Log";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.lbMinimize);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.MapLog);
            this.Controls.Add(this.CharLog);
            this.Controls.Add(this.LoginLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbSql);
            this.Controls.Add(this.lbDebug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Monitor";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panelUser.ResumeLayout(false);
            this.traycon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbSql;
        private System.Windows.Forms.Label lbDebug;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox LoginLog;
        private System.Windows.Forms.RichTextBox CharLog;
        private System.Windows.Forms.RichTextBox MapLog;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbMinimize;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip traycon;
        private System.Windows.Forms.ToolStripMenuItem tcControl;
        private System.Windows.Forms.ToolStripMenuItem tcInfo;
        private System.Windows.Forms.ToolStripMenuItem tcWarning;
        private System.Windows.Forms.ToolStripMenuItem tcError;
        private System.Windows.Forms.ToolStripMenuItem tcSql;
        private System.Windows.Forms.ToolStripMenuItem tcDebug;
        private System.Windows.Forms.ToolStripMenuItem tcAbout;
        private System.Windows.Forms.ToolStripMenuItem tcRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tcOptions;
        private System.Windows.Forms.ToolStripMenuItem tcPlayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tcExit;
        private System.Windows.Forms.Button btnError;
    }
}

