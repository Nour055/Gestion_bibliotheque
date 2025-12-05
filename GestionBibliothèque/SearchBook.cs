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
    public partial class SearchBook : UserControl
    {
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";

        public SearchBook()
        {
            InitializeComponent();
            InitializeListView();
            this.Load += SearchBook_Load;
        }



        private void SearchBooks(string columnName, string keyword)
        {
            string query = $@"SELECT ITEMID, Titre, Auteur, Category, Quantity, D_creation, D_modif 
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
                        item.SubItems.Add(reader["D_creation"].ToString());
                        item.SubItems.Add(reader["D_modif"].ToString());

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

        private void search_category_Click(object sender, EventArgs e)
        {
            string category = list_category.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.");
                return;
            }

            SearchBooks("Category", category);
        }

        private void search_title_Click(object sender, EventArgs e)
        {
            string keyword = txt_title.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Veuillez saisir un titre.");
                return;
            }

            SearchBooks("Titre", keyword);
        }

        private void search_author_Click(object sender, EventArgs e)
        {
            string keyword = txt_author.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Veuillez saisir un auteur.");
                return;
            }

            SearchBooks("Auteur", keyword);
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
            listView1.Columns.Add("D_Creation", 120);
            listView1.Columns.Add("D_Modif", 120);
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {
            list_category.Items.Clear();

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
                            list_category.Items.Add(cat);
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
    }
}
