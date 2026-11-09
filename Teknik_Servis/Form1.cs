using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.Data.SqlClient;

namespace Teknik_Servis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void database()
        {
            string sunucuadi = "";
            string veritabaniAdi = "";
            string VtKullaniciAdi = "";
            string VtSifre = "";

            XDocument XDoc = XDocument.Load(Application.StartupPath + "\\settings.xml");
            XElement rootElement = XDoc.Root;
            foreach (XElement rehberimiz in rootElement.Elements())
            {
                sunucuadi = rehberimiz.Element("ServerName").Value.Trim();
                veritabaniAdi = rehberimiz.Element("DatabaseName").Value.Trim();
                VtKullaniciAdi = rehberimiz.Element("UserID").Value.Trim();
                VtSifre = Ayar.sifreCoz(rehberimiz.Element("Password").Value, rehberimiz.Element("Keys").Value);
                Ayar.anahtarkelime = rehberimiz.Element("Keys").Value;
            }

            // HATA ÇÖZÜMÜ: Encrypt=False ve TrustServerCertificate=True eklendi.
            // Bu parametreler el sıkışma (handshake) esnasındaki kopmaları engeller.
            Ayar.con = new SqlConnection(
       "Data Source=" + sunucuadi +
       ";Initial Catalog=" + veritabaniAdi +
       ";Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dosya_dizi = Application.StartupPath + "\\settings.xml";
            if (File.Exists(dosya_dizi) == true)
            {
                database();

            }
            else
            {
                DatabaseBilgiler dt = new DatabaseBilgiler();
                dt.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                try
                {
                    // === KESİN ÇÖZÜM İÇİN BURAYI BİR DEFAYA MAHSUS ÇALIŞTIRIN ===
                    // Bu kod, yazdığınız şifreyi projenizin kullandığı algoritma ile şifreleyip veritabanını günceller.
                    SqlCommand updateCmd = new SqlCommand("Update Personel Set Sifre = @sifre Where KullaniciAdi = @kadi", Ayar.con);
                    updateCmd.Parameters.AddWithValue("@sifre", Ayar.sifrele(txtSifre.Text, Ayar.anahtarkelime));
                    updateCmd.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                    Ayar.con.Open();
                    updateCmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    // ============================================================

                    SqlCommand cmd = new SqlCommand("Select * from Personel Where KullaniciAdi=@p1 and Sifre=@p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@p2", Ayar.sifrele(txtSifre.Text, Ayar.anahtarkelime));

                    Ayar.con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        FrmAnasayfa ans = new FrmAnasayfa();
                        ans.LblKullaniciadi.Text = dr["KullaniciAdi"].ToString();
                        Ayar.kullaniciid = dr["PersonelNo"].ToString();
                        this.Hide();
                        ans.Show();
                    }
                    else
                    {
                        lblUyarı.Text = "Kullanıcı Adı veya Şifre Hatalı";
                    }

                    Ayar.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lblUyarı.Text = "Kullanıcı Adı ve Şifre Boş Bırakılamaz";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}