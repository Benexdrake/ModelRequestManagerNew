
namespace PdfReaderVideo
{
    partial class MP4Auswahl
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 22);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(479, 303);
            this.listBox.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(416, 334);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Ok";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // MP4Auswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 369);
            this.Controls.Add(this.button);
            this.Controls.Add(this.listBox);
            this.Name = "MP4Auswahl";
            this.Text = "MP4Auswahl";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button;
        public System.Windows.Forms.ListBox listBox;
    }
}