using ModelRequestManagerNew.Forms;
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

namespace ModelRequestManagerNew
{
    public partial class Login : Form
    {
        MainForm mainform;
        ConfigForm cForm;
        Config config;
        SqlDB sqlDb;

        private void windowMove_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove.ReleaseCapture();
            WindowMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public Login()
        {
            InitializeComponent();
            config = new Config();
            config.LoadDate();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lbl_ErrorText.Text = "";
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Wenn die Login daten, die in der Configform gespeichert wurden stimmen, öffnet sich die Main form.
            // Die Mainform hat 2 Versionen, bzw einen Button mehr/weniger, User
            sqlDb = new SqlDB();
            loginDb();
            mainform = new MainForm(sqlDb.admin);
            if (sqlDb.loginOk == true)
            {
                mainform.Show();
                this.Visible = false;
            }
            else
            {
                lbl_ErrorText.Text = "Username or Password false";
            }
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pBoxConfig_Click(object sender, EventArgs e)
        {
            // Öffnet das die Configform, in der wichtige Daten gespeichert werden
            var form = Application.OpenForms.OfType<ConfigForm>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }
            form = Application.OpenForms.OfType<ConfigForm>().FirstOrDefault();


            cForm = new ConfigForm();
            cForm.Show();
        }

        private void loginDb()
        {
            string hashedPassword = SHA256Password.Compute256(txtBoxPassword.Text);
            Save.sqlUsername = txtBoxUsername.Text;
            Save.sqlPassword = txtBoxPassword.Text;
           
            //Config klasse die eine xml ausliest

            string sql = @"select * from users where username = '"+ txtBoxUsername.Text +"' and userpassword = '"+ hashedPassword + "';";
            
            sqlDb.ip = Save.sqlIp;
            sqlDb.dataBase = Save.sqlDataBase;
            sqlDb.port = Save.sqlPort;
            sqlDb.username = Save.sqlUsername;
            sqlDb.sqlPassword = Save.sqlPassword;
            sqlDb.loginDB(sql);
            
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
