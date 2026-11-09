namespace Teknik_Servis
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            txtKullaniciAdi = new TextBox();
            panel2 = new Panel();
            txtSifre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            lblUyarı = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 46);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(255, 128, 255);
            label2.Location = new Point(145, 61);
            label2.Name = "label2";
            label2.Size = new Size(104, 29);
            label2.TabIndex = 1;
            label2.Text = "Giriş  Yap";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(362, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 33);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(338, 9);
            label4.Name = "label4";
            label4.Size = new Size(28, 33);
            label4.TabIndex = 3;
            label4.Text = "_";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Location = new Point(29, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 46);
            panel1.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.Silver;
            txtKullaniciAdi.BorderStyle = BorderStyle.None;
            txtKullaniciAdi.Location = new Point(3, 16);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(329, 16);
            txtKullaniciAdi.TabIndex = 0;
            txtKullaniciAdi.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(txtSifre);
            panel2.Location = new Point(29, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 46);
            panel2.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.Silver;
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Location = new Point(6, 16);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(329, 16);
            txtSifre.TabIndex = 0;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(29, 158);
            label5.Name = "label5";
            label5.Size = new Size(140, 24);
            label5.TabIndex = 6;
            label5.Text = "Kullanıcı Adi";
            // 
            // label6
            // 
            label6.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(29, 248);
            label6.Name = "label6";
            label6.Size = new Size(140, 24);
            label6.TabIndex = 7;
            label6.Text = "Şifre";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F);
            button1.ForeColor = Color.FromArgb(20, 50, 64);
            button1.Location = new Point(29, 364);
            button1.Name = "button1";
            button1.Size = new Size(338, 49);
            button1.TabIndex = 8;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(255, 128, 255);
            label7.Location = new Point(122, 430);
            label7.Name = "label7";
            label7.Size = new Size(159, 29);
            label7.TabIndex = 9;
            label7.Text = "Parolamı Unuttum";
            label7.Click += label7_Click;
            // 
            // lblUyarı
            // 
            lblUyarı.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUyarı.ForeColor = Color.Red;
            lblUyarı.Location = new Point(10, 477);
            lblUyarı.Name = "lblUyarı";
            lblUyarı.Size = new Size(373, 49);
            lblUyarı.TabIndex = 10;
            lblUyarı.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 50, 64);
            ClientSize = new Size(395, 535);
            Controls.Add(lblUyarı);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TextBox txtKullaniciAdi;
        private Panel panel2;
        private TextBox txtSifre;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label lblUyarı;
    }
}
