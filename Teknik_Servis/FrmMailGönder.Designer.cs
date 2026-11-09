namespace Teknik_Servis
{
    partial class FrmMailGönder
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
            grpGönderici = new GroupBox();
            txtGondericiMail = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtMesaj = new RichTextBox();
            txtKonu = new TextBox();
            label3 = new Label();
            txtAlıcıMail = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            chcDuzenle = new CheckBox();
            label5 = new Label();
            txtImza = new RichTextBox();
            BtnIptal = new Button();
            BtnGönder = new Button();
            grpGönderici.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpGönderici
            // 
            grpGönderici.Controls.Add(txtGondericiMail);
            grpGönderici.Controls.Add(label1);
            grpGönderici.Dock = DockStyle.Top;
            grpGönderici.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpGönderici.ForeColor = Color.FromArgb(224, 224, 224);
            grpGönderici.Location = new Point(0, 0);
            grpGönderici.Name = "grpGönderici";
            grpGönderici.Size = new Size(1179, 105);
            grpGönderici.TabIndex = 0;
            grpGönderici.TabStop = false;
            grpGönderici.Text = "Gönderici Bilgileri";
            grpGönderici.Enter += grpGönderici_Enter;
            // 
            // txtGondericiMail
            // 
            txtGondericiMail.Enabled = false;
            txtGondericiMail.Location = new Point(113, 44);
            txtGondericiMail.Name = "txtGondericiMail";
            txtGondericiMail.Size = new Size(1055, 26);
            txtGondericiMail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(100, 18);
            label1.TabIndex = 0;
            label1.Text = "Gönderici Mail:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMesaj);
            groupBox1.Controls.Add(txtKonu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAlıcıMail);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(0, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 443);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alıcı Bilgileri ve Mesaj İçeriği";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 153);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 5;
            label4.Text = "Mesaj:";
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(113, 139);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(1055, 220);
            txtMesaj.TabIndex = 4;
            txtMesaj.Text = "";
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(113, 94);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(1055, 26);
            txtKonu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 94);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 2;
            label3.Text = "Konu:";
            // 
            // txtAlıcıMail
            // 
            txtAlıcıMail.Location = new Point(113, 44);
            txtAlıcıMail.Name = "txtAlıcıMail";
            txtAlıcıMail.Size = new Size(1055, 26);
            txtAlıcıMail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 47);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 0;
            label2.Text = "Alıcı Mail:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chcDuzenle);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtImza);
            groupBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(0, 554);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1317, 183);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "İmza İçeriği";
            // 
            // chcDuzenle
            // 
            chcDuzenle.AutoSize = true;
            chcDuzenle.Location = new Point(1089, 149);
            chcDuzenle.Name = "chcDuzenle";
            chcDuzenle.Size = new Size(78, 22);
            chcDuzenle.TabIndex = 8;
            chcDuzenle.Text = "Düzenle";
            chcDuzenle.UseVisualStyleBackColor = true;
            chcDuzenle.CheckedChanged += chcDuzenle_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 37);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 7;
            label5.Text = "İmza:";
            // 
            // txtImza
            // 
            txtImza.Enabled = false;
            txtImza.Location = new Point(113, 16);
            txtImza.Name = "txtImza";
            txtImza.Size = new Size(1055, 118);
            txtImza.TabIndex = 6;
            txtImza.Text = "";
            // 
            // BtnIptal
            // 
            BtnIptal.BackColor = Color.Maroon;
            BtnIptal.FlatAppearance.BorderSize = 0;
            BtnIptal.FlatStyle = FlatStyle.Flat;
            BtnIptal.ForeColor = Color.FromArgb(224, 224, 224);
            BtnIptal.Location = new Point(12, 750);
            BtnIptal.Name = "BtnIptal";
            BtnIptal.Size = new Size(287, 58);
            BtnIptal.TabIndex = 3;
            BtnIptal.Text = "İptal";
            BtnIptal.UseVisualStyleBackColor = false;
            BtnIptal.Click += BtnIptal_Click;
            // 
            // BtnGönder
            // 
            BtnGönder.BackColor = Color.Green;
            BtnGönder.FlatAppearance.BorderSize = 0;
            BtnGönder.FlatStyle = FlatStyle.Flat;
            BtnGönder.ForeColor = Color.FromArgb(224, 224, 224);
            BtnGönder.Location = new Point(880, 750);
            BtnGönder.Name = "BtnGönder";
            BtnGönder.Size = new Size(287, 58);
            BtnGönder.TabIndex = 4;
            BtnGönder.Text = "Gönder";
            BtnGönder.UseVisualStyleBackColor = false;
            BtnGönder.Click += BtnGönder_Click;
            // 
            // FrmMailGönder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 50, 60);
            ClientSize = new Size(1179, 820);
            Controls.Add(BtnGönder);
            Controls.Add(BtnIptal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpGönderici);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMailGönder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMailGönder";
            Load += FrmMailGönder_Load;
            grpGönderici.ResumeLayout(false);
            grpGönderici.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpGönderici;
        private TextBox txtGondericiMail;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAlıcıMail;
        private Label label2;
        private TextBox txtKonu;
        private Label label3;
        private Label label4;
        private RichTextBox txtMesaj;
        private GroupBox groupBox2;
        private CheckBox chcDuzenle;
        private Label label5;
        private RichTextBox txtImza;
        private Button BtnIptal;
        private Button BtnGönder;
    }
}