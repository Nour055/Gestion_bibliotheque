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
    public partial class Update : UserControl
    {
        private string connectionString = "Data Source=MEYSDELL;Initial Catalog=IHEC;Integrated Security=True;";

        public Update()
        {
           
            InitializeComponent();
            

            // Add event handler
            //Back.Click += Back_Click;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txt_id.Text) ||
                    string.IsNullOrWhiteSpace(txt_title.Text) ||
                    string.IsNullOrWhiteSpace(txt_author.Text) ||
                    string.IsNullOrWhiteSpace(txt_category.Text) ||
                    string.IsNullOrWhiteSpace(txt_quan.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_quan.Text, out int quantity))
                {
                    MessageBox.Show("Quantity must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = @"UPDATE Livres 
                                     SET Titre = @Title, 
                                         Auteur = @Author, 
                                         Category = @Category, 
                                         Quantity = @Quantity
                                     WHERE ITEMID = @BookID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookID", txt_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@Title", txt_title.Text.Trim());
                            cmd.Parameters.AddWithValue("@Author", txt_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@Category", txt_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@Quantity", quantity);


                            conn.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("No book found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the book:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            txt_id.Clear();
            txt_title.Clear();
            txt_category.Clear();
            txt_author.Clear();
            txt_quan.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm(); // Get the parent form (the form containing the UserControl)

            if (parentForm is AdminForm adminForm)
            {
                // You can close the current UserControl or hide it
                parentForm.Hide(); // Or you could remove the UserControl if needed

                // Open the AdminForm again (or you could just make it visible)
                adminForm.Show();
            }
        }
    }
}
