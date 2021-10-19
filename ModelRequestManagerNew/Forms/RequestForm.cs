using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelRequestManagerNew.Forms
{
    public partial class RequestForm : Form
    {
        public int auswahl { get; set; }
        public string fileName { get; set; }
        public bool folderExist { get; set; }
        public bool like { get; set; }
        public Request request;
        public MainForm mForm;

        string NoteStandard = "Insert Note here...";
        string TextStandard = "Insert Text to describe what you want here...";

        UpDownload uDLoad;
        SqlDB sqlDB;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void windowMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public RequestForm(int _auswahl)
        {
            auswahl = _auswahl;
            InitializeComponent();
            cBoxAvailable.Checked = true;
            btn_Like.Visible = false;
            request = new Request();
            cBoxAvailable.Checked = true;
            switch (auswahl)
            {
                case 0:
                    {
                        btnSend.Visible = true;
                        btn_Like.Visible = false;
                        Console.WriteLine("My Requests");
                        break;
                    }
                case 1:
                    {
                        btnSend.Visible = false;
                        btn_Like.Visible = true;
                        Console.WriteLine("All Requests");
                        break;
                    }
                case 2:
                    {
                        btnSend.Visible = false;
                        btn_Like.Visible = true;
                        Console.WriteLine("Request List");
                        break;
                    }
                case 3:
                    {
                        btnDownload.Visible = false;
                        btnSend.Visible = true;
                        lblRequestDateFill.Text = DateTime.Now.ToString("dd,MM,yyyy");
                        Console.WriteLine("New Request");
                        break;
                    }
            }
            sqlDB = new SqlDB();
            uDLoad = new UpDownload();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        public void LoadData()
        {
            //Lädt die Daten, die von der List Form mitgegeben wurden
            if(txtNote.Text == "" && txtBoxText.Text == "")
            {
                txtNote.Text = NoteStandard;
                txtBoxText.Text = TextStandard;
            }
            else
            {
                txtNote.Text = request.note;
                NoteStandard = request.note;
                txtBoxText.Text = request.text;
                TextStandard = request.text;
            }
            cBox_Category.SelectedIndex = request.category;
            cBoxWhitebox.Checked = request.whiteBox;
            cBoxLowPoly.Checked = request.lowPoly;
            cBoxHighPoly.Checked = request.highPoly;
            cBoxTexture.Checked = request.texture;
            cBoxAvailable.Checked = request.available;
            lblRequestDateFill.Text = request.requestDate;
        }
        private void bntClose_Click(object sender, EventArgs e)
        {
            refreshList(sender, e);
            Close();
        }

        private void refreshList(object sender, EventArgs e)
        {
            // Damit man nach Close oder Send, die vorher besuchte Seite neustartet um direkt neue Einträge zu sehen.
            switch (auswahl)
            {
                case 0:
                    {
                        mForm.btn_MyRequests_Click(sender, e);
                        break;
                    }
                case 1:
                    {
                        //mForm.btn_AllRequests_Click(sender, e);
                        break;
                    }
                case 2:
                    {
                        mForm.btn_RequestList_Click(sender, e);
                        break;
                    }
                case 3:
                    {
                        mForm.btn_MyRequests_Click(sender, e);
                        break;
                    }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtNote.Text != "" && txtBoxText.Text != "" && cBox_Category.SelectedItem != null)
            {
                request.note = txtNote.Text;
                request.text = txtBoxText.Text;
                request.category = cBox_Category.SelectedIndex;
                request.whiteBox = cBoxWhitebox.Checked;
                request.lowPoly = cBoxLowPoly.Checked;
                request.highPoly = cBoxHighPoly.Checked;
                request.texture = cBoxTexture.Checked;
                
                sendSql();
                refreshList(sender,e);
            }
        }

        private void sendSql()
        {
            sqlDB.ip = Save.sqlIp;
            sqlDB.dataBase = Save.sqlDataBase;
            sqlDB.port = Save.sqlPort;
            sqlDB.username = Save.sqlUsername;
            sqlDB.sqlPassword = Save.sqlPassword;

            string sql = "";
            if (auswahl == 0)
            {
                fileName = "Test.rar"; // <---- Vorläufig, da Upload und Download noch nicht eingebaut
                // update requests where
                sql = @"update requests set reqnote = '" +txtNote.Text+"', reqcategory = " +cBox_Category.SelectedIndex+", reqtext = '" +txtBoxText.Text+"', reqfile = '" +fileName+"', reqwhitebox = "+cBoxWhitebox.Checked+", reqlow = " +cBoxLowPoly.Checked+", reqhigh = " +cBoxHighPoly.Checked +", reqtexture = " +cBoxTexture.Checked + ", available = " + cBoxAvailable.Checked+"  where reqid = " +request.requestId +" and requserid = " +Save.LoginUserID +";";
            }
            else if(auswahl == 3)
            {
                // insert into requests
                request.fileName = "test.rar";
                int requestid = Save.maxRequestID + 1;
                sql = @"insert into requests (ReqID, ReqUserID, ReqNote, ReqText, reqcategory, reqfile, ReqWhitebox, ReqLow, ReqHigh, ReqTexture, available ,ReqDateTime) 
                        values 
                        ( " + requestid + "," + Save.LoginUserID + ",'" + txtNote.Text + "','" + txtBoxText.Text + "'," + cBox_Category.SelectedIndex + ",'" + fileName + "'," + cBoxWhitebox.Checked + "," + cBoxLowPoly.Checked + "," + cBoxHighPoly.Checked + "," + cBoxTexture.Checked + "," + cBoxAvailable.Checked + ",'" + DateTime.Now.ToString("dd.MM.yyyy") + "');";
                
            }
            sqlDB.createUpdate(sql);
            this.Close();

        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            //uDLoad.checkDownloadFolderExist(folderExist);
            //uDLoad.Download(folderExist);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //uDLoad.checkUploadFolderExist(folderExist);
            //uDLoad.Upload(folderExist);

        }

        private void txtNote_Enter(object sender, EventArgs e)
        {
            if(txtNote.Text == NoteStandard)
            {
            txtNote.Text = "";
            }
            
        }
        private void txtNote_Leave(object sender, EventArgs e)
        {
            if(txtNote.Text == "")
            {
                txtNote.Text = NoteStandard;
            }
        }

        private void txtBoxText_Enter(object sender, EventArgs e)
        {
            if(txtBoxText.Text == TextStandard)
            {
                txtBoxText.Text = "";
            }
        }

        private void txtBoxText_Leave(object sender, EventArgs e)
        {
            if (txtBoxText.Text == "")
            {
                txtBoxText.Text = TextStandard;
            }
        }

        public void checkLike()
        {
            // Überprüft ob der Eintrag geliked wurde oder nicht, bei einem Like, findet man ihn in der Request List, verändert auch das Bild.
            string sql = "";
            sql = @"select SRReqID,SRUserID,SaveUserId from saverequests  where SaveUserId = " + Save.LoginUserID+ " and SRuserid = "+request.requestUserId+" and srreqid = "+request.requestId+";";
            sqlDB.loadLike(sql);
            if(sqlDB.likeId == request.requestId && sqlDB.likeUserId == request.requestUserId)
            {
                like = true;
                btn_Like.Image = Properties.Resources.Heart_Like;
                btn_Like.Refresh();
            }
            else
            {
                like = false;
                btn_Like.Image = Properties.Resources.Heart_NoLike;
                btn_Like.Refresh();
            }
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            // Liked oder Disliked einen Eintrag, bei einem Like, wird dieser in der Datenbank gespeichert, bei Dislike, wird dieser wieder gelöscht.
            if(like == false)
            {
                Console.WriteLine("Like");
                btn_Like.Image = Properties.Resources.Heart_Like;
                btn_Like.Refresh();
                like = true;
                // sql insert into saverequests (1,2,3) values (1,2,3)
                string sql = @"insert into saverequests(SaveUserId, SRUserID, SRReqID)
                                values ("+Save.LoginUserID+","+request.requestUserId+", "+request.requestId+");";
                sqlDB.createUpdate(sql);
            }
            else if(like == true)
            {
                Console.WriteLine("No Like");
                btn_Like.Image = Properties.Resources.Heart_NoLike;
                btn_Like.Refresh();
                like = false;
                // sql Delete from
                string sql = @"delete from saverequests where saveuserid = "+Save.LoginUserID+" and  SRuserid = "+request.requestUserId+" and srreqid = "+request.requestId+"";
                sqlDB.createUpdate(sql);
            }
        }
    }
}
