using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GestionBibliothèque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            Image original = Image.FromFile("stop.png");
            pictureBox2.Image = SetImageOpacity(original, 0.7f);
            panelContainer.BackColor = Color.LightBlue;
            panelContainer.Controls.Add(Admin);
            panelContainer.Controls.Add(Student);

            Admin.BringToFront();
            Admin.BackColor = Color.Transparent;

            Student.BackColor = Color.Transparent;
            Student.BringToFront();
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;



        }
        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = opacity // Opacity: 0.0 = fully transparent, 1.0 = fully opaque
                };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                              0, 0, image.Width, image.Height,
                              GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            connexion_admin formAdmin = new connexion_admin();
            formAdmin.Show(); // Affiche le formulaire
            this.Hide(); // Cache le formulaire actuel (facultatif)
        }

        private void Student_Click(object sender, EventArgs e)
        {
            connexion_student formAdmin = new connexion_student();
            formAdmin.Show(); // Affiche le formulaire
            this.Hide(); // Cache le formulaire actuel (facultatif)
        }
    }
}
