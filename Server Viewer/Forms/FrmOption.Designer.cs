namespace Server_Viewer.Forms
{
    partial class FrmOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOption));
            this.txtLoginPath = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.txtCharPath = new System.Windows.Forms.TextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.txtMapPath = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbChar = new System.Windows.Forms.Label();
            this.lbMap = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDebug = new System.Windows.Forms.Label();
            this.lbSql = new System.Windows.Forms.Label();
            this.lbNotice = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbOldRev = new System.Windows.Forms.CheckBox();
            this.cbColorOnOff = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginPath
            // 
            this.txtLoginPath.Location = new System.Drawing.Point(48, 12);
            this.txtLoginPath.Name = "txtLoginPath";
            this.txtLoginPath.ReadOnly = true;
            this.txtLoginPath.Size = new System.Drawing.Size(242, 20);
            this.txtLoginPath.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(296, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(27, 20);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "...";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(296, 38);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(27, 20);
            this.btnChar.TabIndex = 4;
            this.btnChar.Text = "...";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // txtCharPath
            // 
            this.txtCharPath.Location = new System.Drawing.Point(48, 38);
            this.txtCharPath.Name = "txtCharPath";
            this.txtCharPath.ReadOnly = true;
            this.txtCharPath.Size = new System.Drawing.Size(242, 20);
            this.txtCharPath.TabIndex = 3;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(296, 64);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(27, 20);
            this.btnMap.TabIndex = 6;
            this.btnMap.Text = "...";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // txtMapPath
            // 
            this.txtMapPath.Location = new System.Drawing.Point(48, 64);
            this.txtMapPath.Name = "txtMapPath";
            this.txtMapPath.ReadOnly = true;
            this.txtMapPath.Size = new System.Drawing.Size(242, 20);
            this.txtMapPath.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOk.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnOk.Location = new System.Drawing.Point(9, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 40);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Location = new System.Drawing.Point(6, 15);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(36, 13);
            this.lbLogin.TabIndex = 7;
            this.lbLogin.Text = "Login:";
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.BackColor = System.Drawing.Color.Transparent;
            this.lbChar.Location = new System.Drawing.Point(6, 41);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(32, 13);
            this.lbChar.TabIndex = 8;
            this.lbChar.Text = "Char:";
            // 
            // lbMap
            // 
            this.lbMap.AutoSize = true;
            this.lbMap.BackColor = System.Drawing.Color.Transparent;
            this.lbMap.Location = new System.Drawing.Point(6, 67);
            this.lbMap.Name = "lbMap";
            this.lbMap.Size = new System.Drawing.Size(31, 13);
            this.lbMap.TabIndex = 9;
            this.lbMap.Text = "Map:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCancel.Location = new System.Drawing.Point(170, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Controls.Add(this.lbDebug);
            this.groupBox1.Controls.Add(this.lbSql);
            this.groupBox1.Controls.Add(this.lbNotice);
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.lbWarning);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.cbOldRev);
            this.groupBox1.Controls.Add(this.cbColorOnOff);
            this.groupBox1.Location = new System.Drawing.Point(9, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color settings";
            // 
            // lbDebug
            // 
            this.lbDebug.AutoSize = true;
            this.lbDebug.BackColor = System.Drawing.Color.Transparent;
            this.lbDebug.Location = new System.Drawing.Point(6, 67);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(45, 13);
            this.lbDebug.TabIndex = 8;
            this.lbDebug.Text = "[Debug]";
            this.lbDebug.Click += new System.EventHandler(this.lbDebug_Click);
            // 
            // lbSql
            // 
            this.lbSql.AutoSize = true;
            this.lbSql.BackColor = System.Drawing.Color.Transparent;
            this.lbSql.Location = new System.Drawing.Point(242, 39);
            this.lbSql.Name = "lbSql";
            this.lbSql.Size = new System.Drawing.Size(34, 13);
            this.lbSql.TabIndex = 7;
            this.lbSql.Text = "[SQL]";
            this.lbSql.Click += new System.EventHandler(this.lbSql_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.BackColor = System.Drawing.Color.Transparent;
            this.lbNotice.Location = new System.Drawing.Point(192, 39);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(44, 13);
            this.lbNotice.TabIndex = 6;
            this.lbNotice.Text = "[Notice]";
            this.lbNotice.Click += new System.EventHandler(this.lbNotice_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Location = new System.Drawing.Point(155, 39);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(31, 13);
            this.lbInfo.TabIndex = 5;
            this.lbInfo.Text = "[Info]";
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Location = new System.Drawing.Point(114, 39);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(35, 13);
            this.lbError.TabIndex = 4;
            this.lbError.Text = "[Error]";
            this.lbError.Click += new System.EventHandler(this.lbError_Click);
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.BackColor = System.Drawing.Color.Transparent;
            this.lbWarning.Location = new System.Drawing.Point(55, 39);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(53, 13);
            this.lbWarning.TabIndex = 3;
            this.lbWarning.Text = "[Warning]";
            this.lbWarning.Click += new System.EventHandler(this.lbWarning_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Location = new System.Drawing.Point(6, 39);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(43, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "[Status]";
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // cbOldRev
            // 
            this.cbOldRev.AutoSize = true;
            this.cbOldRev.BackColor = System.Drawing.Color.Transparent;
            this.cbOldRev.Enabled = false;
            this.cbOldRev.Location = new System.Drawing.Point(104, 19);
            this.cbOldRev.Name = "cbOldRev";
            this.cbOldRev.Size = new System.Drawing.Size(132, 17);
            this.cbOldRev.TabIndex = 1;
            this.cbOldRev.Text = "Revision 1580 or older";
            this.cbOldRev.UseVisualStyleBackColor = false;
            this.cbOldRev.CheckedChanged += new System.EventHandler(this.cbOldRev_CheckedChanged);
            // 
            // cbColorOnOff
            // 
            this.cbColorOnOff.AutoSize = true;
            this.cbColorOnOff.BackColor = System.Drawing.Color.Transparent;
            this.cbColorOnOff.Location = new System.Drawing.Point(6, 19);
            this.cbColorOnOff.Name = "cbColorOnOff";
            this.cbColorOnOff.Size = new System.Drawing.Size(92, 17);
            this.cbColorOnOff.TabIndex = 0;
            this.cbColorOnOff.Text = "Activate Color";
            this.cbColorOnOff.UseVisualStyleBackColor = false;
            this.cbColorOnOff.CheckedChanged += new System.EventHandler(this.cbColorOnOff_CheckedChanged);
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(335, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbMap);
            this.Controls.Add(this.lbChar);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.txtMapPath);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.txtCharPath);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOption";
            this.Text = "ServerMonitor - Option";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginPath;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.TextBox txtCharPath;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.TextBox txtMapPath;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbChar;
        private System.Windows.Forms.Label lbMap;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.CheckBox cbOldRev;
        private System.Windows.Forms.CheckBox cbColorOnOff;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbSql;
        private System.Windows.Forms.Label lbDebug;
    }
}