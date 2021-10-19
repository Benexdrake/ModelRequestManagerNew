
namespace ModelRequestManagerNew.Forms
{
    partial class UltimaRequestForm
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
            this.cBox_Category = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_Category = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRequestDateFill = new System.Windows.Forms.Label();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblWhitebox = new System.Windows.Forms.Label();
            this.lblLowpoly = new System.Windows.Forms.Label();
            this.lblHighpoly = new System.Windows.Forms.Label();
            this.lblTexture = new System.Windows.Forms.Label();
            this.cBoxTexture = new System.Windows.Forms.CheckBox();
            this.cBoxHighPoly = new System.Windows.Forms.CheckBox();
            this.cBoxLowPoly = new System.Windows.Forms.CheckBox();
            this.cBoxWhitebox = new System.Windows.Forms.CheckBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.cBoxAvailable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cBox_Category
            // 
            this.cBox_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cBox_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBox_Category.ForeColor = System.Drawing.SystemColors.Window;
            this.cBox_Category.FormattingEnabled = true;
            this.cBox_Category.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3"});
            this.cBox_Category.Location = new System.Drawing.Point(424, 47);
            this.cBox_Category.Name = "cBox_Category";
            this.cBox_Category.Size = new System.Drawing.Size(121, 21);
            this.cBox_Category.TabIndex = 69;
            this.cBox_Category.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 5);
            this.panel3.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel1.Location = new System.Drawing.Point(424, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 5);
            this.panel1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(45, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 5);
            this.panel2.TabIndex = 66;
            // 
            // txtBox_Category
            // 
            this.txtBox_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBox_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Category.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBox_Category.Location = new System.Drawing.Point(424, 15);
            this.txtBox_Category.Name = "txtBox_Category";
            this.txtBox_Category.ReadOnly = true;
            this.txtBox_Category.Size = new System.Drawing.Size(106, 13);
            this.txtBox_Category.TabIndex = 65;
            this.txtBox_Category.Text = "Great";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(9, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsername.Size = new System.Drawing.Size(55, 23);
            this.lblUsername.TabIndex = 64;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRequestDateFill
            // 
            this.lblRequestDateFill.AutoSize = true;
            this.lblRequestDateFill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRequestDateFill.Location = new System.Drawing.Point(727, 5);
            this.lblRequestDateFill.Name = "lblRequestDateFill";
            this.lblRequestDateFill.Size = new System.Drawing.Size(61, 13);
            this.lblRequestDateFill.TabIndex = 59;
            this.lblRequestDateFill.Text = "00.00.0000";
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRequestDate.Location = new System.Drawing.Point(645, 5);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(76, 13);
            this.lblRequestDate.TabIndex = 58;
            this.lblRequestDate.Text = "Request Date:";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNote.Location = new System.Drawing.Point(45, 15);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(348, 13);
            this.txtNote.TabIndex = 57;
            this.txtNote.Text = "This is a Test";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNote.Location = new System.Drawing.Point(6, 18);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 56;
            this.lblNote.Text = "Note:";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpen.Location = new System.Drawing.Point(674, 47);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(115, 36);
            this.btnOpen.TabIndex = 55;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblWhitebox
            // 
            this.lblWhitebox.AutoSize = true;
            this.lblWhitebox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWhitebox.Location = new System.Drawing.Point(70, 37);
            this.lblWhitebox.Name = "lblWhitebox";
            this.lblWhitebox.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblWhitebox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWhitebox.Size = new System.Drawing.Size(52, 23);
            this.lblWhitebox.TabIndex = 77;
            this.lblWhitebox.Text = "Whitebox";
            this.lblWhitebox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLowpoly
            // 
            this.lblLowpoly.AutoSize = true;
            this.lblLowpoly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLowpoly.Location = new System.Drawing.Point(147, 37);
            this.lblLowpoly.Name = "lblLowpoly";
            this.lblLowpoly.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblLowpoly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLowpoly.Size = new System.Drawing.Size(46, 23);
            this.lblLowpoly.TabIndex = 76;
            this.lblLowpoly.Text = "Lowpoly";
            this.lblLowpoly.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHighpoly
            // 
            this.lblHighpoly.AutoSize = true;
            this.lblHighpoly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHighpoly.Location = new System.Drawing.Point(246, 37);
            this.lblHighpoly.Name = "lblHighpoly";
            this.lblHighpoly.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblHighpoly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHighpoly.Size = new System.Drawing.Size(48, 23);
            this.lblHighpoly.TabIndex = 75;
            this.lblHighpoly.Text = "Highpoly";
            this.lblHighpoly.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTexture
            // 
            this.lblTexture.AutoSize = true;
            this.lblTexture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTexture.Location = new System.Drawing.Point(348, 37);
            this.lblTexture.Name = "lblTexture";
            this.lblTexture.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTexture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTexture.Size = new System.Drawing.Size(43, 23);
            this.lblTexture.TabIndex = 74;
            this.lblTexture.Text = "Texture";
            this.lblTexture.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxTexture
            // 
            this.cBoxTexture.AutoSize = true;
            this.cBoxTexture.Enabled = false;
            this.cBoxTexture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxTexture.Location = new System.Drawing.Point(332, 46);
            this.cBoxTexture.Name = "cBoxTexture";
            this.cBoxTexture.Size = new System.Drawing.Size(15, 14);
            this.cBoxTexture.TabIndex = 73;
            this.cBoxTexture.UseVisualStyleBackColor = true;
            // 
            // cBoxHighPoly
            // 
            this.cBoxHighPoly.AutoSize = true;
            this.cBoxHighPoly.Enabled = false;
            this.cBoxHighPoly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxHighPoly.Location = new System.Drawing.Point(231, 46);
            this.cBoxHighPoly.Name = "cBoxHighPoly";
            this.cBoxHighPoly.Size = new System.Drawing.Size(15, 14);
            this.cBoxHighPoly.TabIndex = 72;
            this.cBoxHighPoly.UseVisualStyleBackColor = true;
            // 
            // cBoxLowPoly
            // 
            this.cBoxLowPoly.AutoSize = true;
            this.cBoxLowPoly.Enabled = false;
            this.cBoxLowPoly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxLowPoly.Location = new System.Drawing.Point(132, 46);
            this.cBoxLowPoly.Name = "cBoxLowPoly";
            this.cBoxLowPoly.Size = new System.Drawing.Size(15, 14);
            this.cBoxLowPoly.TabIndex = 71;
            this.cBoxLowPoly.UseVisualStyleBackColor = true;
            // 
            // cBoxWhitebox
            // 
            this.cBoxWhitebox.AutoSize = true;
            this.cBoxWhitebox.Enabled = false;
            this.cBoxWhitebox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxWhitebox.Location = new System.Drawing.Point(55, 46);
            this.cBoxWhitebox.Name = "cBoxWhitebox";
            this.cBoxWhitebox.Size = new System.Drawing.Size(15, 14);
            this.cBoxWhitebox.TabIndex = 70;
            this.cBoxWhitebox.UseVisualStyleBackColor = true;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAvailable.Location = new System.Drawing.Point(721, 11);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAvailable.Size = new System.Drawing.Size(50, 23);
            this.lblAvailable.TabIndex = 79;
            this.lblAvailable.Text = "Available";
            this.lblAvailable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxAvailable
            // 
            this.cBoxAvailable.AutoSize = true;
            this.cBoxAvailable.Enabled = false;
            this.cBoxAvailable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxAvailable.Location = new System.Drawing.Point(773, 21);
            this.cBoxAvailable.Name = "cBoxAvailable";
            this.cBoxAvailable.Size = new System.Drawing.Size(15, 14);
            this.cBoxAvailable.TabIndex = 78;
            this.cBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // UltimaRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 100);
            this.Controls.Add(this.cBoxAvailable);
            this.Controls.Add(this.lblWhitebox);
            this.Controls.Add(this.lblLowpoly);
            this.Controls.Add(this.lblHighpoly);
            this.Controls.Add(this.lblTexture);
            this.Controls.Add(this.cBoxTexture);
            this.Controls.Add(this.cBoxHighPoly);
            this.Controls.Add(this.cBoxLowPoly);
            this.Controls.Add(this.cBoxWhitebox);
            this.Controls.Add(this.cBox_Category);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBox_Category);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRequestDateFill);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblAvailable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UltimaRequestForm";
            this.Text = "UltimaRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_Category;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtBox_Category;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblRequestDateFill;
        private System.Windows.Forms.Label lblRequestDate;
        public System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.Label lblWhitebox;
        public System.Windows.Forms.Label lblLowpoly;
        public System.Windows.Forms.Label lblHighpoly;
        public System.Windows.Forms.Label lblTexture;
        public System.Windows.Forms.CheckBox cBoxTexture;
        public System.Windows.Forms.CheckBox cBoxHighPoly;
        public System.Windows.Forms.CheckBox cBoxLowPoly;
        public System.Windows.Forms.CheckBox cBoxWhitebox;
        public System.Windows.Forms.Label lblAvailable;
        public System.Windows.Forms.CheckBox cBoxAvailable;
    }
}