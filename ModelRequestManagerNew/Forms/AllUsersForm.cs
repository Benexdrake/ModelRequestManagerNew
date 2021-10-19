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
    public partial class AllUsersForm : Form
    {
        public int auswahl { get; set; }
        public Users users;
        private SqlDB sqlDB;
        public MainForm mform;

        private void windowMove_MouseDown(object sender, MouseEventArgs e)
        {
           WindowMove.ReleaseCapture();
           WindowMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public AllUsersForm(int _auswahl)
        {
            auswahl = _auswahl;
            InitializeComponent();
            cBoxAvailable.Checked = true;
            sqlDB = new SqlDB();
            users = new Users();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void loadData()
        {
            // Ladet die Daten aus dem Objekt users und legt diese in die sichtbaren Teile
            txtUsername.Text = users.username;
            txtFirstname.Text = users.firstName;
            txtLastname.Text = users.lastName;
            txtEmail.Text = users.userEmail;
            txtTele.Text = users.userTele;
            cBoxAdmin.Checked = users.admin;
            cBoxAvailable.Checked = users.available;

            DateTimeBirthdate.Value = DateTime.Parse(users.userBirthDate);
        }

        private void refreshList(object sender, EventArgs e)
        {
            mform.btn_AllUsers_Click(sender,e);
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            refreshList(sender, e);
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool usernameFree = false; ;
            sqlDB.ip = Save.sqlIp;
            sqlDB.dataBase = Save.sqlDataBase;
            sqlDB.port = Save.sqlPort;
            sqlDB.username = Save.sqlUsername;
            sqlDB.sqlPassword = Save.sqlPassword;
            string sql = "";

            foreach (var item in Users.userList)
            {
                if(item.username == txtUsername.Text)
                {
                    usernameFree = false;
                }
                else
                {
                    usernameFree = true;
                }
            }

            if (usernameFree == true || users.username == txtUsername.Text)
            {
                if (txtUsername.Text != "" && txtFirstname.Text != "" && txtLastname.Text != "" && txtEmail.Text != "" && txtTele.Text != "" && DateTimeBirthdate.Value.ToString("dd.MM.yyyy") != DateTime.Now.ToString("dd.MM.yyyy"))
                {
                    if (users.userGUID == "" || users.userGUID == null)
                    {
                        Guid guid = Guid.NewGuid();
                        users.userGUID = guid.ToString();
                        
                    }
                    else
                    {
                        
                    }

                    if (auswahl == 0)
                    {
                        // insert into, erstellt einen neuen User, für die Datenbank Users und für Mysql users, bei Admin, bekommt er alle Privilegien
                        // Passwort in SHA256 umwandeln
                        string SHAPassword = SHA256Password.Compute256(txtBoxPassword.Text);
                        sql = @"insert into Users( UserName,UserPassword ,UserGuidId, UserFirstName,UserLastName,UserBirthDate,UserRegisterDate, UserEmail, UserTelefon, UserAdmin, UserAvailable) 
                        values 
                       ('" + txtUsername.Text + "','" + SHAPassword + "', '" + users.userGUID + "','" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + DateTimeBirthdate.Value.ToString("dd.MM.yyyy") + "','" + DateTime.Now.ToString("dd.MM.yyyy") + "','" + txtEmail.Text + "','" + txtTele.Text + "'," + cBoxAdmin.Checked + ", " + cBoxAvailable.Checked + "); "
                       + " create user '" + txtUsername.Text + "'@'" + sqlDB.ip + "'  identified by	'" + txtBoxPassword.Text + "';";
                       if(cBoxAdmin.Checked == false)
                        {
                       sql = sql + "Grant All privileges on "+sqlDB.dataBase+" .* to	 '"+txtUsername.Text+"'@'"+sqlDB.ip+"';";
                        }
                       else
                        {
                            sql = sql + "Grant All privileges on *.* to	 '" + txtUsername.Text + "'@'" + sqlDB.ip + "';";
                        }
                    }
                    else if (auswahl == 1)
                    {
                        // Update Users, löscht den User, erstellt ihn neu, ist er ein Admin, bekommt er alle Privilegien
                        string admin;
                        string SHAPassword = SHA256Password.Compute256(txtBoxPassword.Text);
                        sql = @"update users set UserName = '" + txtUsername.Text + "',UserPassword = '" + SHAPassword + "' ,UserGuidid = '" + users.userGUID + "', UserFirstName = '" + txtFirstname.Text + "',UserLastName = '" + txtLastname.Text + "',UserBirthDate = '" + DateTimeBirthdate.Value.ToString("dd,MM,yyyy") + "', UserEmail = '" + txtEmail.Text + "', UserTelefon = '" + txtTele.Text + "', UserAdmin = " + cBoxAdmin.Checked + ", UserAvailable = " + cBoxAvailable.Checked + " where userid = " + users.userID + ";"
                            + "drop user "+ users.username + "@localhost;"
                            + "create user '" + users.username + "'@'" + sqlDB.ip + "'  identified by	'"+txtBoxPassword.Text+"';";
                        if(cBoxAdmin.Checked == true)
                        {
                            admin = @"Grant All privileges on *.* to '"+txtUsername.Text+"'@'"+sqlDB.ip+"';";
                            sql = sql + admin;
                        }
                        else
                        {
                            admin = "Grant All privileges on " + sqlDB.dataBase + " .* to	 '" + txtUsername.Text + "'@'" + sqlDB.ip + "';";
                            sql = sql + admin;
                        }
                    }
                    sqlDB.createUpdate(sql);
                }
            }
            else if (usernameFree == false)
            {
                lblInformation.Visible = true;
                pBoxX.Visible = true;
            }
            refreshList(sender, e);
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblInformation.Visible = false;
            pBoxX.Visible = false;
        }
    }
}
