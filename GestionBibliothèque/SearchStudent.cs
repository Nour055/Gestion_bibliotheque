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
using System.Net;

namespace GestionBibliothèque
{
    public partial class SearchStudent : UserControl
    {
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";

        public SearchStudent()
        {
            InitializeComponent();
            InitializeListView();
            this.Load += SearchStudent_Load;
        }
        private void SearchBooks(string columnName, string keyword)
        {
            string query = $@"SELECT ITEMID, Titre, Auteur, Category, Quantity
                      FROM Livres
                      WHERE LOWER({columnName}) LIKE LOWER(@kw)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    listView1.Items.Clear();

                    int count = 0; // compteur de résultats

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ITEMID"].ToString());
                        item.SubItems.Add(reader["Titre"].ToString());
                        item.SubItems.Add(reader["Auteur"].ToString());
                        item.SubItems.Add(reader["Category"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());


                        listView1.Items.Add(item);
                        count++;
                    }

                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de recherche :\n" + ex.Message);
                }
            }
        }
       
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ITEMID", 80);
            listView1.Columns.Add("Titre", 150);
            listView1.Columns.Add("Auteur", 120);
            listView1.Columns.Add("Category", 100);
            listView1.Columns.Add("Quantity", 70);

        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {
            comboBox1.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Category FROM Livres", conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string cat = reader["Category"].ToString();
                        if (!string.IsNullOrWhiteSpace(cat))
                        {
                            comboBox1.Items.Add(cat);
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des catégories :\n" + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un livre à demander.");
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];
            string bookTitle = selectedItem.SubItems[1].Text;

            int bookId = GetBookIdByTitle(bookTitle);
            if (bookId == 0)
            {
                MessageBox.Show("Livre introuvable.");
                return;
            }
            int borrowerId = SessionUtilisateur.Id;
            string borrower_name = GetNameByID(borrowerId.ToString()); // corrigé ici
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            SendRequestToDatabase(bookId, date, borrowerId, bookTitle, borrower_name);
        }
        private int GetBookIdByTitle(string bookTitle)
        {
            int bookId = 0;

            string query = "SELECT ITEMID FROM Livres WHERE Titre = @title";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@title", bookTitle);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si un livre avec ce titre existe, récupérer son ID
                        bookId = Convert.ToInt32(reader["ITEMID"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de l'ID du livre :\n" + ex.Message);
                }
            }

            return bookId;
        }
        private string GetNameByID(string borrowerID)
        {
            string NOM = "";

            string query = "SELECT Nom FROM Student WHERE ID_Student = @ID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", borrowerID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        NOM = reader["Nom"].ToString();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de l'ID du livre :\n" + ex.Message);
                }
            }

            return NOM;
        }
        private void SendRequestToDatabase(int bookId, string date, int borrowerId, string bookTitle, string borrower_name)
        {
            string borrowingId = "BORR-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + new Random().Next(1000, 9999);

            string query = @"INSERT INTO Borrowings (ID, Book_Id, Borrowing_Date, Borrower_Id, Book_Title, Borrower_Name) 
                     VALUES (@id, @bookId, @date, @borrowerId, @bookTitle, @borrower_name);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", borrowingId);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(date));
                cmd.Parameters.AddWithValue("@borrowerId", borrowerId);
                cmd.Parameters.AddWithValue("@bookTitle", bookTitle);
                cmd.Parameters.AddWithValue("@borrower_name", borrower_name);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Demande enregistrée dans la base de données avec l'ID : " + borrowingId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement :\n" + ex.Message);
                }
            }
        }





        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string category = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.");
                return;
            }

            SearchBooks("Category", category);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Veuillez saisir un titre.");
                return;
            }

            SearchBooks("Titre", keyword);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string keyword = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Veuillez saisir un auteur.");
                return;
            }

            SearchBooks("Auteur", keyword);
        }
    }
}
