namespace GestionBibliothèque
{
    partial class profileAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileAdmin));
            button1 = new Button();
            label5 = new Label();
            txt_mail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_phone = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            txt_id = new TextBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txt_adress = new TextBox();
            label7 = new Label();
            txt_postal = new TextBox();
            label8 = new Label();
            combo_sex = new ComboBox();
            combo_role = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(242, 478);
            button1.Name = "button1";
            button1.Size = new Size(184, 57);
            button1.TabIndex = 23;
            button1.Text = "Approve";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(101, 303);
            label5.Name = "label5";
            label5.Size = new Size(111, 22);
            label5.TabIndex = 22;
            label5.Text = "Email Address";
            // 
            // txt_mail
            // 
            txt_mail.BackColor = Color.Thistle;
            txt_mail.Location = new Point(101, 333);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(226, 27);
            txt_mail.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(352, 133);
            label4.Name = "label4";
            label4.Size = new Size(35, 22);
            label4.TabIndex = 20;
            label4.Text = "Sex";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(111, 213);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 18;
            label3.Text = "Name";
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.Thistle;
            txt_phone.Location = new Point(352, 248);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(226, 27);
            txt_phone.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(352, 223);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 16;
            label2.Text = "Phone number";
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.Thistle;
            txt_name.Location = new Point(101, 243);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(226, 27);
            txt_name.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(101, 133);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 14;
            label1.Text = "Admin ID ";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.Thistle;
            txt_id.Location = new Point(101, 163);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(226, 27);
            txt_id.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_removebg_preview__6_;
            pictureBox1.Location = new Point(-10, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(352, 303);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 25;
            label6.Text = "Postal Address";
            // 
            // txt_adress
            // 
            txt_adress.BackColor = Color.Thistle;
            txt_adress.Location = new Point(352, 328);
            txt_adress.Name = "txt_adress";
            txt_adress.Size = new Size(226, 27);
            txt_adress.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(352, 387);
            label7.Name = "label7";
            label7.Size = new Size(94, 22);
            label7.TabIndex = 29;
            label7.Text = "Code postal";
            // 
            // txt_postal
            // 
            txt_postal.BackColor = Color.Thistle;
            txt_postal.Location = new Point(352, 412);
            txt_postal.Name = "txt_postal";
            txt_postal.Size = new Size(226, 27);
            txt_postal.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(101, 387);
            label8.Name = "label8";
            label8.Size = new Size(42, 22);
            label8.TabIndex = 27;
            label8.Text = "Role";
            // 
            // combo_sex
            // 
            combo_sex.BackColor = Color.Thistle;
            combo_sex.FormattingEnabled = true;
            combo_sex.Location = new Point(352, 163);
            combo_sex.Name = "combo_sex";
            combo_sex.Size = new Size(226, 28);
            combo_sex.TabIndex = 30;
            combo_sex.SelectedIndexChanged += combo_sex_SelectedIndexChanged;
            // 
            // combo_role
            // 
            combo_role.BackColor = Color.Thistle;
            combo_role.FormattingEnabled = true;
            combo_role.Location = new Point(101, 412);
            combo_role.Name = "combo_role";
            combo_role.Size = new Size(226, 28);
            combo_role.TabIndex = 31;
            // 
            // profileAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(combo_role);
            Controls.Add(combo_sex);
            Controls.Add(label7);
            Controls.Add(txt_postal);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txt_adress);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txt_mail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_phone);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Controls.Add(txt_id);
            Controls.Add(pictureBox1);
            Name = "profileAdmin";
            Size = new Size(683, 602);
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox txt_mail;
        private Label label4;
        private Label label3;
        private TextBox txt_phone;
        private Label label2;
        private TextBox txt_name;
        private Label label1;
        private TextBox txt_id;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox txt_adress;
        private Label label7;
        private TextBox txt_postal;
        private Label label8;
        private ComboBox combo_sex;
        private ComboBox combo_role;
    }
}
