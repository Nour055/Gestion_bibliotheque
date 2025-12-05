namespace GestionBibliothèque
{
    partial class WelcomeAdmincs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeAdmincs));
            pointerTriangle1 = new PointerTriangle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pointerTriangle1
            // 
            pointerTriangle1.BackColor = Color.Transparent;
            pointerTriangle1.FillColor = Color.LightSteelBlue;
            pointerTriangle1.Location = new Point(482, 122);
            pointerTriangle1.Name = "pointerTriangle1";
            pointerTriangle1.Size = new Size(100, 83);
            pointerTriangle1.TabIndex = 18;
            pointerTriangle1.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(26, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 308);
            panel1.TabIndex = 17;
            panel1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(520, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 569);
            label2.Name = "label2";
            label2.Size = new Size(137, 16);
            label2.TabIndex = 15;
            label2.Text = "-Henry Ward Beecher";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(31, 140);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(551, 389);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 533);
            label1.Name = "label1";
            label1.Size = new Size(282, 36);
            label1.TabIndex = 14;
            label1.Text = "\"A library is not a luxury but one of the\r\n necessities of life.\"";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-5, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 120);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // WelcomeAdmincs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pointerTriangle1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "WelcomeAdmincs";
            Size = new Size(610, 597);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PointerTriangle pointerTriangle1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
