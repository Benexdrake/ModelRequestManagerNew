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
    public partial class AllUsersListForm : Form
    {
        AllUsersForm aUForm;
        public MainForm mform;
        public Users users;
        string userEmail;
        string userTele;

        public AllUsersListForm()
        {
            InitializeComponent();
            users = new Users();
        }

        public void MakeRequest()
        {
            // Holt die Daten aus users und speichert diese in den Sichtbaren teilen
            txtBox_Username.Text = users.username;
            txtBox_FirstName.Text = users.firstName;
            txtBox_LastName.Text = users.lastName;
            lbl_BirthDateFill.Text = users.userBirthDate.ToString();
            lbl_RegisterDateFill.Text = users.registerDate.ToString();
            cBox_Admin.Checked = users.admin;
            cBox_Available.Checked = users.available;
            userEmail = users.userEmail;
            userTele = users.userTele;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Öffnet die All Users Form und zeigt alle Daten dort an, übergeben durch das Objekt users
            // Es wird überprüft ob die AllUsersForm schon geöffnet wurde, wenn ja, wird diese geschlossen, ist keine offen, geht es weiter
            var formCloseUser = Application.OpenForms.OfType<AllUsersForm>().FirstOrDefault();

            if (formCloseUser != null)
            {
                formCloseUser.Close();
            }
            formCloseUser = Application.OpenForms.OfType<AllUsersForm>().FirstOrDefault();

            if(formCloseUser == null)
            {
                aUForm = new AllUsersForm(1);
                aUForm.mform = mform;
                aUForm.users.username = users.username;
                aUForm.users.userID = users.userID;
                aUForm.users.userGUID = users.userGUID;
                aUForm.users.firstName = users.firstName;
                aUForm.users.lastName = users.lastName;
                aUForm.users.userEmail = userEmail;
                aUForm.users.userTele = userTele;
                aUForm.users.userBirthDate = users.userBirthDate;
                aUForm.users.admin = users.admin;
                aUForm.users.available = users.available;
                aUForm.loadData();
                aUForm.Show();
            }
            else
            {
                aUForm.Close();
            }


        }
    }
}
