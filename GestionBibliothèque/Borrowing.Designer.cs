namespace GestionBibliothèque
{
    partial class Borrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrowing));
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txt_title = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_removebg_preview__6_;
            pictureBox1.Location = new Point(-13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Thistle;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(27, 198);
            listView1.Name = "listView1";
            listView1.Size = new Size(577, 296);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(239, 529);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 3;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(210, 107);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 4;
            label1.Text = "Book Title";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(426, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txt_title
            // 
            txt_title.BackColor = Color.Thistle;
            txt_title.Location = new Point(210, 131);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(210, 27);
            txt_title.TabIndex = 6;
            // 
            // Borrowing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_title);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Name = "Borrowing";
            Size = new Size(665, 599);
            Load += Borrowing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txt_title;
    }
}
