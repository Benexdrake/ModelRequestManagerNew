
namespace ModelRequestManagerNew.Forms
{
    partial class ConfigForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bntClose = new System.Windows.Forms.Button();
            this.txtBoxSql = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxFtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFtpPassword = new System.Windows.Forms.TextBox();
            this.ftpPassword = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.bntClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(313, 50);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowMove_MouseDown);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(8, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(110, 37);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Config";
            // 
            // bntClose
            // 
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.bntClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntClose.FlatAppearance.BorderSize = 0;
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntClose.Location = new System.Drawing.Point(263, 0);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(50, 50);
            this.bntClose.TabIndex = 0;
            this.bntClose.Text = "X";
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // txtBoxSql
            // 
            this.txtBoxSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSql.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxSql.Location = new System.Drawing.Point(92, 63);
            this.txtBoxSql.Name = "txtBoxSql";
            this.txtBoxSql.Size = new System.Drawing.Size(200, 13);
            this.txtBoxSql.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(12, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(31, 13);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "SQL:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(11, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 5);
            this.panel2.TabIndex = 8;
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPort.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxPort.Location = new System.Drawing.Point(92, 90);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(200, 13);
            this.txtBoxPort.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Port:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel1.Location = new System.Drawing.Point(11, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 5);
            this.panel1.TabIndex = 11;
            // 
            // txtBoxDatabase
            // 
            this.txtBoxDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDatabase.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxDatabase.Location = new System.Drawing.Point(92, 117);
            this.txtBoxDatabase.Name = "txtBoxDatabase";
            this.txtBoxDatabase.Size = new System.Drawing.Size(200, 13);
            this.txtBoxDatabase.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Database:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel3.Location = new System.Drawing.Point(11, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 5);
            this.panel3.TabIndex = 14;
            // 
            // txtBoxFtp
            // 
            this.txtBoxFtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxFtp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFtp.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxFtp.Location = new System.Drawing.Point(92, 144);
            this.txtBoxFtp.Name = "txtBoxFtp";
            this.txtBoxFtp.Size = new System.Drawing.Size(200, 13);
            this.txtBoxFtp.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "FTP:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel4.Location = new System.Drawing.Point(11, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 5);
            this.panel4.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(215, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 31);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFtpPassword
            // 
            this.txtFtpPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtFtpPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFtpPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFtpPassword.Location = new System.Drawing.Point(92, 173);
            this.txtFtpPassword.Name = "txtFtpPassword";
            this.txtFtpPassword.Size = new System.Drawing.Size(200, 13);
            this.txtFtpPassword.TabIndex = 23;
            // 
            // ftpPassword
            // 
            this.ftpPassword.AutoSize = true;
            this.ftpPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ftpPassword.Location = new System.Drawing.Point(12, 172);
            this.ftpPassword.Name = "ftpPassword";
            this.ftpPassword.Size = new System.Drawing.Size(79, 13);
            this.ftpPassword.TabIndex = 22;
            this.ftpPassword.Text = "FTP Password:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel5.Location = new System.Drawing.Point(11, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 5);
            this.panel5.TabIndex = 21;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(313, 252);
            this.Controls.Add(this.txtFtpPassword);
            this.Controls.Add(this.ftpPassword);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxFtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBoxDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxSql);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel2);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.TextBox txtBoxSql;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxFtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtFtpPassword;
        private System.Windows.Forms.Label ftpPassword;
        private System.Windows.Forms.Panel panel5;
    }
}