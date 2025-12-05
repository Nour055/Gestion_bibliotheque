namespace GestionBibliothèque
{
    partial class Update
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
            button1 = new Button();
            label5 = new Label();
            txt_quan = new TextBox();
            label4 = new Label();
            txt_title = new TextBox();
            label3 = new Label();
            txt_category = new TextBox();
            label2 = new Label();
            txt_author = new TextBox();
            label1 = new Label();
            txt_id = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(269, 478);
            button1.Name = "button1";
            button1.Size = new Size(139, 30);
            button1.TabIndex = 23;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(285, 375);
            label5.Name = "label5";
            label5.Size = new Size(70, 22);
            label5.TabIndex = 22;
            label5.Text = "Quantity";
            // 
            // txt_quan
            // 
            txt_quan.BackColor = Color.Thistle;
            txt_quan.Location = new Point(240, 400);
            txt_quan.Name = "txt_quan";
            txt_quan.Size = new Size(177, 27);
            txt_quan.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(375, 148);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 20;
            label4.Text = "Book Title";
            // 
            // txt_title
            // 
            txt_title.BackColor = Color.Thistle;
            txt_title.Location = new Point(375, 179);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(214, 27);
            txt_title.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(119, 270);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 18;
            label3.Text = "Author";
            label3.Click += label3_Click;
            // 
            // txt_category
            // 
            txt_category.BackColor = Color.Thistle;
            txt_category.Location = new Point(375, 295);
            txt_category.Name = "txt_category";
            txt_category.Size = new Size(207, 27);
            txt_category.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(375, 270);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 16;
            label2.Text = "Category";
            // 
            // txt_author
            // 
            txt_author.BackColor = Color.Thistle;
            txt_author.Location = new Point(119, 295);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(207, 27);
            txt_author.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(119, 148);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 14;
            label1.Text = "Book ID ";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.Thistle;
            txt_id.Location = new Point(119, 179);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(207, 27);
            txt_id.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_removebg_preview__6_;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 140);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txt_quan);
            Controls.Add(label4);
            Controls.Add(txt_title);
            Controls.Add(label3);
            Controls.Add(txt_category);
            Controls.Add(label2);
            Controls.Add(txt_author);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Controls.Add(pictureBox1);
            Name = "Update";
            Size = new Size(707, 566);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox txt_quan;
        private Label label4;
        private TextBox txt_title;
        private Label label3;
        private TextBox txt_category;
        private Label label2;
        private TextBox txt_author;
        private Label label1;
        private TextBox txt_id;
        private PictureBox pictureBox1;
    }
}
