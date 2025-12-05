namespace GestionBibliothèque
{
    partial class BorrowedBook
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            listViewBorrowingHistory = new ListView();
            listViewCurrentBorrowings = new ListView();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listViewBorrowingHistory
            // 
            listViewBorrowingHistory.BackColor = Color.Thistle;
            listViewBorrowingHistory.Location = new Point(31, 62);
            listViewBorrowingHistory.Name = "listViewBorrowingHistory";
            listViewBorrowingHistory.Size = new Size(561, 199);
            listViewBorrowingHistory.TabIndex = 13;
            listViewBorrowingHistory.UseCompatibleStateImageBehavior = false;
            listViewBorrowingHistory.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // listViewCurrentBorrowings
            // 
            listViewCurrentBorrowings.BackColor = Color.Thistle;
            listViewCurrentBorrowings.Location = new Point(31, 340);
            listViewCurrentBorrowings.Name = "listViewCurrentBorrowings";
            listViewCurrentBorrowings.Size = new Size(569, 172);
            listViewCurrentBorrowings.TabIndex = 14;
            listViewCurrentBorrowings.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 16;
            label1.Text = "My Borrowing History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkBlue;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(31, 304);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 17;
            label2.Text = "My Borrowed books ";
            // 
            // BorrowedBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewCurrentBorrowings);
            Controls.Add(listViewBorrowingHistory);
            Name = "BorrowedBook";
            Size = new Size(731, 562);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewBorrowingHistory;
        private ListView listViewCurrentBorrowings;
        private Label label1;
        private Label label2;
    }
}
