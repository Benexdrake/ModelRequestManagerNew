using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfReaderVideo
{
    public partial class Form1 : Form
    {

        string pdf1 = @"C:\Users\Benex\Desktop\C#.pdf";
        string pdf2;
        string pdf3;

        public static Form1 instance;

        public static int mp4Auswahl;
       
        public Form1()
        {
            InitializeComponent();
            instance = this;
            axWindowsMediaPlayer1.uiMode = "none";
            this.WindowState = FormWindowState.Maximized;
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            axWindowsMediaPlayer1.enableContextMenu = false;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int formMaxSize;
            int panelButtonMaxSize;
            int panelpdfSize;
            int buttonSize;

            formMaxSize = this.Size.Width;

            panelButtonMaxSize = panelButtons.Size.Width;
            panelpdfSize = formMaxSize / 3;
            buttonSize = panelButtonMaxSize / 4;

            panelPDF.Size = new Size(panelpdfSize, 0);

            button1.Size = new Size(buttonSize, 0);
            button2.Size = new Size(buttonSize, 0);
            button3.Size = new Size(buttonSize, 0);
            button4.Size = new Size(buttonSize, 0);

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MP4Auswahl mp4 = new MP4Auswahl();
            LoadFiles load = new LoadFiles();
            mp4.Show();



            //PdfDocument pdf = PdfDocument.Load(pdf1);
            //pdfViewer1.Document = pdf;
            //if (pdfViewer1.Document != null)
            //{
            //    button2.Visible = true;
            //    button3.Visible = true;
            //    button4.Visible = true;
            //}
        }

        public void activateButton()
        {
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }



        private void axWindowsMediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
           if(e.nButton == 1)
            {
                if ((int)axWindowsMediaPlayer1.playState == 2)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else if ((int)axWindowsMediaPlayer1.playState == 3)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
            }
        }
    }
}
