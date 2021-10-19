using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfReaderVideo
{
    public partial class MP4Auswahl : Form
    {
        public static MP4Auswahl instance;

        public MP4Auswahl()
        {
            InitializeComponent();
            instance = this;
        }

        private void button_Click(object sender, EventArgs e)
        {
            string auswahl = listBox.SelectedItem.ToString();
            string path = Directory.GetCurrentDirectory();

            auswahl  = auswahl.Substring(0,auswahl.Length - 3);

            Form1.mp4Auswahl = listBox.SelectedIndex;
            //MessageBox.Show(auswahl);
            PdfDocument pdf = PdfDocument.Load(path + @"\pdf\" + auswahl+"pdf");
            Form1.instance.axWindowsMediaPlayer1.URL = path + @"\mp4\" + auswahl + "mp4";
            Form1.instance.pdfViewer1.Document = pdf;
            Form1.instance.activateButton();
            this.Close();
        }
    }
}
