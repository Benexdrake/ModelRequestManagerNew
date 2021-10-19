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
    public partial class MainForm : Form
    {
        AllUsersListForm aULForm;
        AllUsersForm aUForm;
        UltimaRequestForm ultimaForm;
        RequestForm rForm;
        string sql = "";
        string ascDesc = "desc";
        static int okButtonAuswahl;
        public static Request request;
        public static Users users;
        SqlDB sqlDB;


        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void windowMove_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove.ReleaseCapture();
            WindowMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        MainForm()
        {
        }
        public MainForm(bool _adminMode)
        {
            InitializeComponent();
            request = new Request();
            users = new Users();
            sqlDB = new SqlDB();
            if (_adminMode == false)
            {
                panelAdmin.Visible = false;
            }
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btn_CreateNewRequest.Visible = false;
            btn_CreateNewUser.Visible = false;
            panelChild.AutoScroll = true;
        }
        
       

        private void bntClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenForm(Form form)
        {
            
            form.TopLevel = false;
            panelChild.Controls.Add(form);
            form.Dock = DockStyle.Top;
            form.Show();
        }
        void sqlConnection(int auswahl)
        {
          // Je nach Auswahl, wird eine Query an die SQL geschickt, immer 2 versionen, falls das Suchfeld leer ist oder etwas drin steht.
            switch (auswahl)
            {
                case 0:
                    {
                        if(txtBoxSearch.Text == "")
                        {
                            sql = @"select * from users order by username " + ascDesc + ";";
                        }
                        else
                        {
                            sql = @"select * from users where username like '%" + txtBoxSearch.Text + "%' order by username " + ascDesc + ";";
                        }
                        break;
                    }
                case 1:
                    {
                        if(txtBoxSearch.Text == "")
                        {
                            sql = @"select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.username, users.userguidid, requests.available from requests join users on requests.requserid = users.userid where users.username = '" + Save.sqlUsername + "' order by reqid "+ascDesc+";";
                        }
                        else
                        {
                            sql = @"select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.username, users.userguidid,requests.available from requests join users on requests.requserid = users.userid where users.username = '" + Save.sqlUsername + "' and requests.reqnote like '%"+txtBoxSearch.Text+"%' order by reqid " + ascDesc + "; ";
                        }
                        break;
                    }
                case 2:
                    {
                        if (txtBoxSearch.Text == "")
                        {
                            sql = @"select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.username, users.userguidid, requests.available from requests join users on requests.requserid = users.userid where requests.available = true order by reqid " + ascDesc+";";
                        }
                        else
                        {
                            sql = @"select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.username, users.userguidid, requests.available from requests join users on requests.requserid = users.userid where requests.reqnote like '%" + txtBoxSearch.Text+ "%' and requests.available = true order by reqid " + ascDesc+";";
                        }
                        break;
                    }
                case 3:
                    {
                        if (txtBoxSearch.Text == "")
                        {
                            sql = @"select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.username, users.userguidid, requests.available
                                    from saverequests 
                                    join users on saverequests.sruserid = users.userid
                                    join requests on saverequests.Srreqid = requests.reqid and users.userid = requests.requserid where saverequests.saveuserid = " + Save.LoginUserID+"   order by requests.reqnote "+ascDesc+";";
                        }
                        else
                        {
                            sql = @"select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.username, users.userguidid, requests.available
                                    from saverequests 
                                    join users on saverequests.sruserid = users.userid
                                    join requests on saverequests.Srreqid = requests.reqid and users.userid = requests.requserid where saverequests.saveuserid = " + Save.LoginUserID + " and requests.reqnote like '%"+ txtBoxSearch.Text +"%' order by requests.reqnote " + ascDesc + ";";
                        }
                        break;
                    }
            }
        }
        void fillRequest(int auswahl)
        {
            // Befüllt in einer Foreach schleife Objekte, gelesen aus einer List werden neue Objekte erstellt.
            okButtonAuswahl = auswahl;
          
            foreach (var item in Request.requestList)
            {
                int userid = Save.LoginUserID;
                if(auswahl == 0)
                {
                    ++userid;
                }
                if (userid != item.requestUserId)
                {
                   
                ultimaForm = new UltimaRequestForm(auswahl);
                ultimaForm.mform = this;
                ultimaForm.request.requestId = item.requestId;
                ultimaForm.request.requestUserId = item.requestUserId;
                ultimaForm.request.note = item.note;
                ultimaForm.request.text = item.text;
                ultimaForm.request.category = item.category;
                ultimaForm.request.fileName = item.fileName;
                ultimaForm.request.whiteBox = item.whiteBox;
                ultimaForm.request.lowPoly = item.lowPoly;
                ultimaForm.request.highPoly = item.highPoly;
                ultimaForm.request.texture = item.texture;
                ultimaForm.request.requestDate = item.requestDate;
                ultimaForm.request.username = item.username;
                ultimaForm.request.guid = item.guid;
                ultimaForm.request.available = item.available;
                
                ultimaForm.MakeRequest();
                OpenForm(ultimaForm);
                }
                
                
            }
            Save.maxRequestID = Request.requestList.Count;
        }

        void fillUsers(int auswahl)
        {
            // Befüllt User objekte, gelesen aus einer Liste
            okButtonAuswahl = auswahl;
            foreach (var item in Users.userList)
            {
                aULForm = new AllUsersListForm();
                aULForm.mform = this;
                aULForm.users.userID = item.userID;
                aULForm.users.userGUID = item.userGUID;
                aULForm.users.username = item.username;
                aULForm.users.firstName = item.firstName;
                aULForm.users.lastName = item.lastName;
                aULForm.users.userBirthDate = item.userBirthDate;
                aULForm.users.registerDate = item.registerDate;
                aULForm.users.userEmail = item.userEmail;
                aULForm.users.userTele = item.userTele;
                aULForm.users.admin = item.admin;
                aULForm.users.available = item.available;
                aULForm.MakeRequest();
                OpenForm(aULForm);
            }
        }

        public void btn_MyRequests_Click(object sender, EventArgs e)
        {
            closeForm();
            Request.requestList.Clear();
            panelSearchBar.Visible = true;
            btn_CreateNewRequest.Visible = true;
            btn_CreateNewUser.Visible = false;
            panelChild.Controls.Clear();
            
            sqlConnection(1);
            sqlDB.loadRequests(sql);
            fillRequest(0);
        }
        
        public void btn_AllUsers_Click(object sender, EventArgs e)
        {
            closeForm();
            panelSearchBar.Visible = true;
            btn_CreateNewRequest.Visible = false;
            btn_CreateNewUser.Visible = true;
            panelChild.Controls.Clear();
            Users.userList.Clear();
          
            sqlConnection(0);
            sqlDB.LoadUsers(sql);
            fillUsers(3);
        }
        public void btn_AllRequests_Click(object sender, EventArgs e)
        {
            closeForm();
            panelChild.Controls.Clear();
            Request.requestList.Clear();
            panelSearchBar.Visible = true;
            btn_CreateNewRequest.Visible = false;
            btn_CreateNewUser.Visible = false;
           
            sqlConnection(2);
            sqlDB.loadRequests(sql);
            fillRequest(1);
        }

        public void btn_RequestList_Click(object sender, EventArgs e)
        {
            closeForm();
            panelChild.Controls.Clear();
            Request.requestList.Clear();
            panelSearchBar.Visible = true;
            btn_CreateNewRequest.Visible = false;
            btn_CreateNewUser.Visible = false;
          
            sqlConnection(3);
            sqlDB.loadRequests(sql);
            fillRequest(2);
            
        }
        private void bntClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CreateNewRequest_Click(object sender, EventArgs e)
        {
            closeForm();
            rForm = new RequestForm(3);
            rForm.mForm = this;
            rForm.Show();
        }

        private void btn_CreateNewUser_Click(object sender, EventArgs e)
        {
            closeForm();
            aUForm = new AllUsersForm(0);
            aUForm.mform = this;
            aUForm.Show();
        }

        private void closeForm()
        {
            // Überprüft ob eine Form schon offen ist, diese wird dann geschlossen.
            var formCloseUser = Application.OpenForms.OfType<AllUsersForm>().FirstOrDefault();
            
            if (formCloseUser != null)
            {
                formCloseUser.Close();
            }
            formCloseUser = Application.OpenForms.OfType<AllUsersForm>().FirstOrDefault();
            
            var formCloseRequest = Application.OpenForms.OfType<RequestForm>().FirstOrDefault();
            
            if (formCloseRequest != null)
            {
                formCloseRequest.Close();
            }
            formCloseRequest = Application.OpenForms.OfType<RequestForm>().FirstOrDefault();   
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(okButtonAuswahl == 0)
            {
                btn_MyRequests_Click(sender, e);
            }
            else if (okButtonAuswahl == 1)
            {
                btn_AllRequests_Click(sender, e);
            }
            else if (okButtonAuswahl == 2)
            {
                btn_RequestList_Click(sender, e);
            }
            else if (okButtonAuswahl == 3)
            {
                btn_AllUsers_Click(sender, e);
            }
        }

        private void radioButtonAsc_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAsc.Checked == true)
            {
                ascDesc = "desc";
                btnOk_Click(sender, e);
            }
        }

        private void radioButtonDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDesc.Checked == true)
            {
                ascDesc = "asc";
                btnOk_Click(sender, e);
            }
        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);
            }
        }
    }
}
