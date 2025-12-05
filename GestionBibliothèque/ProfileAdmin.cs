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

namespace GestionBibliothèque
{
    public partial class profileAdmin : UserControl
    {
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";
        private string currentEmail; // Email de l'admin connecté

        public profileAdmin()
        {
            InitializeComponent();

            LoadAdminData();
            combo_sex.Items.Add("Women");
            combo_sex.Items.Add("Man");

            combo_role.Items.Add("Admin");
            combo_role.Items.Add("Assistant");
            combo_role.Items.Add("Manager");
            combo_role.Items.Add("Librarian");
        }
        private void LoadAdminData()
        {
            string currentEmail = SessionUtilisateur.Email;

            string query = "SELECT * FROM Admin WHERE Adresse_Mail = @mail";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mail", currentEmail);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Correctly assign each value to the corresponding TextBox
                        txt_id.Text = reader["ID_Admin"].ToString();

                        // Ensure you properly split and assign the name fields
                        txt_name.Text = reader["Nom"].ToString() + " " + reader["Prénom"].ToString();

                        txt_mail.Text = reader["Adresse_Mail"].ToString();
                        combo_sex.SelectedItem = reader["Sex"].ToString();
                        txt_adress.Text = reader["Postal_adress"].ToString();
                        txt_phone.Text = reader["phone_number"].ToString();
                        combo_role.SelectedItem = reader["Role"].ToString();
                        txt_postal.Text = reader["Postal_code"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
                }
            }
        }
        private void profile_Load(object sender, EventArgs e)
        {

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
            string updateQuery = @"
        UPDATE Admin 
        SET Nom = @nom, 
            Prénom = @prenom, 
            Adresse_Mail = @mail, 
            Sex = @sex,
            Postal_adress = @address,
            phone_number = @phone,
            Role = @role,
            Postal_code = @postalcode
        WHERE ID_Admin = @id"; // Assure-toi que c’est bien ID_Admin, pas juste Id

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", txt_id.Text);

                // Séparer nom et prénom depuis txt_fullname
                string[] fullname = txt_name.Text.Trim().Split(' ');
                string nom = fullname.Length > 0 ? fullname[0] : "";
                string prenom = fullname.Length > 1 ? string.Join(" ", fullname.Skip(1)) : "";

                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@mail", txt_mail.Text);
                cmd.Parameters.AddWithValue("@sex", combo_sex.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@address", txt_adress.Text);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@role", combo_role.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@postalcode", txt_postal.Text);

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
                    MessageBox.Show("Erreur de mise à jour : " + ex.Message);
                }
            }
        }

        private void combo_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
