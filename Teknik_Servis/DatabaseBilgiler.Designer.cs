namespace Teknik_Servis
{
    partial class DatabaseBilgiler
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSunucuAdi = new TextBox();
            txtVeritabani = new TextBox();
            label4 = new Label();
            txtKullanici = new TextBox();
            label5 = new Label();
            txtSifre = new TextBox();
            label6 = new Label();
            txtAnahtar = new TextBox();
            label7 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkRed;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, -6);
            label1.Name = "label1";
            label1.Size = new Size(558, 62);
            label1.TabIndex = 0;
            label1.Text = "VERİ TABANI KAYIT";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(116, 116);
            label2.Name = "label2";
            label2.Size = new Size(289, 14);
            label2.TabIndex = 1;
            label2.Text = "Lütfen Veritabanı Bilgilerinizi Eksiksiz Ve Doğru Girin !";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(32, 224);
            label3.Name = "label3";
            label3.Size = new Size(73, 14);
            label3.TabIndex = 2;
            label3.Text = "Sunucu Adı:";
            label3.Click += label3_Click;
            // 
            // txtSunucuAdi
            // 
            txtSunucuAdi.BackColor = Color.FromArgb(64, 64, 64);
            txtSunucuAdi.BorderStyle = BorderStyle.None;
            txtSunucuAdi.ForeColor = Color.White;
            txtSunucuAdi.Location = new Point(111, 222);
            txtSunucuAdi.Multiline = true;
            txtSunucuAdi.Name = "txtSunucuAdi";
            txtSunucuAdi.Size = new Size(365, 32);
            txtSunucuAdi.TabIndex = 3;
            // 
            // txtVeritabani
            // 
            txtVeritabani.BackColor = Color.FromArgb(64, 64, 64);
            txtVeritabani.BorderStyle = BorderStyle.None;
            txtVeritabani.ForeColor = Color.White;
            txtVeritabani.Location = new Point(111, 260);
            txtVeritabani.Multiline = true;
            txtVeritabani.Name = "txtVeritabani";
            txtVeritabani.Size = new Size(365, 32);
            txtVeritabani.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(19, 269);
            label4.Name = "label4";
            label4.Size = new Size(86, 14);
            label4.TabIndex = 4;
            label4.Text = "Veritabanı Adı:";
            // 
            // txtKullanici
            // 
            txtKullanici.BackColor = Color.FromArgb(64, 64, 64);
            txtKullanici.BorderStyle = BorderStyle.None;
            txtKullanici.ForeColor = Color.White;
            txtKullanici.Location = new Point(111, 298);
            txtKullanici.Multiline = true;
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(365, 32);
            txtKullanici.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(32, 307);
            label5.Name = "label5";
            label5.Size = new Size(73, 14);
            label5.TabIndex = 6;
            label5.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(64, 64, 64);
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.ForeColor = Color.White;
            txtSifre.Location = new Point(111, 336);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(365, 32);
            txtSifre.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(63, 345);
            label6.Name = "label6";
            label6.Size = new Size(42, 14);
            label6.TabIndex = 8;
            label6.Text = "Şifresi:";
            // 
            // txtAnahtar
            // 
            txtAnahtar.BackColor = Color.FromArgb(64, 64, 64);
            txtAnahtar.BorderStyle = BorderStyle.None;
            txtAnahtar.ForeColor = Color.White;
            txtAnahtar.Location = new Point(111, 374);
            txtAnahtar.Multiline = true;
            txtAnahtar.Name = "txtAnahtar";
            txtAnahtar.PasswordChar = '*';
            txtAnahtar.Size = new Size(365, 32);
            txtAnahtar.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(12, 383);
            label7.Name = "label7";
            label7.Size = new Size(93, 14);
            label7.TabIndex = 10;
            label7.Text = "Anahtar Kelime:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(172, 432);
            button1.Name = "button1";
            button1.Size = new Size(260, 61);
            button1.TabIndex = 12;
            button1.Text = "Verileri Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(204, 523);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(167, 16);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "İstenilen Bilgileri Bilmiyorum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DatabaseBilgiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 655);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(txtAnahtar);
            Controls.Add(label7);
            Controls.Add(txtSifre);
            Controls.Add(label6);
            Controls.Add(txtKullanici);
            Controls.Add(label5);
            Controls.Add(txtVeritabani);
            Controls.Add(label4);
            Controls.Add(txtSunucuAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatabaseBilgiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatabaseBilgiler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSunucuAdi;
        private TextBox txtVeritabani;
        private Label label4;
        private TextBox txtKullanici;
        private Label label5;
        private TextBox txtSifre;
        private Label label6;
        private TextBox txtAnahtar;
        private Label label7;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}