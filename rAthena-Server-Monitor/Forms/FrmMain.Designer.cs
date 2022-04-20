namespace rAthena_Server_Monitor
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtChar = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLogin = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMap = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtWeb = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.errorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.char0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.map0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.all0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(584, 452);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtChar);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Char Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtChar
            // 
            this.txtChar.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtChar.Location = new System.Drawing.Point(3, 3);
            this.txtChar.Name = "txtChar";
            this.txtChar.ReadOnly = true;
            this.txtChar.Size = new System.Drawing.Size(570, 418);
            this.txtChar.TabIndex = 5;
            this.txtChar.Text = "Char Server... Waiting... ";
            this.txtChar.TextChanged += new System.EventHandler(this.All_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtLogin);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Login Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtLogin.Location = new System.Drawing.Point(3, 3);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(570, 418);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "Login Server... Waiting... ";
            this.txtLogin.TextChanged += new System.EventHandler(this.All_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMap);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMap
            // 
            this.txtMap.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMap.Location = new System.Drawing.Point(3, 3);
            this.txtMap.Name = "txtMap";
            this.txtMap.ReadOnly = true;
            this.txtMap.Size = new System.Drawing.Size(570, 418);
            this.txtMap.TabIndex = 7;
            this.txtMap.Text = "Map Server... Waiting... ";
            this.txtMap.TextChanged += new System.EventHandler(this.All_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtWeb);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(576, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Web Service";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtWeb
            // 
            this.txtWeb.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWeb.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtWeb.Location = new System.Drawing.Point(3, 3);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.ReadOnly = true;
            this.txtWeb.Size = new System.Drawing.Size(570, 418);
            this.txtWeb.TabIndex = 8;
            this.txtWeb.Text = "Web Service... Waiting... ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.errorToolStripMenuItem,
            this.warningToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.onlineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator6,
            this.optionToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(108, 6);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // errorToolStripMenuItem
            // 
            this.errorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.toolStripSeparator1,
            this.allToolStripMenuItem});
            this.errorToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.errorToolStripMenuItem.Name = "errorToolStripMenuItem";
            this.errorToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.errorToolStripMenuItem.Text = "Error: 0";
            // 
            // charToolStripMenuItem
            // 
            this.charToolStripMenuItem.Name = "charToolStripMenuItem";
            this.charToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.charToolStripMenuItem.Text = "Char: 0";
            this.charToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login: 0";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mapToolStripMenuItem.Text = "Map: 0";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All: 0";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // warningToolStripMenuItem
            // 
            this.warningToolStripMenuItem.ForeColor = System.Drawing.Color.Olive;
            this.warningToolStripMenuItem.Name = "warningToolStripMenuItem";
            this.warningToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.warningToolStripMenuItem.Text = "Warning: 0";
            this.warningToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sQLToolStripMenuItem.Text = "SQL: 0";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.debugToolStripMenuItem.Text = "Debug: 0";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.onlineToolStripMenuItem.Text = "Online: 0";
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Location = new System.Drawing.Point(0, 476);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(584, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripSeparator2,
            this.startToolStripMenuItem,
            this.optionToolStripMenuItem1,
            this.informationToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 170);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.optionToolStripMenuItem1.Text = "Option";
            this.optionToolStripMenuItem1.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineToolStripMenuItem1,
            this.toolStripSeparator4,
            this.errorToolStripMenuItem1,
            this.warningToolStripMenuItem1,
            this.sQLToolStripMenuItem1,
            this.debugToolStripMenuItem1});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // onlineToolStripMenuItem1
            // 
            this.onlineToolStripMenuItem1.Name = "onlineToolStripMenuItem1";
            this.onlineToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.onlineToolStripMenuItem1.Text = "Online: 0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // errorToolStripMenuItem1
            // 
            this.errorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.char0ToolStripMenuItem,
            this.login0ToolStripMenuItem,
            this.map0ToolStripMenuItem,
            this.toolStripSeparator5,
            this.all0ToolStripMenuItem});
            this.errorToolStripMenuItem1.Name = "errorToolStripMenuItem1";
            this.errorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.errorToolStripMenuItem1.Text = "Error: 0";
            // 
            // char0ToolStripMenuItem
            // 
            this.char0ToolStripMenuItem.Name = "char0ToolStripMenuItem";
            this.char0ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.char0ToolStripMenuItem.Text = "Char: 0";
            this.char0ToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // login0ToolStripMenuItem
            // 
            this.login0ToolStripMenuItem.Name = "login0ToolStripMenuItem";
            this.login0ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.login0ToolStripMenuItem.Text = "Login: 0";
            this.login0ToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // map0ToolStripMenuItem
            // 
            this.map0ToolStripMenuItem.Name = "map0ToolStripMenuItem";
            this.map0ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.map0ToolStripMenuItem.Text = "Map: 0";
            this.map0ToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // all0ToolStripMenuItem
            // 
            this.all0ToolStripMenuItem.Name = "all0ToolStripMenuItem";
            this.all0ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.all0ToolStripMenuItem.Text = "All: 0";
            this.all0ToolStripMenuItem.Click += new System.EventHandler(this.AllLogs);
            // 
            // warningToolStripMenuItem1
            // 
            this.warningToolStripMenuItem1.Name = "warningToolStripMenuItem1";
            this.warningToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.warningToolStripMenuItem1.Text = "Warning: 0";
            this.warningToolStripMenuItem1.Click += new System.EventHandler(this.AllLogs);
            // 
            // sQLToolStripMenuItem1
            // 
            this.sQLToolStripMenuItem1.Name = "sQLToolStripMenuItem1";
            this.sQLToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sQLToolStripMenuItem1.Text = "SQL: 0";
            this.sQLToolStripMenuItem1.Click += new System.EventHandler(this.AllLogs);
            // 
            // debugToolStripMenuItem1
            // 
            this.debugToolStripMenuItem1.Name = "debugToolStripMenuItem1";
            this.debugToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.debugToolStripMenuItem1.Text = "Debug: 0";
            this.debugToolStripMenuItem1.Click += new System.EventHandler(this.AllLogs);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "rAthena Server Monitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FrmMain";
            this.Text = "rAthena Server Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.tabMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem onlineToolStripMenuItem;
        private ToolStripMenuItem errorToolStripMenuItem;
        private ToolStripMenuItem warningToolStripMenuItem;
        private ToolStripMenuItem sQLToolStripMenuItem;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripMenuItem charToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private Button btnStart;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ContextMenuStrip contextMenuStrip1;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem optionToolStripMenuItem1;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem onlineToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem errorToolStripMenuItem1;
        private ToolStripMenuItem char0ToolStripMenuItem;
        private ToolStripMenuItem login0ToolStripMenuItem;
        private ToolStripMenuItem map0ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem all0ToolStripMenuItem;
        private ToolStripMenuItem warningToolStripMenuItem1;
        private ToolStripMenuItem sQLToolStripMenuItem1;
        private ToolStripMenuItem debugToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem1;
        public RichTextBox txtMap;
        public RichTextBox txtChar;
        public RichTextBox txtLogin;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem optionToolStripMenuItem;
        private TabPage tabPage4;
        public RichTextBox txtWeb;
    }
}