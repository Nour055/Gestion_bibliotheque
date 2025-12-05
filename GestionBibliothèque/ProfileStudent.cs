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
using System.Xml.Linq;

namespace GestionBibliothèque
{
    public partial class ProfileStudent : UserControl
    {
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";
        public ProfileStudent()
        {
            InitializeComponent();
            combo_sex.Items.Add("Women");
            combo_sex.Items.Add("Man");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txt_phone.Text, out long phoneNumber))
            {
                MessageBox.Show("Le numéro de téléphone doit être numérique.");
                return;
            }

            if (!int.TryParse(txt_postal.Text, out int postalCode))
            {
                MessageBox.Show("Le code postal doit être numérique.");
                return;
            }
            // Validation du CIN (doit être composé de 8 chiffres)
            if (txt_cin.Text.Length != 8 || !txt_cin.Text.All(char.IsDigit))
            {
                MessageBox.Show("Le CIN doit être composé de 8 chiffres.");
                return;
            }


            // Update query for updating student data
            string updateQuery = @"
            UPDATE Student
            SET Sex = @Sex,
                Nom = @Nom,
                Phone_Number = @PhoneNumber,
                Adresse_Mail = @EmailAddress,
                Postal_Adress = @PostalAddress,
                CIN = @CIN,
                Code_Postal = @CodePostal
            WHERE ID_Student = @ID_Student";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@ID_Student", txt_id.Text);
                cmd.Parameters.AddWithValue("@Sex", combo_sex.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Nom", txt_name.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txt_phone.Text);
                cmd.Parameters.AddWithValue("@EmailAddress", txt_email.Text);
                cmd.Parameters.AddWithValue("@PostalAddress", txt_adress.Text);
                cmd.Parameters.AddWithValue("@CIN", txt_cin.Text);
                cmd.Parameters.AddWithValue("@CodePostal", txt_postal.Text);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profil mis à jour avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Aucune modification détectée.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                }
            }
        }

        private void ProfileStudent_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }
        private void LoadStudentData()
        {

            string currentEmail = SessionUtilisateur.Email;  // Assuming the current logged-in student's email is available

            string query = "SELECT * FROM Student WHERE Adresse_Mail = @Email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", currentEmail); // Use the logged-in user's email

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_id.Text = reader["ID_Student"].ToString();
                        combo_sex.SelectedItem = reader["Sex"].ToString();
                        txt_name.Text = reader["Nom"].ToString();
                        txt_phone.Text = reader["Phone_Number"].ToString();
                        txt_email.Text = reader["Adresse_Mail"].ToString();
                        txt_adress.Text = reader["Postal_Adress"].ToString();
                        txt_cin.Text = reader["CIN"].ToString();
                        txt_postal.Text = reader["Code_Postal"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement du profil : " + ex.Message);
                }
            }
        }
    }
}
    

