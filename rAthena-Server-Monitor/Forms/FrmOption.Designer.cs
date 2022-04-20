namespace rAthena_Server_Monitor
{
    partial class FrmOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbDebug = new System.Windows.Forms.Label();
            this.lbSQL = new System.Windows.Forms.Label();
            this.lbNotice = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login: ";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(65, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(231, 23);
            this.txtLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(302, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(30, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "...";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(302, 41);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(30, 23);
            this.btnChar.TabIndex = 5;
            this.btnChar.Text = "...";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(65, 41);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(231, 23);
            this.txtChar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Char: ";
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(302, 70);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(30, 23);
            this.btnMap.TabIndex = 8;
            this.btnMap.Text = "...";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(65, 70);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(231, 23);
            this.txtMap.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Map: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Controls.Add(this.lbWarning);
            this.groupBox1.Controls.Add(this.lbDebug);
            this.groupBox1.Controls.Add(this.lbSQL);
            this.groupBox1.Controls.Add(this.lbNotice);
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console Color Settings";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbWarning.Location = new System.Drawing.Point(108, 19);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(60, 15);
            this.lbWarning.TabIndex = 6;
            this.lbWarning.Text = "[Warning]";
            this.lbWarning.Click += new System.EventHandler(this.AllLabelClick);
            // 
            // lbDebug
            // 
            this.lbDebug.AutoSize = true;
            this.lbDebug.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDebug.Location = new System.Drawing.Point(216, 19);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(50, 15);
            this.lbDebug.TabIndex = 5;
            this.lbDebug.Text = "[Debug]";
            this.lbDebug.Click += new System.EventHandler(this.AllLabelClick);
            // 
            // lbSQL
            // 
            this.lbSQL.AutoSize = true;
            this.lbSQL.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSQL.Location = new System.Drawing.Point(174, 19);
            this.lbSQL.Name = "lbSQL";
            this.lbSQL.Size = new System.Drawing.Size(36, 15);
            this.lbSQL.TabIndex = 4;
            this.lbSQL.Text = "[SQL]";
            this.lbSQL.Click += new System.EventHandler(this.AllLabelClick);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNotice.Location = new System.Drawing.Point(9, 41);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(50, 15);
            this.lbNotice.TabIndex = 3;
            this.lbNotice.Text = "[Notice]";
            this.lbNotice.Click += new System.EventHandler(this.AllLabelClick);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbInfo.Location = new System.Drawing.Point(272, 19);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(36, 15);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "[Info]";
            this.lbInfo.Click += new System.EventHandler(this.AllLabelClick);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbError.Location = new System.Drawing.Point(62, 19);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(40, 15);
            this.lbError.TabIndex = 1;
            this.lbError.Text = "[Error]";
            this.lbError.Click += new System.EventHandler(this.AllLabelClick);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStatus.Location = new System.Drawing.Point(9, 19);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(47, 15);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "[Status]";
            this.lbStatus.Click += new System.EventHandler(this.AllLabelClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(255, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(273, 221);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Enabled = false;
            this.btnWeb.Location = new System.Drawing.Point(302, 99);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(30, 23);
            this.btnWeb.TabIndex = 14;
            this.btnWeb.Text = "...";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.Enabled = false;
            this.txtWeb.Location = new System.Drawing.Point(65, 99);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(231, 23);
            this.txtWeb.TabIndex = 13;
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Location = new System.Drawing.Point(6, 101);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(53, 19);
            this.chkWeb.TabIndex = 15;
            this.chkWeb.Text = "Web:";
            this.chkWeb.UseVisualStyleBackColor = true;
            this.chkWeb.CheckedChanged += new System.EventHandler(this.chkWeb_CheckedChanged);
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 256);
            this.Controls.Add(this.chkWeb);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.txtMap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private Button btnLogin;
        private Button btnChar;
        private TextBox txtChar;
        private Label label2;
        private Button btnMap;
        private TextBox txtMap;
        private Label label3;
        private GroupBox groupBox1;
        private Label lbWarning;
        private Label lbDebug;
        private Label lbSQL;
        private Label lbNotice;
        private Label lbInfo;
        private Label lbError;
        private Label lbStatus;
        private Button btnSave;
        private Button btnReset;
        private Button btnWeb;
        private TextBox txtWeb;
        private CheckBox chkWeb;
    }
}