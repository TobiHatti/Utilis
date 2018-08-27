namespace UtilityTool
{
    partial class UtilisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilisForm));
            this.tbcRegisters = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSignOff = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHibernate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestartFull = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuickStart = new System.Windows.Forms.Button();
            this.btnShutdownFull = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.pbxSideBanner = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbxPowerSymbol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPowerTitle = new System.Windows.Forms.Label();
            this.lblPowerExecutedCtr = new System.Windows.Forms.Label();
            this.lblPowerExecutedDate = new System.Windows.Forms.Label();
            this.btnTabPower = new System.Windows.Forms.Button();
            this.lblPowerDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcRegisters.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSideBanner)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPowerSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcRegisters
            // 
            this.tbcRegisters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcRegisters.Controls.Add(this.tabPage1);
            this.tbcRegisters.Controls.Add(this.tabPage2);
            this.tbcRegisters.Location = new System.Drawing.Point(161, 13);
            this.tbcRegisters.Name = "tbcRegisters";
            this.tbcRegisters.SelectedIndex = 0;
            this.tbcRegisters.Size = new System.Drawing.Size(797, 536);
            this.tbcRegisters.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnTabPower);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menü";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Power";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSignOff
            // 
            this.btnSignOff.Location = new System.Drawing.Point(7, 19);
            this.btnSignOff.Name = "btnSignOff";
            this.btnSignOff.Size = new System.Drawing.Size(187, 43);
            this.btnSignOff.TabIndex = 3;
            this.btnSignOff.Text = "Abmelden\r\n(Alle Programme schließen)";
            this.btnSignOff.UseVisualStyleBackColor = true;
            this.btnSignOff.Click += new System.EventHandler(this.btnSignOff_Click);
            this.btnSignOff.MouseEnter += new System.EventHandler(this.btnSignOff_MouseEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHibernate);
            this.groupBox3.Location = new System.Drawing.Point(7, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ruhemodus";
            // 
            // btnHibernate
            // 
            this.btnHibernate.Location = new System.Drawing.Point(7, 19);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(187, 43);
            this.btnHibernate.TabIndex = 0;
            this.btnHibernate.Text = "Ruhemodus\r\n(Windows-Standart)";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            this.btnHibernate.MouseEnter += new System.EventHandler(this.btnHibernate_MouseEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestartFull);
            this.groupBox2.Controls.Add(this.btnRestart);
            this.groupBox2.Location = new System.Drawing.Point(7, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neu Starten";
            // 
            // btnRestartFull
            // 
            this.btnRestartFull.Location = new System.Drawing.Point(7, 69);
            this.btnRestartFull.Name = "btnRestartFull";
            this.btnRestartFull.Size = new System.Drawing.Size(187, 42);
            this.btnRestartFull.TabIndex = 1;
            this.btnRestartFull.Text = "Neu Starten\r\n(Vollständig/Empfohlen)";
            this.btnRestartFull.UseVisualStyleBackColor = true;
            this.btnRestartFull.Click += new System.EventHandler(this.btnRestartFull_Click);
            this.btnRestartFull.MouseEnter += new System.EventHandler(this.btnRestartFull_MouseEnter);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(7, 19);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(187, 43);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Neu Starten\r\n(Windows-Standart)";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseEnter += new System.EventHandler(this.btnRestart_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuickStart);
            this.groupBox1.Controls.Add(this.btnShutdownFull);
            this.groupBox1.Controls.Add(this.btnShutdown);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Herunterfahren";
            // 
            // btnQuickStart
            // 
            this.btnQuickStart.Location = new System.Drawing.Point(6, 117);
            this.btnQuickStart.Name = "btnQuickStart";
            this.btnQuickStart.Size = new System.Drawing.Size(188, 43);
            this.btnQuickStart.TabIndex = 1;
            this.btnQuickStart.Text = "Schnellstart\r\n(Experimentell)";
            this.btnQuickStart.UseVisualStyleBackColor = true;
            this.btnQuickStart.Click += new System.EventHandler(this.btnQuickStart_Click);
            this.btnQuickStart.MouseEnter += new System.EventHandler(this.btnQuickStart_MouseEnter);
            // 
            // btnShutdownFull
            // 
            this.btnShutdownFull.Location = new System.Drawing.Point(6, 68);
            this.btnShutdownFull.Name = "btnShutdownFull";
            this.btnShutdownFull.Size = new System.Drawing.Size(188, 43);
            this.btnShutdownFull.TabIndex = 4;
            this.btnShutdownFull.Text = "Herunterfahren\r\n(Vollständig/Empfohlen)";
            this.btnShutdownFull.UseVisualStyleBackColor = true;
            this.btnShutdownFull.Click += new System.EventHandler(this.btnShutdownFull_Click);
            this.btnShutdownFull.MouseEnter += new System.EventHandler(this.btnShutdownFull_MouseEnter);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(6, 19);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(188, 43);
            this.btnShutdown.TabIndex = 3;
            this.btnShutdown.Text = "Herunterfahren\r\n(Windows-Standart)";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            this.btnShutdown.MouseEnter += new System.EventHandler(this.btnShutdown_MouseEnter);
            // 
            // pbxSideBanner
            // 
            this.pbxSideBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxSideBanner.Location = new System.Drawing.Point(13, 13);
            this.pbxSideBanner.Name = "pbxSideBanner";
            this.pbxSideBanner.Size = new System.Drawing.Size(141, 549);
            this.pbxSideBanner.TabIndex = 0;
            this.pbxSideBanner.TabStop = false;
            this.pbxSideBanner.WaitOnLoad = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSignOff);
            this.groupBox4.Location = new System.Drawing.Point(7, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 71);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Abmelden";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblPowerDescription);
            this.groupBox5.Controls.Add(this.lblPowerExecutedDate);
            this.groupBox5.Controls.Add(this.lblPowerExecutedCtr);
            this.groupBox5.Controls.Add(this.lblPowerTitle);
            this.groupBox5.Controls.Add(this.pbxPowerSymbol);
            this.groupBox5.Location = new System.Drawing.Point(214, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(569, 445);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info-Box";
            // 
            // pbxPowerSymbol
            // 
            this.pbxPowerSymbol.Location = new System.Drawing.Point(478, 12);
            this.pbxPowerSymbol.Name = "pbxPowerSymbol";
            this.pbxPowerSymbol.Size = new System.Drawing.Size(85, 85);
            this.pbxPowerSymbol.TabIndex = 0;
            this.pbxPowerSymbol.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version 1.0.0 Alpha         Made by Tobias Hattinger 2018";
            // 
            // lblPowerTitle
            // 
            this.lblPowerTitle.AutoSize = true;
            this.lblPowerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerTitle.Location = new System.Drawing.Point(6, 19);
            this.lblPowerTitle.Name = "lblPowerTitle";
            this.lblPowerTitle.Size = new System.Drawing.Size(123, 20);
            this.lblPowerTitle.TabIndex = 1;
            this.lblPowerTitle.Text = "Power-Optionen";
            // 
            // lblPowerExecutedCtr
            // 
            this.lblPowerExecutedCtr.AutoSize = true;
            this.lblPowerExecutedCtr.Location = new System.Drawing.Point(6, 402);
            this.lblPowerExecutedCtr.Name = "lblPowerExecutedCtr";
            this.lblPowerExecutedCtr.Size = new System.Drawing.Size(105, 13);
            this.lblPowerExecutedCtr.TabIndex = 2;
            this.lblPowerExecutedCtr.Text = "Funktion Ausgeführt:";
            // 
            // lblPowerExecutedDate
            // 
            this.lblPowerExecutedDate.AutoSize = true;
            this.lblPowerExecutedDate.Location = new System.Drawing.Point(7, 423);
            this.lblPowerExecutedDate.Name = "lblPowerExecutedDate";
            this.lblPowerExecutedDate.Size = new System.Drawing.Size(96, 13);
            this.lblPowerExecutedDate.TabIndex = 3;
            this.lblPowerExecutedDate.Text = "Zuletzt Ausgeführt:";
            // 
            // btnTabPower
            // 
            this.btnTabPower.BackColor = System.Drawing.Color.Transparent;
            this.btnTabPower.Location = new System.Drawing.Point(10, 91);
            this.btnTabPower.Name = "btnTabPower";
            this.btnTabPower.Size = new System.Drawing.Size(301, 69);
            this.btnTabPower.TabIndex = 0;
            this.btnTabPower.Text = "Power";
            this.btnTabPower.UseVisualStyleBackColor = false;
            this.btnTabPower.Click += new System.EventHandler(this.btnTabPower_Click);
            // 
            // lblPowerDescription
            // 
            this.lblPowerDescription.AutoSize = true;
            this.lblPowerDescription.Location = new System.Drawing.Point(10, 48);
            this.lblPowerDescription.Name = "lblPowerDescription";
            this.lblPowerDescription.Size = new System.Drawing.Size(72, 13);
            this.lblPowerDescription.TabIndex = 4;
            this.lblPowerDescription.Text = "Beschreibung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilis PC-Verwaltung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utilis ist ein einfaches Verwaltungsprogramm für das Management und Fehlerbehebun" +
    "g an ihrem PC\r\n";
            // 
            // UtilisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcRegisters);
            this.Controls.Add(this.pbxSideBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UtilisForm";
            this.Text = "Utilis System Managment Tool";
            this.tbcRegisters.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSideBanner)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPowerSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSideBanner;
        private System.Windows.Forms.TabControl tbcRegisters;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShutdownFull;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestartFull;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnQuickStart;
        private System.Windows.Forms.Button btnSignOff;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbxPowerSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPowerTitle;
        private System.Windows.Forms.Label lblPowerExecutedDate;
        private System.Windows.Forms.Label lblPowerExecutedCtr;
        private System.Windows.Forms.Button btnTabPower;
        private System.Windows.Forms.Label lblPowerDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

