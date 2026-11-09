namespace Teknik_Servis
{
    partial class FrmCihazKayit
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
            panel1 = new Panel();
            button1 = new Button();
            groupBox1 = new GroupBox();
            cmbDurum = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtArzaTahmin = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            cmbMarka = new ComboBox();
            label2 = new Label();
            txtSikayet = new RichTextBox();
            txtModel = new TextBox();
            cmbCihazTürü = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            txtAdres = new RichTextBox();
            txtTelNo = new MaskedTextBox();
            txtMail = new TextBox();
            label9 = new Label();
            txtAdSoyad = new TextBox();
            label8 = new Label();
            txtTC = new TextBox();
            label7 = new Label();
            btnCihazKAydet = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1739, 41);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(1702, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 39);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDurum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtArzaTahmin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbMarka);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSikayet);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(cmbCihazTürü);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 438);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cihaz Bilgileri";
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(177, 394);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(246, 27);
            cmbDurum.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 397);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 10;
            label6.Text = "Durumu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 280);
            label5.Name = "label5";
            label5.Size = new Size(119, 57);
            label5.TabIndex = 9;
            label5.Text = "Tahmini Arıza: \r\n( Personel \r\nDolduracak)\r\n";
            // 
            // txtArzaTahmin
            // 
            txtArzaTahmin.Location = new Point(177, 277);
            txtArzaTahmin.Name = "txtArzaTahmin";
            txtArzaTahmin.Size = new Size(246, 111);
            txtArzaTahmin.TabIndex = 8;
            txtArzaTahmin.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 163);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 7;
            label4.Text = "Şikayet :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 117);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 6;
            label3.Text = "Model :";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(177, 71);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(246, 27);
            cmbMarka.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 79);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 4;
            label2.Text = "Marka :";
            // 
            // txtSikayet
            // 
            txtSikayet.Location = new Point(177, 160);
            txtSikayet.Name = "txtSikayet";
            txtSikayet.Size = new Size(246, 111);
            txtSikayet.TabIndex = 3;
            txtSikayet.Text = "";
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.None;
            txtModel.Location = new Point(177, 116);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(246, 20);
            txtModel.TabIndex = 2;
            // 
            // cmbCihazTürü
            // 
            cmbCihazTürü.FormattingEnabled = true;
            cmbCihazTürü.Location = new Point(177, 26);
            cmbCihazTürü.Name = "cmbCihazTürü";
            cmbCihazTürü.Size = new Size(246, 27);
            cmbCihazTürü.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "Cihaz Türü:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtAdres);
            groupBox2.Controls.Add(txtTelNo);
            groupBox2.Controls.Add(txtMail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtAdSoyad);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTC);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(499, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 438);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Bilgileri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 205);
            label11.Name = "label11";
            label11.Size = new Size(56, 19);
            label11.TabIndex = 13;
            label11.Text = "Adres:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 158);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 19;
            label10.Text = "Tel No:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(92, 202);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(246, 111);
            txtAdres.TabIndex = 12;
            txtAdres.Text = "";
            // 
            // txtTelNo
            // 
            txtTelNo.Location = new Point(92, 150);
            txtTelNo.Mask = "(999) 000-0000";
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(246, 27);
            txtTelNo.TabIndex = 18;
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Location = new Point(92, 117);
            txtMail.MaxLength = 50;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(246, 20);
            txtMail.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 118);
            label9.Name = "label9";
            label9.Size = new Size(43, 19);
            label9.TabIndex = 17;
            label9.Text = "Mail:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BorderStyle = BorderStyle.None;
            txtAdSoyad.Location = new Point(92, 79);
            txtAdSoyad.MaxLength = 50;
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(246, 20);
            txtAdSoyad.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 80);
            label8.Name = "label8";
            label8.Size = new Size(83, 19);
            label8.TabIndex = 15;
            label8.Text = "Ad Soyad:";
            // 
            // txtTC
            // 
            txtTC.BorderStyle = BorderStyle.None;
            txtTC.Location = new Point(92, 44);
            txtTC.MaxLength = 11;
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(246, 20);
            txtTC.TabIndex = 12;
            txtTC.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 44);
            label7.Name = "label7";
            label7.Size = new Size(35, 19);
            label7.TabIndex = 13;
            label7.Text = "TC:";
            // 
            // btnCihazKAydet
            // 
            btnCihazKAydet.BackColor = Color.FromArgb(0, 64, 0);
            btnCihazKAydet.FlatAppearance.BorderSize = 0;
            btnCihazKAydet.FlatStyle = FlatStyle.Flat;
            btnCihazKAydet.ForeColor = Color.FromArgb(224, 224, 224);
            btnCihazKAydet.Location = new Point(976, 474);
            btnCihazKAydet.Name = "btnCihazKAydet";
            btnCihazKAydet.Size = new Size(406, 43);
            btnCihazKAydet.TabIndex = 3;
            btnCihazKAydet.Text = "Cihaz Girişini Kaydet";
            btnCihazKAydet.UseVisualStyleBackColor = false;
            btnCihazKAydet.Click += btnCihazKAydet_Click;
            // 
            // FrmCihazKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 536);
            Controls.Add(btnCihazKAydet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCihazKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cihaz İslemleri";
            TopMost = true;
            Load += FrmCihazKayit_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private GroupBox groupBox1;
        private ComboBox cmbMarka;
        private Label label2;
        private RichTextBox txtSikayet;
        private TextBox txtModel;
        private ComboBox cmbCihazTürü;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox txtArzaTahmin;
        private ComboBox cmbDurum;
        private Label label6;
        private Label label11;
        private Label label10;
        private RichTextBox txtAdres;
        private MaskedTextBox txtTelNo;
        private TextBox txtMail;
        private Label label9;
        private TextBox txtAdSoyad;
        private Label label8;
        private TextBox txtTC;
        private Label label7;
        private Button btnCihazKAydet;
    }
}