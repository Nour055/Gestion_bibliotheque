using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace GestionBibliothèque
{
    public partial class NotificationStudent : UserControl
    {
        private Panel containerPanel;
        private FlowLayoutPanel requestPanel;
        private FlowLayoutPanel overduePanel;
        
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";
       
        public NotificationStudent()
        {
            InitializeComponent();
            InitializeNotificationPanels();
            this.Resize += NotificationStudent_Resize;
            this.MinimumSize = new Size(600, 400);
            this.DoubleBuffered = true;



        } 
        private void NotificationStudent_Resize(object sender, EventArgs e)
        {
            if (requestPanel != null && overduePanel != null)
            {
                // Update the width of notification panels to match the container
                foreach (Control c in requestPanel.Controls)
                {
                    if (c is Panel panel)
                    {
                        panel.Width = requestPanel.ClientSize.Width - 25;
                    }
                }

                foreach (Control c in overduePanel.Controls)
                {
                    if (c is Panel panel)
                    {
                        panel.Width = overduePanel.ClientSize.Width - 25;
                    }
                }
            }
        }
        private void InitializeNotificationPanels()
        {
            // General background
            this.BackColor = Color.LightSteelBlue;
            this.Dock = DockStyle.Fill;

            // Container panel - use TableLayoutPanel for better control
            TableLayoutPanel containerPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ColumnCount = 2,
                RowCount = 1,
                ColumnStyles =
        {
            new ColumnStyle(SizeType.Percent, 50F),
            new ColumnStyle(SizeType.Percent, 50F)
        },
                Margin = new Padding(0),
                Padding = new Padding(5)
            };

            // Panel for Requests (left)
            requestPanel = new FlowLayoutPanel
            {
                Name = "requestPanel",
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.LightSteelBlue,
                 AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            Label labelRequests = new Label
            {
                Text = "🔔 Borrowing Requests",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Padding = new Padding(5),
                Margin = new Padding(0, 0, 0, 10)
            };
            requestPanel.Controls.Add(labelRequests);

            // Panel for Overdues (right)
            overduePanel = new FlowLayoutPanel
            {
                Name = "overduePanel",
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.LightSteelBlue,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            Label labelOverdues = new Label
            {
                Text = "⚠️ Warnings",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Padding = new Padding(5),
                Margin = new Padding(0, 0, 0, 10)
            };
            overduePanel.Controls.Add(labelOverdues);

            // Add the two panels to the container
            containerPanel.Controls.Add(requestPanel, 0, 0);
            containerPanel.Controls.Add(overduePanel, 1, 0);

            // Finally add the container to the control
            this.Controls.Add(containerPanel);
        }
        public void LoadRequests()
        {
            string query = @"
                SELECT b.ID, b.Borrower_ID, s.Nom AS StudentName, l.Titre AS BookTitle, b.Status
                FROM Borrowings b
                JOIN Student s ON b.Borrower_id = s.ID_Student
                JOIN Livres l ON b.Book_id = l.ITEMID
                WHERE b.Status IN ('Accepted', 'Rejected', 'Borrowed')"; // Include different statuses

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string student = reader["StudentName"].ToString();
                        string title = reader["BookTitle"].ToString();
                        int borrowingId = Convert.ToInt32(reader["ID"]);
                        string status = reader["Status"].ToString();

                        // Based on the status, create different notifications
                        if (status == "Declined")
                        {
                            string message = $"Cher {student},\n" +
                                             $"Nous regrettons de vous informer que votre demande d'emprunt de \"{title}\" a été refusée.\n" +
                                             "Cela peut être dû à une indisponibilité ou des restrictions d'emprunt.\n" +
                                             "N'hésitez pas à explorer d'autres titres disponibles dans la bibliothèque.\n" +
                                             "Merci de votre compréhension !";
                            CreateNotification(message, Color.LightCoral, borrowingId, requestPanel);
                        }
                        else if (status == "Borrowed")
                        {
                            string message = $"Cher {student},\n" +
                                             $"Votre demande d'emprunt de \"{title}\" a été approuvée.\n" +
                                             $"Le livre est maintenant disponible pour retrait et doit être retourné avant le {DateTime.Now.AddDays(15):dd MMMM yyyy}.\n" +
                                             "Bonne lecture ! 📚";
                            CreateNotification(message, Color.LightGreen, borrowingId, requestPanel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement des demandes : " + ex.Message);
                }
            }
        }

        public void LoadOverdues()
        {
            string query = @"
                SELECT b.Borrower_Id, s.Nom AS StudentName, l.Titre AS Book_Title, b.Due_Date
                FROM Borrowings b
                JOIN Student s ON b.Borrower_Id = s.ID_Student
                JOIN Livres l ON b.Book_id = l.ITEMID
                WHERE b.Status = 'Warned'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int borrowerId = Convert.ToInt32(reader["Borrower_Id"]);
                        string student = reader["StudentName"].ToString();
                        string title = reader["BookTitle"].ToString();
                        DateTime dueDate = (DateTime)reader["Due_Date"];

                        string message = $"⚠️ Warning : Cher {student},\n" +
                                         $"Notre système indique que le livre \"{title}\" était dû le {dueDate:dd MMMM yyyy} et n'a pas encore été rendu.\n" +
                                         "Nous vous prions de bien vouloir le retourner dès que possible pour éviter toute pénalité de retard.\n" +
                                         "Merci pour votre coopération et compréhension.";

                        CreateNotification(message, Color.LightCoral, borrowerId, overduePanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement des retards : " + ex.Message);
                }
            }
        }
        private void CreateNotification(string message, Color bgColor, int borrowingId, FlowLayoutPanel destinationPanel)
        {
                // Calculate required height based on message length
                int lineCount = message.Split('\n').Length;
                int estimatedHeight = 80 + (lineCount * 15);

                // Create notification panel
                Panel notifPanel = new Panel
                {
                    Width = destinationPanel.ClientSize.Width - 25, // Account for scrollbar
                    Height = Math.Min(Math.Max(estimatedHeight, 80), 200), // Set min and max height
                    BackColor = bgColor,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10)
                };

                // Label for message
                Label label = new Label
                {
                    Text = message,
                    Dock = DockStyle.Top,
                    AutoSize = false,
                    Width = notifPanel.Width - 20,
                    Height = notifPanel.Height - 40,
                    Font = new Font("Segoe UI", 9),
                    Cursor = Cursors.Hand
                };

                // Button to dismiss
                Button btnOK = new Button
                {
                    Text = "OK",
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                    Width = 60,
                    Height = 25,
                    Tag = borrowingId,
                    Margin = new Padding(0, 10, 0, 0)
                };

                // Event handlers
                label.Click += (sender, e) => ShowExpandedNotification(message);
                btnOK.Click += (s, e) => destinationPanel.Controls.Remove(notifPanel);

                // Add controls to panel
                notifPanel.Controls.Add(label);
                notifPanel.Controls.Add(btnOK);

                // Add to destination panel
                destinationPanel.Controls.Add(notifPanel);
            }


        private void ShowExpandedNotification(string message)
        {
            Form expandedNotificationForm = new Form
            {
                Text = "Notification Details",
                Size = new Size(500, 300),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            TextBox messageBox = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                Text = message,
                Font = new Font("Segoe UI", 10),
                ScrollBars = ScrollBars.Vertical
            };

            expandedNotificationForm.Controls.Add(messageBox);
            expandedNotificationForm.ShowDialog();
        }

        private void NotificationStudent_Load(object sender, EventArgs e)
        {
            LoadOverdues();
            LoadRequests();
        }
    }
}
