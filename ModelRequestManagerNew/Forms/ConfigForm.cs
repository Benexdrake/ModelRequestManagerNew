using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelRequestManagerNew.Forms
{
    public partial class ConfigForm : Form
    {
        Config config;
        Config cSave;

        public ConfigForm()
        {
            InitializeComponent();
            config = new Config();
            // Ladet die daten aus einer xml die in Config.cs gelesen werden.
            config.LoadDate();
            txtBoxSql.Text = Save.sqlIp;
            txtBoxPort.Text = Save.sqlPort;
            txtBoxDatabase.Text = Save.sqlDataBase;
            txtBoxFtp.Text = Save.ftpIp;
            txtFtpPassword.Text = Save.ftpPassword;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowMove_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove.ReleaseCapture();
            WindowMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Speichert die Daten in der Config.cs, diese werden dort in eine xml geschrieben
                cSave = new Config();
            try
            {
                cSave.sqlIp = txtBoxSql.Text;
                cSave.sqlPort = txtBoxPort.Text;
                cSave.sqlDatabase = txtBoxDatabase.Text;
                cSave.ftpIp = txtBoxFtp.Text;
                cSave.ftpPassword = txtFtpPassword.Text;

                Config.SaveData(cSave);
               
            }
            catch (Exception)
            {

                throw;
            }
            this.Close();
        }
    }
}
