
namespace ModelRequestManagerNew.Forms
{
    partial class AllUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllUsersForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.bntClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.DateTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.cBoxAdmin = new System.Windows.Forms.CheckBox();
            this.cBoxAvailable = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.pBoxX = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblInformation);
            this.panelHeader.Controls.Add(this.bntClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(285, 45);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowMove_MouseDown);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInformation.Location = new System.Drawing.Point(12, 22);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(144, 13);
            this.lblInformation.TabIndex = 51;
            this.lblInformation.Text = "Username is not Free to Use!";
            this.lblInformation.Visible = false;
            // 
            // bntClose
            // 
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.bntClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntClose.FlatAppearance.BorderSize = 0;
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntClose.Location = new System.Drawing.Point(235, 0);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(50, 45);
            this.bntClose.TabIndex = 1;
            this.bntClose.Text = "X";
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(76, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 49;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Location = new System.Drawing.Point(76, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 13);
            this.txtUsername.TabIndex = 48;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNote.Location = new System.Drawing.Point(12, 60);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(58, 13);
            this.lblNote.TabIndex = 50;
            this.lblNote.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Firstname:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel1.Location = new System.Drawing.Point(76, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 5);
            this.panel1.TabIndex = 52;
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstname.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFirstname.Location = new System.Drawing.Point(76, 110);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(185, 13);
            this.txtFirstname.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Email:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel3.Location = new System.Drawing.Point(76, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 5);
            this.panel3.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(76, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 13);
            this.txtEmail.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Lastname:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel4.Location = new System.Drawing.Point(76, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 5);
            this.panel4.TabIndex = 55;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLastname.Location = new System.Drawing.Point(76, 136);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(185, 13);
            this.txtLastname.TabIndex = 54;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSend.Location = new System.Drawing.Point(158, 238);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 36);
            this.btnSend.TabIndex = 60;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // DateTimeBirthdate
            // 
            this.DateTimeBirthdate.Location = new System.Drawing.Point(76, 208);
            this.DateTimeBirthdate.Name = "DateTimeBirthdate";
            this.DateTimeBirthdate.Size = new System.Drawing.Size(200, 20);
            this.DateTimeBirthdate.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Birthdate";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel5.Location = new System.Drawing.Point(76, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 5);
            this.panel5.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Tel:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel6.Location = new System.Drawing.Point(76, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(185, 5);
            this.panel6.TabIndex = 65;
            // 
            // txtTele
            // 
            this.txtTele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTele.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTele.Location = new System.Drawing.Point(76, 186);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(185, 13);
            this.txtTele.TabIndex = 64;
            // 
            // cBoxAdmin
            // 
            this.cBoxAdmin.AutoSize = true;
            this.cBoxAdmin.ForeColor = System.Drawing.SystemColors.Window;
            this.cBoxAdmin.Location = new System.Drawing.Point(15, 252);
            this.cBoxAdmin.Name = "cBoxAdmin";
            this.cBoxAdmin.Size = new System.Drawing.Size(55, 17);
            this.cBoxAdmin.TabIndex = 67;
            this.cBoxAdmin.Text = "Admin";
            this.cBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // cBoxAvailable
            // 
            this.cBoxAvailable.AutoSize = true;
            this.cBoxAvailable.ForeColor = System.Drawing.SystemColors.Window;
            this.cBoxAvailable.Location = new System.Drawing.Point(76, 252);
            this.cBoxAvailable.Name = "cBoxAvailable";
            this.cBoxAvailable.Size = new System.Drawing.Size(69, 17);
            this.cBoxAvailable.TabIndex = 68;
            this.cBoxAvailable.Text = "Available";
            this.cBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(12, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 71;
            this.lblPassword.Text = "Password:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel7.Location = new System.Drawing.Point(76, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(185, 5);
            this.panel7.TabIndex = 70;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxPassword.Location = new System.Drawing.Point(76, 85);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(185, 13);
            this.txtBoxPassword.TabIndex = 69;
            // 
            // pBoxX
            // 
            this.pBoxX.Image = ((System.Drawing.Image)(resources.GetObject("pBoxX.Image")));
            this.pBoxX.Location = new System.Drawing.Point(263, 60);
            this.pBoxX.Name = "pBoxX";
            this.pBoxX.Size = new System.Drawing.Size(22, 19);
            this.pBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxX.TabIndex = 72;
            this.pBoxX.TabStop = false;
            this.pBoxX.Visible = false;
            // 
            // AllUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(285, 286);
            this.Controls.Add(this.pBoxX);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.cBoxAvailable);
            this.Controls.Add(this.cBoxAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.DateTimeBirthdate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panelHeader);
            this.Name = "AllUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllUsersForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DateTimePicker DateTimeBirthdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.CheckBox cBoxAdmin;
        private System.Windows.Forms.CheckBox cBoxAvailable;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox pBoxX;
    }
}