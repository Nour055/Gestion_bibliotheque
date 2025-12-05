namespace GestionBibliothèque
{
    partial class connexion_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion_student));
            label4 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            Password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Email = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(97, 266);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 19;
            label4.Text = "Loading...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(97, 307);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(242, 10);
            progressBar1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Modern No. 20", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(146, 412);
            button1.Name = "button1";
            button1.Size = new Size(144, 40);
            button1.TabIndex = 17;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(263, 353);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(97, 296);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 15;
            label3.Text = "Password\r\n";
            // 
            // Password
            // 
            Password.Location = new Point(97, 323);
            Password.Name = "Password";
            Password.Size = new Size(216, 27);
            Password.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(97, 208);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 13;
            label2.Text = "Email adress";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(97, 152);
            label1.Name = "label1";
            label1.Size = new Size(246, 34);
            label1.TabIndex = 12;
            label1.Text = "Welcome Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 118);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Email
            // 
            Email.Location = new Point(97, 244);
            Email.Name = "Email";
            Email.Size = new Size(216, 27);
            Email.TabIndex = 21;
            Email.TextChanged += Email_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(310, 323);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 27);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // connexion_student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(440, 581);
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
            Name = "connexion_student";
            Text = "connexion_student";
            Load += connexion_student_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ProgressBar progressBar1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label3;
        private TextBox Password;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox Email;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
    }
}