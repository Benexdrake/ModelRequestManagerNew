using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PdfReaderVideo
{
    public class LoadFiles
    {


        public LoadFiles()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string pfadMP4 = Directory.GetCurrentDirectory() + @"\mp4\";
            

            MP4Auswahl.instance.listBox.Items.Clear();
                string[] dateien = Directory.GetFiles(pfadMP4);

                foreach (string s in dateien)
                {
                    MP4Auswahl.instance.listBox.Items.Add(Path.GetFileName(s));
                }

            

        }

    }
}
