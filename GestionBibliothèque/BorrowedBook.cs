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
    public partial class BorrowedBook : UserControl
    {
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";

        public BorrowedBook()
        {
            InitializeComponent();
            InitializeListViews(); // Initialisation des colonnes des ListViews

            LoadBorrowedBooks();
        }
        private void InitializeListViews()
        {
            // Colonnes pour les livres actuellement empruntés
            listViewCurrentBorrowings.View = View.Details;
            listViewCurrentBorrowings.Columns.Add("Book ID", 100);  // Largeur de 100 pixels
            listViewCurrentBorrowings.Columns.Add("Book Title", 200); // Largeur de 200 pixels
            listViewCurrentBorrowings.Columns.Add("Borrowed Date", 150); // Largeur de 150 pixels

            // Colonnes pour l'historique des emprunts
            listViewBorrowingHistory.View = View.Details;
            listViewBorrowingHistory.Columns.Add("Book ID", 100);  // Largeur de 100 pixels
            listViewBorrowingHistory.Columns.Add("Book Title", 200); // Largeur de 200 pixels
            listViewBorrowingHistory.Columns.Add("Borrowed Date", 150); // Largeur de 150 pixels
            listViewBorrowingHistory.Columns.Add("Return Date", 150);  // Largeur de 150 pixels
        }
        private void LoadBorrowedBooks()
        {
            // Load Currently Borrowed Books
            LoadCurrentlyBorrowedBooks();

            // Load Borrowing History
            LoadBorrowingHistory();
        }
        private void LoadCurrentlyBorrowedBooks()
        {
            string query = @"
                SELECT Book_Id, Book_Title, Borrowing_Date
                FROM Borrowings
               WHERE Status='Borrowed'"; // Only currently borrowed books

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    listViewCurrentBorrowings.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Book_Id"].ToString());
                        item.SubItems.Add(reader["Book_Title"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["Borrowing_Date"]).ToString("dd/MM/yyyy"));
                        listViewCurrentBorrowings.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading current borrowed books: " + ex.Message);
                }
            }
        }

        private void LoadBorrowingHistory()
        {
            string query = @"
        SELECT Book_Id, Book_Title, Borrowing_Date, Return_Date
        FROM Borrowings
        WHERE Status='Returned'"; // Only returned books

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    listViewBorrowingHistory.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Book_Id"].ToString());
                        item.SubItems.Add(reader["Book_Title"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["Borrowing_Date"]).ToString("dd/MM/yyyy"));

                        // Check if Return_Date is NULL
                        string returnDate = reader["Return_Date"] == DBNull.Value ? "Not Returned Yet" : Convert.ToDateTime(reader["Return_Date"]).ToString("dd/MM/yyyy");
                        item.SubItems.Add(returnDate);

                        listViewBorrowingHistory.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading borrowing history: " + ex.Message);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
