namespace GestionBibliothèque
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel_menu = new Panel();
            button1 = new Button();
            Back = new PictureBox();
            Hello_admin = new Label();
            Profile_btn = new Button();
            Update_btn = new Button();
            Borrowing_btn = new Button();
            Search_btn = new Button();
            add_book_btn = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            listViewOverdues = new Panel();
            pointerTriangle1 = new PointerTriangle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            listViewOverdues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.BackgroundImage = (Image)resources.GetObject("panel_menu.BackgroundImage");
            panel_menu.Controls.Add(button1);
            panel_menu.Controls.Add(Back);
            panel_menu.Controls.Add(Hello_admin);
            panel_menu.Controls.Add(Profile_btn);
            panel_menu.Controls.Add(Update_btn);
            panel_menu.Controls.Add(Borrowing_btn);
            panel_menu.Controls.Add(Search_btn);
            panel_menu.Controls.Add(add_book_btn);
            panel_menu.Location = new Point(-1, 1);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(300, 627);
            panel_menu.TabIndex = 0;
            panel_menu.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 584);
            button1.Name = "button1";
            button1.Size = new Size(279, 43);
            button1.TabIndex = 20;
            button1.Text = "Sign out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Back
            // 
            Back.ErrorImage = (Image)resources.GetObject("Back.ErrorImage");
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(239, 0);
            Back.Name = "Back";
            Back.Size = new Size(40, 40);
            Back.SizeMode = PictureBoxSizeMode.StretchImage;
            Back.TabIndex = 19;
            Back.TabStop = false;
            Back.Click += Back_Click;
            // 
            // Hello_admin
            // 
            Hello_admin.AutoSize = true;
            Hello_admin.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hello_admin.Location = new Point(50, 111);
            Hello_admin.Name = "Hello_admin";
            Hello_admin.Size = new Size(187, 33);
            Hello_admin.TabIndex = 9;
            Hello_admin.Text = "Hello Admin!";
            // 
            // Profile_btn
            // 
            Profile_btn.BackColor = Color.Gainsboro;
            Profile_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Profile_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Profile_btn.Image = (Image)resources.GetObject("Profile_btn.Image");
            Profile_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Profile_btn.Location = new Point(-3, 357);
            Profile_btn.Name = "Profile_btn";
            Profile_btn.Size = new Size(282, 45);
            Profile_btn.TabIndex = 4;
            Profile_btn.Text = "Profile";
            Profile_btn.UseVisualStyleBackColor = false;
            Profile_btn.Click += Profile_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.BackColor = Color.Gainsboro;
            Update_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Update_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Update_btn.Image = (Image)resources.GetObject("Update_btn.Image");
            Update_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Update_btn.Location = new Point(0, 313);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(279, 49);
            Update_btn.TabIndex = 3;
            Update_btn.Text = "Book Update";
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // Borrowing_btn
            // 
            Borrowing_btn.BackColor = Color.Gainsboro;
            Borrowing_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Borrowing_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Borrowing_btn.Image = (Image)resources.GetObject("Borrowing_btn.Image");
            Borrowing_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Borrowing_btn.Location = new Point(-3, 270);
            Borrowing_btn.Name = "Borrowing_btn";
            Borrowing_btn.Size = new Size(282, 47);
            Borrowing_btn.TabIndex = 2;
            Borrowing_btn.Text = "Borrowing Books";
            Borrowing_btn.UseVisualStyleBackColor = false;
            Borrowing_btn.Click += Borrowing_btn_Click;
            // 
            // Search_btn
            // 
            Search_btn.BackColor = Color.Gainsboro;
            Search_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Search_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_btn.Image = (Image)resources.GetObject("Search_btn.Image");
            Search_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Search_btn.Location = new Point(-3, 226);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(282, 50);
            Search_btn.TabIndex = 1;
            Search_btn.Text = "Search Book";
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += Search_btn_Click;
            // 
            // add_book_btn
            // 
            add_book_btn.BackColor = Color.Gainsboro;
            add_book_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_book_btn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_book_btn.Image = (Image)resources.GetObject("add_book_btn.Image");
            add_book_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_book_btn.Location = new Point(0, 182);
            add_book_btn.Name = "add_book_btn";
            add_book_btn.Size = new Size(279, 50);
            add_book_btn.TabIndex = 0;
            add_book_btn.Text = "Add Book";
            add_book_btn.UseVisualStyleBackColor = false;
            add_book_btn.Click += add_book_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, -15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 120);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 520);
            label1.Name = "label1";
            label1.Size = new Size(282, 36);
            label1.TabIndex = 7;
            label1.Text = "\"A library is not a luxury but one of the\r\n necessities of life.\"";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(54, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(551, 389);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 556);
            label2.Name = "label2";
            label2.Size = new Size(137, 16);
            label2.TabIndex = 8;
            label2.Text = "-Henry Ward Beecher";
            // 
            // listViewOverdues
            // 
            listViewOverdues.BorderStyle = BorderStyle.Fixed3D;
            listViewOverdues.Controls.Add(pointerTriangle1);
            listViewOverdues.Controls.Add(panel1);
            listViewOverdues.Controls.Add(pictureBox1);
            listViewOverdues.Controls.Add(label2);
            listViewOverdues.Controls.Add(pictureBox3);
            listViewOverdues.Controls.Add(label1);
            listViewOverdues.Controls.Add(pictureBox2);
            listViewOverdues.Location = new Point(274, 1);
            listViewOverdues.Name = "listViewOverdues";
            listViewOverdues.Size = new Size(630, 627);
            listViewOverdues.TabIndex = 1;
            // 
            // pointerTriangle1
            // 
            pointerTriangle1.BackColor = Color.Transparent;
            pointerTriangle1.FillColor = Color.LightSteelBlue;
            pointerTriangle1.Location = new Point(505, 109);
            pointerTriangle1.Name = "pointerTriangle1";
            pointerTriangle1.Size = new Size(100, 83);
            pointerTriangle1.TabIndex = 11;
            pointerTriangle1.Visible = false;
            pointerTriangle1.Load += pointerTriangle1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(49, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 308);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(903, 626);
            Controls.Add(listViewOverdues);
            Controls.Add(panel_menu);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel_menu.ResumeLayout(false);
            panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            listViewOverdues.ResumeLayout(false);
            listViewOverdues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_menu;
        private Button add_book_btn;
        private Button Update_btn;
        private Button Borrowing_btn;
        private Button Search_btn;
        private Label label3;
        private Button Profile_btn;
        private Label Hello_admin;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
        private Panel listViewOverdues;
        private PictureBox Back;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PointerTriangle pointerTriangle1;
        private Button button1;
    }
}