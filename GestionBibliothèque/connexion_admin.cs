using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GestionBibliothèque
{
    public partial class connexion_admin : Form
    {
        public connexion_admin()
        {
            InitializeComponent();
            Password.PasswordChar = '*';  // Affiche * au lieu des caractères


            // Setup visuals
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            linkLabel1.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;

            // Hide progress and loading label by default
            progressBar1.Visible = false;
            label4.Visible = false;

            // Setup ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Step = 2;

            // Setup Timer
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;");
        }

        private bool TryLogin(string email, string password)
        {
            string query = "SELECT * FROM Admin WHERE Adresse_Mail = @username AND Mot_de_passe = @password";

            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Stocker les données dans la session

                        SessionUtilisateur.Email = reader["Adresse_mail"].ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Email.Text.Trim();
            string password = Password.Text.Trim();

            if (TryLogin(username, password))
            {
                // Connexion réussie
                label2.Visible = false;
                label3.Visible = false;
                linkLabel1.Visible = false;
                Email.Visible = false;
                Password.Visible = false;
                button1.Visible = false;
                label4.Visible = true;
                pictureBox2.Visible = false;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                // Transition to Admin Form
                this.Hide();
                new AdminForm().Show();
            }
        }

        private void connexion_admin_Load(object sender, EventArgs e)
        {
            // Optional: anything on load
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string email = Email.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Veuillez entrer votre adresse e-mail pour récupérer l'indice !");
                return;
            }

            string query = "SELECT Indicatiom_mdp FROM Admin WHERE Adresse_Mail = @Email";

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string indication = result.ToString();
                        MessageBox.Show($"Indice pour récupérer votre mot de passe : {indication}", "Mot de passe oublié", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Aucune indication trouvée pour cet e-mail.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de l'indice :\n" + ex.Message);
                }
            }
        }
        private bool isPasswordVisible = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                // Cacher le mot de passe
                Password.PasswordChar = '*';
                isPasswordVisible = false;
            }
            else
            {
                // Afficher le mot de passe
                Password.PasswordChar = '\0'; // '\0' = caractère vide = texte visible
                isPasswordVisible = true;
            }
        }
    }
}
