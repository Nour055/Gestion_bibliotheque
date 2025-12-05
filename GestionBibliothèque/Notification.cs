using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionBibliothèque
{
    public partial class Notification : UserControl
    {
        private Panel containerPanel;
        private FlowLayoutPanel requestPanel;
        private FlowLayoutPanel overduePanel;

        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";
     

        public Notification()
        {
            InitializeComponent();
            InitializeNotificationPanels();

        }

        private void Notification_Load(object sender, EventArgs e)
        {
            LoadRequests();
            LoadOverdues();
        }
        private void InitializeNotificationPanels()
        {
            // General background
            this.BackColor = Color.LightSteelBlue;
            this.Dock = DockStyle.Fill;

            // Container panel
            containerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            // Panel for Requests (left)
            requestPanel = new FlowLayoutPanel
            {
                Name = "requestPanel",
                Dock = DockStyle.Left,
                Width = this.Width / 2, // Half of the UserControl width
                AutoScroll = true,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.LightSteelBlue
            };

            Label labelRequests = new Label
            {
                Text = "🔔 Borrowing Requests",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Padding = new Padding(5)
            };
            requestPanel.Controls.Add(labelRequests);

            // Panel for Overdues (right)
            overduePanel = new FlowLayoutPanel
            {
                Name = "overduePanel",
                Dock = DockStyle.Fill, // Fills the rest of the space
                AutoScroll = true,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.LightSteelBlue
            };

            Label labelOverdues = new Label
            {
                Text = "📅 Overdues",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Padding = new Padding(5)
            };
            overduePanel.Controls.Add(labelOverdues);

            // Add the two panels to the container
            containerPanel.Controls.Add(overduePanel);
            containerPanel.Controls.Add(requestPanel);

            // Finally add the container to the control
            this.Controls.Add(containerPanel);
        }

        // Simplified LoadRequests method
        public void LoadRequests()
        {
            string query = @"
        SELECT b.ID, b.Borrower_Id, s.Prénom AS BorrowerName, l.Titre AS BookTitle
        FROM Borrowings b
        JOIN Student s ON b.Borrower_id = s.ID_Student
        JOIN Livres l ON b.Book_Id = l.ITEMID
        WHERE b.Status IS NULL";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            string student = reader["BorrowerName"].ToString();
                            string title = reader["BookTitle"].ToString();

                            // Safe ID handling
                            object idValue = reader["ID"];
                            int borrowingId;

                            if (idValue == null || idValue == DBNull.Value || !int.TryParse(idValue.ToString(), out borrowingId))
                            {
                                // Skip or handle invalid IDs
                                Console.WriteLine($"Skipping record with invalid ID: {idValue}");
                                continue;
                            }

                            CreateNotification(
                                $"Demande de prêt : {student} veut emprunter \"{title}\"",
                                Color.LightBlue,
                                borrowingId.ToString(),
                                requestPanel
                            );
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error processing record: {ex.Message}");
                            continue;
                        }
                    }
                }
            }
        }


        public void LoadOverdues()
        {
            string query = @"
        SELECT b.ID, b.Borrower_ID, s.Prénom AS BorrowerName, l.Titre AS BookTitle
        FROM Borrowings b
        JOIN Student s ON b.Borrower_id = s.ID_Student
        JOIN Livres l ON b.Book_id = l.ITEMID
        WHERE b.Status = 'Borrowed' AND b.Due_Date < GETDATE()";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                string student = reader["BorrowerName"].ToString();
                                string title = reader["BookTitle"].ToString();

                                // Safely handle the ID conversion
                                object idValue = reader["ID"];
                                string borrowingId = "0"; // Default to 0 if not valid

                                if (idValue != DBNull.Value && int.TryParse(idValue.ToString(), out int validId))
                                {
                                    borrowingId = validId.ToString();
                                }
                                else
                                {
                                    Console.WriteLine($"Skipping overdue record with invalid ID: {idValue}");
                                    continue;
                                }

                                CreateNotification(
                                    $"📅 Retard : {student} n'a pas rendu \"{title}\"",
                                    Color.LightCoral,
                                    borrowingId,
                                    overduePanel
                                );
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error processing row: {ex.Message}");
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement des retards : " + ex.Message);
            }
        }

        private void UpdateBorrowingStatus(string borrowingId, string newStatus)
        {
            string query = "UPDATE Borrowings SET Status = @Status";
            DateTime? dueDate = null;

            if (newStatus == "Accepted")
            {
                dueDate = DateTime.Now.AddMonths(1);
                query += ", Due_Date = @DueDate";
            }

            query += " WHERE ID = @BorrowingId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int id;
                    if (!int.TryParse(borrowingId, out id))
                    {
                        MessageBox.Show("ID de prêt invalide");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    if (dueDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@DueDate", dueDate.Value);
                    }
                    cmd.Parameters.AddWithValue("@BorrowingId", id);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Aucun enregistrement mis à jour. Vérifiez l'ID du prêt.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur mise à jour du statut : " + ex.Message);
            }
        }

        private void CreateNotification(string message, Color bgColor, string borrowingId, FlowLayoutPanel destinationPanel)
        {
            // Create notification panel
            Panel notifPanel = new Panel
            {
                Width = 400,
                Height = 80,
                BackColor = bgColor,
                Margin = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Message Label
            Label label = new Label
            {
                Text = message,
                AutoSize = false,
                Width = 280,
                Height = 50,
                Location = new Point(10, 10),
                Font = new Font("Segoe UI", 9)
            };

            // Accept Button
            Button btnAccept = new Button
            {
                Text = "Yes",
                Location = new Point(300, 10),
                Width = 60,
                Height = 25,
                Tag = borrowingId  // Store as string, no conversion needed
            };
            btnAccept.Click += (s, e) =>
            {
                UpdateBorrowingStatus((string)btnAccept.Tag, "Accepted");
                destinationPanel.Controls.Remove(notifPanel);
            };

            // Reject Button
            Button btnReject = new Button
            {
                Text = "No",
                Location = new Point(300, 45),
                Width = 60,
                Height = 25,
                Tag = borrowingId  // Store as string, no conversion needed
            };
            btnReject.Click += (s, e) =>
            {
                UpdateBorrowingStatus((string)btnReject.Tag, "Rejected");  // Changed to string cast
                destinationPanel.Controls.Remove(notifPanel);
            };

            // Remove the int parsing - we're keeping borrowingId as string
            // int borrowingIdInt = int.Parse(borrowingId);  <-- Remove this line

            // Add controls
            notifPanel.Controls.Add(label);
            notifPanel.Controls.Add(btnAccept);
            notifPanel.Controls.Add(btnReject);

            destinationPanel.Controls.Add(notifPanel);
        }

       
      


    }
}
