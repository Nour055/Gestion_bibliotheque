namespace GestionBibliothèque
{
    partial class SearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBook));
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_title = new TextBox();
            txt_author = new TextBox();
            search_title = new PictureBox();
            search_author = new PictureBox();
            search_category = new PictureBox();
            list_category = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_title).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_author).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_category).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.Thistle;
            listView1.Location = new Point(62, 308);
            listView1.Name = "listView1";
            listView1.Size = new Size(552, 245);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_removebg_preview__6_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(83, 137);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 3;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(351, 137);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 4;
            label2.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(213, 221);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 5;
            label3.Text = "Author";
            // 
            // txt_title
            // 
            txt_title.BackColor = Color.Thistle;
            txt_title.Location = new Point(351, 161);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(179, 27);
            txt_title.TabIndex = 6;
            // 
            // txt_author
            // 
            txt_author.BackColor = Color.Thistle;
            txt_author.Location = new Point(213, 245);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(201, 27);
            txt_author.TabIndex = 7;
            // 
            // search_title
            // 
            search_title.Image = (Image)resources.GetObject("search_title.Image");
            search_title.Location = new Point(536, 161);
            search_title.Name = "search_title";
            search_title.Size = new Size(26, 28);
            search_title.SizeMode = PictureBoxSizeMode.CenterImage;
            search_title.TabIndex = 8;
            search_title.TabStop = false;
            search_title.Click += search_title_Click;
            // 
            // search_author
            // 
            search_author.Image = (Image)resources.GetObject("search_author.Image");
            search_author.Location = new Point(420, 245);
            search_author.Name = "search_author";
            search_author.Size = new Size(31, 27);
            search_author.SizeMode = PictureBoxSizeMode.CenterImage;
            search_author.TabIndex = 10;
            search_author.TabStop = false;
            search_author.Click += search_author_Click;
            // 
            // search_category
            // 
            search_category.Image = (Image)resources.GetObject("search_category.Image");
            search_category.Location = new Point(289, 164);
            search_category.Name = "search_category";
            search_category.Size = new Size(32, 25);
            search_category.SizeMode = PictureBoxSizeMode.CenterImage;
            search_category.TabIndex = 11;
            search_category.TabStop = false;
            search_category.Click += search_category_Click;
            // 
            // list_category
            // 
            list_category.BackColor = Color.Thistle;
            list_category.FormattingEnabled = true;
            list_category.Location = new Point(83, 164);
            list_category.Name = "list_category";
            list_category.Size = new Size(194, 28);
            list_category.TabIndex = 12;
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(list_category);
            Controls.Add(search_category);
            Controls.Add(search_author);
            Controls.Add(search_title);
            Controls.Add(txt_author);
            Controls.Add(txt_title);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Name = "SearchBook";
            Size = new Size(667, 625);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_title).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_author).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_category).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_title;
        private TextBox txt_author;
        private PictureBox search_title;
        private PictureBox search_category;
        private PictureBox search_author;
        private ComboBox list_category;
    }
}
