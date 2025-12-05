namespace GestionBibliothèque
{
    partial class connexion_admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion_admin));
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Password = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            Email = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 118);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(102, 92);
            label1.Name = "label1";
            label1.Size = new Size(238, 34);
            label1.TabIndex = 1;
            label1.Text = "Welcome Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(102, 157);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 3;
            label2.Text = "Email adress";
            // 
            // Password
            // 
            Password.Location = new Point(102, 273);
            Password.Name = "Password";
            Password.Size = new Size(216, 27);
            Password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(102, 240);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 5;
            label3.Text = "Password\r\n";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(284, 303);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Modern No. 20", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(146, 350);
            button1.Name = "button1";
            button1.Size = new Size(130, 31);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(87, 232);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(242, 10);
            progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(91, 183);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 9;
            label4.Text = "Loading...";
            // 
            // Email
            // 
            Email.Location = new Point(102, 199);
            Email.Name = "Email";
            Email.Size = new Size(216, 27);
            Email.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(289, 273);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 27);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // connexion_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(423, 496);
            Controls.Add(pictureBox2);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "connexion_admin";
            Text = "connexion_admin";
            Load += connexion_admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox Password;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button1;
        private ProgressBar progressBar1;
        private Label label4;
        private TextBox Email;
        private PictureBox pictureBox2;
    }
}