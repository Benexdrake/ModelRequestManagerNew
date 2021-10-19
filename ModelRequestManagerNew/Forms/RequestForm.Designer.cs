
namespace ModelRequestManagerNew.Forms
{
    partial class RequestForm
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
            this.btn_Like = new System.Windows.Forms.PictureBox();
            this.cBoxAvailable = new System.Windows.Forms.CheckBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.cBoxTexture = new System.Windows.Forms.CheckBox();
            this.cBoxHighPoly = new System.Windows.Forms.CheckBox();
            this.cBoxLowPoly = new System.Windows.Forms.CheckBox();
            this.cBoxWhitebox = new System.Windows.Forms.CheckBox();
            this.lblRequestDateFill = new System.Windows.Forms.Label();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cBox_Category = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Like)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btn_Like);
            this.panelHeader.Controls.Add(this.cBoxAvailable);
            this.panelHeader.Controls.Add(this.bntClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 45);
            this.panelHeader.TabIndex = 53;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowMove_MouseDown);
            // 
            // btn_Like
            // 
            this.btn_Like.Image = global::ModelRequestManagerNew.Properties.Resources.Heart_NoLike;
            this.btn_Like.Location = new System.Drawing.Point(686, 4);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(41, 38);
            this.btn_Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Like.TabIndex = 70;
            this.btn_Like.TabStop = false;
            this.btn_Like.Click += new System.EventHandler(this.btn_Like_Click);
            // 
            // cBoxAvailable
            // 
            this.cBoxAvailable.AutoSize = true;
            this.cBoxAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxAvailable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxAvailable.Location = new System.Drawing.Point(12, 12);
            this.cBoxAvailable.Name = "cBoxAvailable";
            this.cBoxAvailable.Size = new System.Drawing.Size(119, 29);
            this.cBoxAvailable.TabIndex = 59;
            this.cBoxAvailable.Text = "Available";
            this.cBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // bntClose
            // 
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.bntClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntClose.FlatAppearance.BorderSize = 0;
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntClose.Location = new System.Drawing.Point(750, 0);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(50, 45);
            this.bntClose.TabIndex = 1;
            this.bntClose.Text = "X";
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSend.Location = new System.Drawing.Point(664, 404);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 36);
            this.btnSend.TabIndex = 67;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxText
            // 
            this.txtBoxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxText.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxText.Location = new System.Drawing.Point(12, 109);
            this.txtBoxText.Multiline = true;
            this.txtBoxText.Name = "txtBoxText";
            this.txtBoxText.Size = new System.Drawing.Size(767, 289);
            this.txtBoxText.TabIndex = 65;
            this.txtBoxText.Text = "Insert Text to describe what you want here...";
            this.txtBoxText.Enter += new System.EventHandler(this.txtBoxText_Enter);
            this.txtBoxText.Leave += new System.EventHandler(this.txtBoxText_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel1.Location = new System.Drawing.Point(421, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 5);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(48, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 5);
            this.panel2.TabIndex = 63;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInformation.Location = new System.Drawing.Point(9, 83);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInformation.Size = new System.Drawing.Size(62, 23);
            this.lblInformation.TabIndex = 62;
            this.lblInformation.Text = "Information:";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxTexture
            // 
            this.cBoxTexture.AutoSize = true;
            this.cBoxTexture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxTexture.Location = new System.Drawing.Point(717, 82);
            this.cBoxTexture.Name = "cBoxTexture";
            this.cBoxTexture.Size = new System.Drawing.Size(62, 17);
            this.cBoxTexture.TabIndex = 61;
            this.cBoxTexture.Text = "Texture";
            this.cBoxTexture.UseVisualStyleBackColor = true;
            // 
            // cBoxHighPoly
            // 
            this.cBoxHighPoly.AutoSize = true;
            this.cBoxHighPoly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxHighPoly.Location = new System.Drawing.Point(616, 82);
            this.cBoxHighPoly.Name = "cBoxHighPoly";
            this.cBoxHighPoly.Size = new System.Drawing.Size(95, 17);
            this.cBoxHighPoly.TabIndex = 60;
            this.cBoxHighPoly.Text = "High Polygone";
            this.cBoxHighPoly.UseVisualStyleBackColor = true;
            // 
            // cBoxLowPoly
            // 
            this.cBoxLowPoly.AutoSize = true;
            this.cBoxLowPoly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxLowPoly.Location = new System.Drawing.Point(517, 82);
            this.cBoxLowPoly.Name = "cBoxLowPoly";
            this.cBoxLowPoly.Size = new System.Drawing.Size(93, 17);
            this.cBoxLowPoly.TabIndex = 59;
            this.cBoxLowPoly.Text = "Low Polygone";
            this.cBoxLowPoly.UseVisualStyleBackColor = true;
            // 
            // cBoxWhitebox
            // 
            this.cBoxWhitebox.AutoSize = true;
            this.cBoxWhitebox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cBoxWhitebox.Location = new System.Drawing.Point(440, 82);
            this.cBoxWhitebox.Name = "cBoxWhitebox";
            this.cBoxWhitebox.Size = new System.Drawing.Size(71, 17);
            this.cBoxWhitebox.TabIndex = 58;
            this.cBoxWhitebox.Text = "Whitebox";
            this.cBoxWhitebox.UseVisualStyleBackColor = true;
            // 
            // lblRequestDateFill
            // 
            this.lblRequestDateFill.AutoSize = true;
            this.lblRequestDateFill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRequestDateFill.Location = new System.Drawing.Point(724, 53);
            this.lblRequestDateFill.Name = "lblRequestDateFill";
            this.lblRequestDateFill.Size = new System.Drawing.Size(61, 13);
            this.lblRequestDateFill.TabIndex = 57;
            this.lblRequestDateFill.Text = "00.00.0000";
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRequestDate.Location = new System.Drawing.Point(642, 53);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(76, 13);
            this.lblRequestDate.TabIndex = 56;
            this.lblRequestDate.Text = "Request Date:";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNote.Location = new System.Drawing.Point(48, 53);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(348, 13);
            this.txtNote.TabIndex = 55;
            this.txtNote.Text = "Insert Note here...";
            this.txtNote.Enter += new System.EventHandler(this.txtNote_Enter);
            this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNote.Location = new System.Drawing.Point(9, 53);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 54;
            this.lblNote.Text = "Note:";
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
            this.cBox_Category.Location = new System.Drawing.Point(421, 51);
            this.cBox_Category.Name = "cBox_Category";
            this.cBox_Category.Size = new System.Drawing.Size(121, 21);
            this.cBox_Category.TabIndex = 66;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpload.Location = new System.Drawing.Point(12, 404);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 36);
            this.btnUpload.TabIndex = 68;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDownload.Location = new System.Drawing.Point(133, 404);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(115, 36);
            this.btnDownload.TabIndex = 69;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.cBoxTexture);
            this.Controls.Add(this.cBoxHighPoly);
            this.Controls.Add(this.cBoxLowPoly);
            this.Controls.Add(this.cBoxWhitebox);
            this.Controls.Add(this.lblRequestDateFill);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.cBox_Category);
            this.Controls.Add(this.panelHeader);
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Like)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.CheckBox cBoxTexture;
        private System.Windows.Forms.CheckBox cBoxHighPoly;
        private System.Windows.Forms.CheckBox cBoxLowPoly;
        private System.Windows.Forms.CheckBox cBoxWhitebox;
        private System.Windows.Forms.Label lblRequestDateFill;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cBox_Category;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.CheckBox cBoxAvailable;
        private System.Windows.Forms.PictureBox btn_Like;
    }
}