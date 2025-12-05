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
    public partial class StudentForm : Form
    {
        private NotificationStudent notificationControl;

        public StudentForm()
        {
            InitializeComponent();
            Hello_student.BackColor = Color.Transparent;

        }
        private void LoadUserControl(UserControl uc)
        {
            panel2.Controls.Clear(); // remove old content
            uc.Dock = DockStyle.Fill;   // fill the content area
            panel2.Controls.Add(uc); // show the new screen
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SearchStudent());
        }

        private void Borrowing_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BorrowedBook());
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            notificationControl = new NotificationStudent();

            // Set a distinctive background color to verify it's being added
            notificationControl.BackColor = Color.LightBlue;

            LoadUserControl(notificationControl);

            // Add a visual indicator
            Label debugLabel = new Label();
            debugLabel.Text = "Notifications Panel";
            debugLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            debugLabel.ForeColor = Color.Red;
            debugLabel.AutoSize = true;
            debugLabel.Location = new Point(20, 20);
            notificationControl.Controls.Add(debugLabel);

            MessageBox.Show("Notification control loaded.");
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ProfileStudent());
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Search_btn_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new SearchStudent());
        }

        private void Borrowing_btn_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new BorrowedBook());
        }

        private void Update_btn_Click_1(object sender, EventArgs e)
        {
            notificationControl = new NotificationStudent();

            // Set a distinctive background color to verify it's being added
            notificationControl.BackColor = Color.LightBlue;

            LoadUserControl(notificationControl);


        }

        private void Profile_btn_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new ProfileStudent());
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void Back_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            // Load the default/welcome control again
            welcomeStudent welcomeStudent = new welcomeStudent(); // Make sure this control exists
            welcomeStudent.Dock = DockStyle.Fill;
            panel2.Controls.Add(welcomeStudent);
        }
    }
}
