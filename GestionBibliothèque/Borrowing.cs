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
    public partial class Borrowing : UserControl
    {
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";
        private List<BorrowedBook> allBorrowedBooks = new List<BorrowedBook>();
        private class BorrowedBook
        {
            public string BookId { get; set; }
            public string BorrowerId { get; set; }
            public DateTime BorrowingDate { get; set; }
            public DateTime DueDate { get; set; }
            public string Status { get; set; }
            public string Title { get; set; } // Added book title for searching
        }
        public Borrowing()
        {
            InitializeComponent();
            InitializeListView();
            LoadAllBorrowedBooks();
        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Clear();

            listView1.Columns.Add("Book ID", 100);
            listView1.Columns.Add("Borrower ID", 100);
            listView1.Columns.Add("Borrowing Date", 120);
            listView1.Columns.Add("Due Date", 120);
            listView1.Columns.Add("Status", 120);
            listView1.Columns.Add("Title", 180); // Add the Title column
        }

        private void LoadAllBorrowedBooks()
        {
            allBorrowedBooks.Clear();
            string query = @"
        SELECT b.Book_id, b.Borrower_id, b.Borrowing_Date, b.Due_Date, b.Status, l.Titre 
        FROM Borrowings b
        LEFT JOIN Livres l ON b.Book_id = l.ITEMID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        BorrowedBook book = new BorrowedBook
                        {
                            BookId = reader["Book_Id"] != DBNull.Value ? reader["Book_Id"].ToString() : "N/A",
                            BorrowerId = reader["Borrower_Id"] != DBNull.Value ? reader["Borrower_Id"].ToString() : "N/A",
                            BorrowingDate = reader["Borrowing_Date"] != DBNull.Value ? Convert.ToDateTime(reader["Borrowing_Date"]) : DateTime.MinValue,
                            DueDate = reader["Due_Date"] != DBNull.Value ? Convert.ToDateTime(reader["Due_Date"]) : DateTime.MinValue,
                            Status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "Unknown",
                            Title = reader["Titre"] != DBNull.Value ? reader["Titre"].ToString() : "Unknown"
                        };

                        allBorrowedBooks.Add(book);
                    }

                    reader.Close();

                    // Debug message to check if SQL returned any records

                    // Display all borrowed books initially
                    DisplayBorrowedBooks(allBorrowedBooks);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des emprunts :\n" + ex.Message);
                }
            }
        }
       
        private void DisplayBorrowedBooks(List<BorrowedBook> books)
        {
            listView1.Items.Clear();

            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.BookId);
                item.SubItems.Add(book.BorrowerId);
                item.SubItems.Add(book.BorrowingDate.ToShortDateString());
                item.SubItems.Add(book.DueDate.ToShortDateString());
                item.SubItems.Add(book.Status);
                item.SubItems.Add(book.Title);

                listView1.Items.Add(item);
            }

            // Show a message if no books are found
            if (books.Count == 0)
            {
                MessageBox.Show("Aucun livre emprunté trouvé.");
            }
        }

        private void FilterBorrowedBooks(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                // If search is empty, show all borrowed books
                DisplayBorrowedBooks(allBorrowedBooks);
                return;
            }

            // Filter the list based on the keyword (case-insensitive)
            var filteredBooks = allBorrowedBooks
                .Where(book =>
                    book.BookId.Contains(keyword) ||
                    book.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            DisplayBorrowedBooks(filteredBooks);

            // Inform user if no matching results
            if (filteredBooks.Count == 0)
            {
                MessageBox.Show("Aucun résultat pour : " + keyword);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    string bookId = selectedItem.SubItems[0].Text;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Update Borrowings table
                            string updateBorrowingsQuery = "UPDATE Borrowings SET Status = 'Returned' WHERE Book_id = @id";
                            using (SqlCommand cmdBorrowings = new SqlCommand(updateBorrowingsQuery, conn, transaction))
                            {
                                cmdBorrowings.Parameters.AddWithValue("@id", bookId);
                                cmdBorrowings.ExecuteNonQuery();
                            }

                            // Update Livres table
                            string updateLivresQuery = "UPDATE Livres SET Statut = 'Available' WHERE ITEMID = @id";
                            using (SqlCommand cmdLivres = new SqlCommand(updateLivresQuery, conn, transaction))
                            {
                                cmdLivres.Parameters.AddWithValue("@id", bookId);
                                cmdLivres.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Livre retourné avec succès !");

                            // Reload all borrowed books after return
                            LoadAllBorrowedBooks();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erreur de mise à jour : " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un livre à retourner.");
                }
            }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string keyword = txt_title.Text.Trim();
            FilterBorrowedBooks(keyword);
        }

        private void Borrowing_Load(object sender, EventArgs e)
        {

        }
    }
}
