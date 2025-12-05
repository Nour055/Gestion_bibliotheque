namespace GestionBibliothèque
{
    partial class welcomeStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeStudent));
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(454, 486);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 16;
            label2.Text = "-Jhumpa Lahiri";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(72, 96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(507, 340);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 439);
            label1.Name = "label1";
            label1.Size = new Size(357, 36);
            label1.TabIndex = 15;
            label1.Text = "\"That’s the thing about books. They let you travel \r\nwithout moving your feet.\"";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // welcomeStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "welcomeStudent";
            Size = new Size(628, 519);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
