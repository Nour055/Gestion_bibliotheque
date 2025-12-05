namespace GestionBibliothèque
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel_menu = new Panel();
            button1 = new Button();
            Hello_student = new Label();
            Profile_btn = new Button();
            Update_btn = new Button();
            Borrowing_btn = new Button();
            Search_btn = new Button();
            Back = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(230, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 530);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(459, 499);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 12;
            label2.Text = "-Jhumpa Lahiri";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(77, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(507, 340);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 452);
            label1.Name = "label1";
            label1.Size = new Size(357, 36);
            label1.TabIndex = 11;
            label1.Text = "\"That’s the thing about books. They let you travel \r\nwithout moving your feet.\"";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel_menu
            // 
            panel_menu.BackgroundImage = (Image)resources.GetObject("panel_menu.BackgroundImage");
            panel_menu.Controls.Add(Back);
            panel_menu.Controls.Add(button1);
            panel_menu.Controls.Add(Hello_student);
            panel_menu.Controls.Add(Profile_btn);
            panel_menu.Controls.Add(Update_btn);
            panel_menu.Controls.Add(Borrowing_btn);
            panel_menu.Controls.Add(Search_btn);
            panel_menu.Location = new Point(0, 2);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(237, 531);
            panel_menu.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-2, 498);
            button1.Name = "button1";
            button1.Size = new Size(239, 31);
            button1.TabIndex = 21;
            button1.Text = "Sign out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Hello_student
            // 
            Hello_student.AutoSize = true;
            Hello_student.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hello_student.Location = new Point(12, 85);
            Hello_student.Name = "Hello_student";
            Hello_student.Size = new Size(204, 33);
            Hello_student.TabIndex = 14;
            Hello_student.Text = "Hello Student!";
            // 
            // Profile_btn
            // 
            Profile_btn.BackColor = Color.Gainsboro;
            Profile_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Profile_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Profile_btn.Image = (Image)resources.GetObject("Profile_btn.Image");
            Profile_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Profile_btn.Location = new Point(1, 307);
            Profile_btn.Name = "Profile_btn";
            Profile_btn.Size = new Size(236, 45);
            Profile_btn.TabIndex = 13;
            Profile_btn.Text = "Profile";
            Profile_btn.UseVisualStyleBackColor = false;
            Profile_btn.Click += Profile_btn_Click_1;
            // 
            // Update_btn
            // 
            Update_btn.BackColor = Color.Gainsboro;
            Update_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Update_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Update_btn.Image = (Image)resources.GetObject("Update_btn.Image");
            Update_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Update_btn.Location = new Point(1, 266);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(236, 45);
            Update_btn.TabIndex = 12;
            Update_btn.Text = "Notifications";
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click_1;
            // 
            // Borrowing_btn
            // 
            Borrowing_btn.BackColor = Color.Gainsboro;
            Borrowing_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Borrowing_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Borrowing_btn.Image = (Image)resources.GetObject("Borrowing_btn.Image");
            Borrowing_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Borrowing_btn.Location = new Point(2, 226);
            Borrowing_btn.Name = "Borrowing_btn";
            Borrowing_btn.Size = new Size(235, 45);
            Borrowing_btn.TabIndex = 11;
            Borrowing_btn.Text = "Borrowed Books";
            Borrowing_btn.UseVisualStyleBackColor = false;
            Borrowing_btn.Click += Borrowing_btn_Click_1;
            // 
            // Search_btn
            // 
            Search_btn.BackColor = Color.Gainsboro;
            Search_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Search_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_btn.Image = (Image)resources.GetObject("Search_btn.Image");
            Search_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Search_btn.Location = new Point(0, 185);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(237, 45);
            Search_btn.TabIndex = 10;
            Search_btn.Text = "Search Book";
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += Search_btn_Click_1;
            // 
            // Back
            // 
            Back.ErrorImage = (Image)resources.GetObject("Back.ErrorImage");
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(197, 0);
            Back.Name = "Back";
            Back.Size = new Size(40, 40);
            Back.SizeMode = PictureBoxSizeMode.StretchImage;
            Back.TabIndex = 22;
            Back.TabStop = false;
            Back.Click += Back_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 530);
            Controls.Add(panel_menu);
            Controls.Add(panel2);
            Name = "StudentForm";
            Text = "StudentForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_menu.ResumeLayout(false);
            panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel_menu;
        private Label Hello_student;
        private Button Profile_btn;
        private Button Update_btn;
        private Button Borrowing_btn;
        private Button Search_btn;
        private Button button1;
        private PictureBox Back;
    }
}