namespace GestionBibliothèque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Admin = new PictureBox();
            Student = new PictureBox();
            panelContainer = new Panel();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Admin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Student).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(198, 74);
            label1.Name = "label1";
            label1.Size = new Size(467, 30);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the IHEC Carthage Library\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(48, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 127);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(160, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(550, 221);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Admin
            // 
            Admin.Image = (Image)resources.GetObject("Admin.Image");
            Admin.Location = new Point(57, -1);
            Admin.Name = "Admin";
            Admin.Size = new Size(185, 158);
            Admin.SizeMode = PictureBoxSizeMode.StretchImage;
            Admin.TabIndex = 4;
            Admin.TabStop = false;
            Admin.Click += Admin_Click;
            // 
            // Student
            // 
            Student.Image = (Image)resources.GetObject("Student.Image");
            Student.Location = new Point(320, 0);
            Student.Name = "Student";
            Student.Size = new Size(173, 135);
            Student.SizeMode = PictureBoxSizeMode.StretchImage;
            Student.TabIndex = 7;
            Student.TabStop = false;
            Student.Click += Student_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(Admin);
            panelContainer.Controls.Add(Student);
            panelContainer.Location = new Point(160, 376);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(550, 190);
            panelContainer.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(360, 160);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 9;
            label3.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(110, 160);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 8;
            label2.Text = "Admin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(796, 599);
            Controls.Add(panelContainer);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "v";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Admin).EndInit();
            ((System.ComponentModel.ISupportInitialize)Student).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox Admin;
        private PictureBox Student;
        private Panel panelContainer;
        private Label label3;
        private Label label2;
    }
}
