using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Data.SqlClient;

namespace Teknik_Servis
{
    public partial class FrmCihazKayit : Form
    {
        public FrmCihazKayit()
        {
            InitializeComponent();
        }

        void doldur()
        {
            //Marka Doldur
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * From Marka Where Silindi = 0", Ayar.con);
            Ayar.con.Open();
            DataTable table = new DataTable();
            adtr.Fill(table);
            cmbMarka.DataSource = table;
            cmbMarka.DisplayMember = "MarkaAdi";
            cmbMarka.ValueMember = "MarkaiD";
            cmbMarka.DataSource = table;
            cmbMarka.SelectedValue = 0;
            Ayar.con.Close();
            //Cihaz Türü Doldur
            adtr = new SqlDataAdapter("SELECT * From Cihazlar Where Silindi = 0", Ayar.con);
            Ayar.con.Open();
            table = new DataTable();
            adtr.Fill(table);
            cmbCihazTürü.DataSource = table;
            cmbCihazTürü.DisplayMember = "CihazAdi";
            cmbCihazTürü.ValueMember = "Cihazid";
            cmbCihazTürü.DataSource = table;
            cmbCihazTürü.SelectedValue = 0;
            Ayar.con.Close();
            //İşlem Türü Doldur
            adtr = new SqlDataAdapter("SELECT * From Islemler Where Silindi = 0", Ayar.con);
            Ayar.con.Open();
            table = new DataTable();
            adtr.Fill(table);
            cmbDurum.DataSource = table;
            cmbDurum.DisplayMember = "Islem";
            cmbDurum.ValueMember = "IslemId";
            cmbDurum.DataSource = table;
            cmbDurum.SelectedValue = 0;
            Ayar.con.Close();
        }
        void temizle()
        {
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is RichTextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in this.groupBox2.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is RichTextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }
        private void FrmCihazKayit_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnCihazKAydet_Click(object sender, EventArgs e)
        {
            bool formGecerli = true;

            // GroupBox1 ve GroupBox2 içindeki tüm alanları kontrol et
            Control[] gruplar = { groupBox1, groupBox2 };

            foreach (Control gbox in gruplar)
            {
                foreach (Control item in gbox.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox || item is RichTextBox)
                    {
                        if (string.IsNullOrWhiteSpace(item.Text))
                        {
                            formGecerli = false;
                            break;
                        }
                    }
                    else if (item is ComboBox cmb)
                    {
                        // ComboBox seçili değilse veya değeri boşsa
                        if (cmb.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmb.Text))
                        {
                            formGecerli = false;
                            break;
                        }
                    }
                }
                if (!formGecerli) break;
            }

            if (formGecerli)
            {
                // Not: SQL sorgunuzdaki yazım hatası da düzeltilmiştir (Sikayet;TaminiArzaSebebi -> Sikayet, TahminiArzaSebebi)
                SqlCommand arza = new SqlCommand("Insert Into ArzaKayıt (Cihaz, Marka, Model, Sikayet, TahminiArzaSebebi, KayıtTarihi, Durumu) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7); SELECT @@IDENTITY", Ayar.con);
                arza.Parameters.AddWithValue("@p1", cmbCihazTürü.SelectedValue);
                arza.Parameters.AddWithValue("@p2", cmbMarka.SelectedValue);
                arza.Parameters.AddWithValue("@p3", txtModel.Text.ToUpper());
                arza.Parameters.AddWithValue("@p4", txtSikayet.Text);
                arza.Parameters.AddWithValue("@p5", txtArzaTahmin.Text);
                arza.Parameters.AddWithValue("@p6", DateTime.Now);
                arza.Parameters.AddWithValue("@p7", cmbDurum.SelectedValue);

                Ayar.con.Open();
                int id = Convert.ToInt32(arza.ExecuteScalar());
                Ayar.con.Close();

                SqlCommand arzadetay = new SqlCommand("Insert Into ArzaDetay(KayitId, IslemTarihi, Islem, IslemiYapan) values (@p1, @p2, @p3, @p4)", Ayar.con);
                arzadetay.Parameters.AddWithValue("@p1", id);
                arzadetay.Parameters.AddWithValue("@p2", DateTime.Now);
                arzadetay.Parameters.AddWithValue("@p3", cmbDurum.SelectedValue);
                arzadetay.Parameters.AddWithValue("@p4", Ayar.kullaniciid);

                Ayar.con.Open();
                arzadetay.ExecuteNonQuery();
                Ayar.con.Close();

                // Musteri İşlemleri
                string sql = "";
                if (varmı == false)
                {
                    sql = "Insert Into Musteriler (TC, AdiSoyadi, Mail, Telefon, Adres, UyelikTarihi, KayitEdenPersonel) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                }
                else
                {
                    // Orijinal kodunuzda geçen "KayitEdennPersonel" (çift n) sütun adını veritabanınızdakine göre kontrol edin
                    sql = "Update Musteriler set AdiSoyadi = @p2, Mail = @p3, Telefon = @p4, Adres = @p5, UyelikTarihi = @p6, KayitEdenPersonel = @p7 where TC = @p1";
                }

                SqlCommand musteri = new SqlCommand(sql, Ayar.con);
                musteri.Parameters.AddWithValue("@p1", txtTC.Text);
                musteri.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
                musteri.Parameters.AddWithValue("@p3", txtMail.Text);
                musteri.Parameters.AddWithValue("@p4", txtTelNo.Text);
                musteri.Parameters.AddWithValue("@p5", txtAdres.Text);
                musteri.Parameters.AddWithValue("@p6", DateTime.Now);
                musteri.Parameters.AddWithValue("@p7", Ayar.kullaniciid);

                Ayar.con.Open();
                musteri.ExecuteNonQuery();
                Ayar.con.Close();

                MessageBox.Show("Kayıt Başarıyla Gerçekleşti");
                doldur();
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool varmı = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Musteriler Where TC = @p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", txtTC.Text);
            Ayar.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                varmı = true;
                txtAdSoyad.Text = dr["AdiSoyadi"].ToString();
                txtAdres.Text = dr["Adres"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                txtTelNo.Text = dr["Telefon"].ToString();

            }
            else
            {
                varmı = false;
            }
            Ayar.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
