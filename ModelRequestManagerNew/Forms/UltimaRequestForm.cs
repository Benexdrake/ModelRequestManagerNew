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
    public partial class UltimaRequestForm : Form
    {
        RequestForm rForm;
        public MainForm mform;
        public string text { get; set; }
        public string guid { get; set; }
        public int auswahl { get; set; }
        public DateTime dateTime { get; set; }
        public Request request { get; set; }
        public object buttonSender;
        public UltimaRequestForm(int _auswahl)
        {
            auswahl = _auswahl;
            InitializeComponent();
            request = new Request();
        }
        public void MakeRequest()
        {
            // Befüllt die Dinge aus dem Request Objekt.
            txtNote.Text = request.note;
            cBox_Category.SelectedIndex = request.category;
            txtBox_Category.Text = cBox_Category.Text;
            text = request.text;
            cBoxWhitebox.Checked = request.whiteBox;
            cBoxLowPoly.Checked = request.lowPoly;
            cBoxHighPoly.Checked = request.highPoly;
            cBoxTexture.Checked = request.texture;
            lblRequestDateFill.Text = request.requestDate;
            lblUsername.Text = request.username;
            cBoxAvailable.Checked = request.available;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Öffnet die Request Form und gibt dabei die Daten aus dem Request Objekt weiter.
            var form = Application.OpenForms.OfType<RequestForm>().FirstOrDefault();
            if (form != null)
            {
                form.Close();
            }
            form = Application.OpenForms.OfType<RequestForm>().FirstOrDefault();
            if (form == null)
            {
                rForm = new RequestForm(auswahl);
                rForm.mForm = mform;
                txtBox_Category.Text = cBox_Category.SelectedItem.ToString();
                rForm.request.note = request.note;
                rForm.request.category = request.category;
                rForm.request.text = request.text;
                rForm.request.requestId = request.requestId;
                rForm.request.whiteBox = request.whiteBox;
                rForm.request.lowPoly = request.lowPoly;
                rForm.request.highPoly = request.highPoly;
                rForm.request.texture = request.texture;
                rForm.request.username = request.username;
                rForm.request.guid = request.guid;
                rForm.request.requestDate = request.requestDate;
                rForm.request.available = request.available;
                rForm.request.requestUserId = request.requestUserId;
                rForm.LoadData();
                rForm.checkLike();
                rForm.Show();
            }
            else
            {
                rForm.Close();
            }
        }
    }
}
