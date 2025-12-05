using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliothèque
{
    public partial class AdminForm : Form
    {
        private Notification notificationControl;

        public AdminForm()
        {
            InitializeComponent();
            Hello_admin.BackColor = Color.Transparent;
            Back.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle; // Add a visible border
            panel1.BackColor = Color.White; // make sure it's not transparent
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadUserControl(UserControl uc)
        {
            listViewOverdues.Controls.Clear(); // remove old content
            uc.Dock = DockStyle.Fill;   // fill the content area
            listViewOverdues.Controls.Add(uc); // show the new screen
        }
        private void add_book_btn_Click(object sender, EventArgs e)
        {

            LoadUserControl(new addbook());
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SearchBook());
        }

        private void Borrowing_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Borrowing());

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Update());

        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new profileAdmin());

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            listViewOverdues.Controls.Clear();

            // Load the default/welcome control again
            WelcomeAdmincs welcome = new WelcomeAdmincs(); // Make sure this control exists
            welcome.Dock = DockStyle.Fill;
            listViewOverdues.Controls.Add(welcome);
        }

        private void pointerTriangle1_Load(object sender, EventArgs e)
        {

        }

        private void listViewRequests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
            pointerTriangle1.Visible = true;

            panel1.Controls.Clear();

            if (notificationControl == null)
                notificationControl = new Notification();

            notificationControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(notificationControl);

            // IMPORTANT: Manually call the load logic
            notificationControl.LoadRequests();
            notificationControl.LoadOverdues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to sign out?",
       "Sign Out",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                // 1. Clear session info
                SessionUtilisateur.Clear();

                // 2. Open the main form (Form1)
                Form1 mainForm = new Form1();
                mainForm.Show();

                // 3. Close the current form
                this.Close();
            }
        }
    }

}
