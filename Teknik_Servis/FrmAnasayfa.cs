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
using System.Linq.Expressions;

namespace Teknik_Servis
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        void markadoldur()
        {
            // SqlDataAdapter bağlantıyı otomatik yönetir, manuel Open/Close'a gerek yoktur.
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * From Marka Where Silindi = 0", Ayar.con);
            DataTable table = new DataTable();
            adtr.Fill(table);

            LstMarkaIslemleriMarkalar.DisplayMember = "MarkaAdi";
            LstMarkaIslemleriMarkalar.ValueMember = "MarkaiD";
            LstMarkaIslemleriMarkalar.DataSource = table;

            cbbMarkaIslemleri.DisplayMember = "MarkaAdi";
            cbbMarkaIslemleri.ValueMember = "MarkaiD";
            cbbMarkaIslemleri.DataSource = table;
            cbbMarkaIslemleri.Text = "";
        }

        void cihazdoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * From Cihazlar Where Silindi = 0", Ayar.con);
            DataTable table = new DataTable();
            adtr.Fill(table);

            LstCihazIslemleriCihazAdi.DisplayMember = "CihazAdi";
            LstCihazIslemleriCihazAdi.ValueMember = "CihazId";
            LstCihazIslemleriCihazAdi.DataSource = table;
        }

        void kategoridoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * From YedekParcaKategori Where Silindi = 0", Ayar.con);
            DataTable table = new DataTable();
            adtr.Fill(table);

            lstYedekParcaKategoriİslemleri.DisplayMember = "KategoriAdi";
            lstYedekParcaKategoriİslemleri.ValueMember = "KategoriId";
            lstYedekParcaKategoriİslemleri.DataSource = table;

            lstYedekParcaIslemleri.DataSource = null;
            cbbYedekParcaIslemleriKategori.DisplayMember = "KategoriAdi";
            cbbYedekParcaIslemleriKategori.ValueMember = "KategoriId";
            cbbYedekParcaIslemleriKategori.DataSource = table;

            lstYedekParcaIslemleri.DisplayMember = "KategoriAdi";
            lstYedekParcaIslemleri.ValueMember = "KategoriId";
            lstYedekParcaIslemleri.DataSource = table;

            cbbYedekParcaIslemleriKategori.Text = "";

        }
        void panellerikapat()
        {
            //Sistem Ayarları
            PnlMarkaİslemleri.Visible = false;
            PnlSistemCihazİslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYedekParcaİslemleri.Visible = false;
            PnlYetkiİslemleri.Visible = false;
            pnlSirgetBilgiveLimitler.Visible = false;
            //Personel İşlemleri
            pnlPersonelDuzenle.Visible = false;
            pnlPersonelEkle.Visible = false;
        }
        void yetkidoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Yetkilendirme", Ayar.con);
            Ayar.con.Open();
            DataTable table = new DataTable();
            adtr.Fill(table);
            cbmYetkiler.DataSource = null;
            cbmYetkiler.DisplayMember = "YetkiAdi";
            cbmYetkiler.ValueMember = "Yetkiid";
            cbmYetkiler.DataSource = table;
            cbmYetkiler.SelectedValue = 0;

            cbbPersonelEkleYetki.DataSource = null;
            cbbPersonelEkleYetki.DisplayMember = "YetkiAdi";
            cbbPersonelEkleYetki.ValueMember = "Yetkiid";
            cbbPersonelEkleYetki.DataSource = table;
            cbbPersonelEkleYetki.SelectedValue = 0;

            cbbPersonelDuzenleYetki.DataSource = null;
            cbbPersonelDuzenleYetki.DisplayMember = "YetkiAdi";
            cbbPersonelDuzenleYetki.ValueMember = "Yetkiid";
            cbbPersonelDuzenleYetki.DataSource = table.Copy();
            cbbPersonelDuzenleYetki.SelectedValue = 0;

            chcCariİslemlei.Checked = false;
            chcKayıtAç.Checked = false;
            chcKayıtTamamla.Checked = false;
            chcPersonelekle.Checked = false;
            chcPersonelsil.Checked = false;
            chcSistemAyari.Checked = false;
            chcYedekParca.Checked = false;
            Ayar.con.Close();
        }
        void personeldoldur()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Personel Where Silindi = 0", Ayar.con);
            Ayar.con.Open();
            DataTable table = new DataTable();
            adtr.Fill(table);
            lstPersonelDuzenle.DisplayMember = "AdiSoyadi";
            lstPersonelDuzenle.ValueMember = "PersonelNo";
            lstPersonelDuzenle.DataSource = table;
            Ayar.con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (PnlCihaz.Visible == true)
            {
                PnlCihaz.Visible = false;
                button1.BackColor = Color.FromArgb(20, 50, 60);
            }
            else
            {

                button1.BackColor = Color.Linen;
                button2.BackColor = Color.FromArgb(20, 50, 60);
                button3.BackColor = Color.FromArgb(20, 50, 60);
                button4.BackColor = Color.FromArgb(20, 50, 60);
                button5.BackColor = Color.FromArgb(20, 50, 60);
                PnlCihaz.Visible = true;
                PnlPersonel.Visible = false;
                PnlSistem.Visible = false;
                PnlCari.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PnlCari.Visible == true)
            {
                PnlCari.Visible = false;
                button2.BackColor = Color.FromArgb(20, 50, 60);
            }
            else
            {
                button1.BackColor = Color.FromArgb(20, 50, 60);
                button2.BackColor = Color.Linen;
                button3.BackColor = Color.FromArgb(20, 50, 60);
                button4.BackColor = Color.FromArgb(20, 50, 60);
                button5.BackColor = Color.FromArgb(20, 50, 60);
                PnlCihaz.Visible = false;
                PnlPersonel.Visible = false;
                PnlSistem.Visible = false;
                PnlCari.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PnlPersonel.Visible == true)
            {
                PnlPersonel.Visible = false;
                button3.BackColor = Color.FromArgb(20, 50, 60);
            }
            else
            {
                button1.BackColor = Color.FromArgb(20, 50, 60);
                button2.BackColor = Color.FromArgb(20, 50, 60);
                button3.BackColor = Color.Linen;
                button4.BackColor = Color.FromArgb(20, 50, 60);
                button5.BackColor = Color.FromArgb(20, 50, 60);
                PnlCihaz.Visible = false;
                PnlPersonel.Visible = true;
                PnlSistem.Visible = false;
                PnlCari.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PnlSistem.Visible == true)
            {
                PnlSistem.Visible = false;
                button4.BackColor = Color.FromArgb(20, 50, 60);
            }
            else
            {
                button1.BackColor = Color.FromArgb(20, 50, 60);
                button2.BackColor = Color.FromArgb(20, 50, 60);
                button3.BackColor = Color.FromArgb(20, 50, 60);
                button4.BackColor = Color.Linen;
                button5.BackColor = Color.FromArgb(20, 50, 60);
                PnlCihaz.Visible = false;
                PnlPersonel.Visible = false;
                PnlSistem.Visible = true;
                PnlCari.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btnMarkaİslemleri_Click(object sender, EventArgs e)
        {
            markadoldur();
            txtMArkaIslemleriMarkaAdi.Text = "";
            LblMarkaİslemleriMarkaId.Text = "";
            panellerikapat();
            PnlMarkaİslemleri.Visible = true;
            btnMarkaGuncelle.Enabled = false;
            btnMarkaSil.Enabled = false;
            btnYeniMarka.Enabled = true;
        }

        private void btnModelİslemleri_Click(object sender, EventArgs e)
        {
            PnlMarkaİslemleri.Visible = false;
            PnlSistemCihazİslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYedekParcaİslemleri.Visible = false;
            PnlYetkiİslemleri.Visible = false;

        }

        private void btnCihazİslemleri_Click(object sender, EventArgs e)
        {
            cihazdoldur();
            TxtCihazIslemleriCihazAdı.Text = "";
            LblCihazIslemleriCihazId.Text = "";
            panellerikapat();
            PnlSistemCihazİslemleri.Visible = true;

            BtnCihazIslemleriCihazGuncelle.Enabled = false;
            BtnCihazIslemleriCihazSil.Enabled = false;
            BtnCihazIslemleriYeniCihaz.Enabled = true;
        }

        private void btnYedekParca_Click(object sender, EventArgs e)
        {
            kategoridoldur();
            txtYedekParcaKategoriIslemleriKtAd.Text = "";
            lblYedekParcaKategoriIslemleriKtId.Text = "";
            panellerikapat();
            PnlYedekParcaKategori.Visible = true;

            BtnYedekParcaKategoriIslemleriGuncelle.Enabled = false;
            BtnYedekParcaKategoriIslemleriSil.Enabled = false;
            BtnYedekParcaKategoriIslemleriEkle.Enabled = true;
        }

        private void btnYedekParcaİslem_Click(object sender, EventArgs e)
        {
            kategoridoldur();
            markadoldur();
            LblYedekParcaIslemleriIslemler.Text = "Kategoriler";
            LblYedekParcaIslemleriIslemler.BackColor = Color.Tomato;
            panellerikapat();
            PnlYedekParcaİslemleri.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yetkidoldur();
            chcCariİslemlei.Checked = false;
            chcKayıtAç.Checked = false;
            chcKayıtTamamla.Checked = false;
            chcPersonelekle.Checked = false;
            chcPersonelsil.Checked = false;
            chcSistemAyari.Checked = false;
            chcYedekParca.Checked = false;
            panellerikapat();
            PnlYetkiİslemleri.Visible = true;
        }

        private void PnlMarkaİslemleri_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Marka SET Silindi = 1 WHERE Markaid = @p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", LblMarkaİslemleriMarkaId.Text);
            Ayar.con.Open();
            cmd.ExecuteNonQuery();
            Ayar.con.Close();
            txtMArkaIslemleriMarkaAdi.Text = "";
            LblMarkaİslemleriMarkaId.Text = "";
            btnMarkaGuncelle.Enabled = false;
            btnMarkaSil.Enabled = false;
            btnYeniMarka.Enabled = true;
            markadoldur();
        }

        private void LstMarkaIslemleriMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMarkaGuncelle.Enabled = true;
            btnMarkaSil.Enabled = true;
            btnYeniMarka.Enabled = false;
            txtMArkaIslemleriMarkaAdi.Text = LstMarkaIslemleriMarkalar.Text;
            LblMarkaİslemleriMarkaId.Text = LstMarkaIslemleriMarkalar.SelectedValue.ToString();
        }

        private void btnYeniMarka_Click(object sender, EventArgs e)
        {
            if (txtMArkaIslemleriMarkaAdi.Text == "")
            {
                MessageBox.Show("Marka adı boş bırakılamaz.", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert into Marka (MarkaAdi) values (@p1)", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", txtMArkaIslemleriMarkaAdi.Text.ToUpper());
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    markadoldur();
                    txtMArkaIslemleriMarkaAdi.Text = "";
                    LblMarkaİslemleriMarkaId.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluştu. DAha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (txtMArkaIslemleriMarkaAdi.Text == "" && LblMarkaİslemleriMarkaId.Text == "")
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır yada marka seçiniz.", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Marka SET MarkaAdi = @p1 Where MarkaId = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", txtMArkaIslemleriMarkaAdi.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p2", LblMarkaİslemleriMarkaId.Text);
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    markadoldur();
                    txtMArkaIslemleriMarkaAdi.Text = "";
                    LblMarkaİslemleriMarkaId.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluştu. DAha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click handler placeholder (designer references this). No action required.
        }

        private void txtMArkaIslemleriMarkaAdi_TextChanged(object sender, EventArgs e)
        {
            // TextChanged handler placeholder (designer references this).
            // Keep empty to preserve designer event hookup.
        }

        private void LstCihazIslemleriCihazAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnCihazIslemleriCihazGuncelle.Enabled = true;
            BtnCihazIslemleriCihazSil.Enabled = true;
            BtnCihazIslemleriYeniCihaz.Enabled = false;
            TxtCihazIslemleriCihazAdı.Text = LstCihazIslemleriCihazAdi.Text;
            LblCihazIslemleriCihazId.Text = LstCihazIslemleriCihazAdi.SelectedValue.ToString();
        }

        private void BtnCihazIslemleriYeniCihaz_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Cihazlar (CihazAdi) values (@p1)", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", TxtCihazIslemleriCihazAdı.Text.ToUpper());
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                TxtCihazIslemleriCihazAdı.Text = "";
                LblCihazIslemleriCihazId.Text = "";
                cihazdoldur();
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Bir hata oluştu. Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCihazIslemleriCihazGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (LblCihazIslemleriCihazId.Text == "" || TxtCihazIslemleriCihazAdı.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Update Cihazlar set CihazAdi = @p1 where CihazId = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", TxtCihazIslemleriCihazAdı.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p2", LblCihazIslemleriCihazId.Text);
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    TxtCihazIslemleriCihazAdı.Text = "";
                    LblCihazIslemleriCihazId.Text = "";
                    cihazdoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Bir hata oluştu. Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCihazIslemleriCihazSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (LblCihazIslemleriCihazId.Text == "" || TxtCihazIslemleriCihazAdı.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Update Cihazlar set Silindi = @p1 where CihazId = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", "1");
                    cmd.Parameters.AddWithValue("@p2", LblCihazIslemleriCihazId.Text);
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    TxtCihazIslemleriCihazAdı.Text = "";
                    LblCihazIslemleriCihazId.Text = "";
                    cihazdoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Bir hata oluştu. Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstYedekParcaKategoriİslemleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnYedekParcaKategoriIslemleriGuncelle.Enabled = true;
            BtnYedekParcaKategoriIslemleriSil.Enabled = true;
            BtnYedekParcaKategoriIslemleriEkle.Enabled = false;
            txtYedekParcaKategoriIslemleriKtAd.Text = lstYedekParcaKategoriİslemleri.Text;
            lblYedekParcaKategoriIslemleriKtId.Text = lstYedekParcaKategoriİslemleri.SelectedValue.ToString();
        }

        private void BtnYedekParcaKategoriIslemleriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblYedekParcaKategoriIslemleriKtId.Text == "" || txtYedekParcaKategoriIslemleriKtAd.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Update YedekParcaKategori set KategoriAdi = @p1 where KategoriId = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", txtYedekParcaKategoriIslemleriKtAd.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@p2", lblYedekParcaKategoriIslemleriKtId.Text);
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    txtYedekParcaKategoriIslemleriKtAd.Text = "";
                    lblYedekParcaKategoriIslemleriKtId.Text = "";
                    kategoridoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Bir hata oluştu. Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnYedekParcaKategoriIslemleriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYedekParcaKategoriIslemleriKtAd.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into YedekParcaKategori (KategoriAdi) values (@p1)", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", txtYedekParcaKategoriIslemleriKtAd.Text.ToUpper());
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    txtYedekParcaKategoriIslemleriKtAd.Text = "";
                    lblYedekParcaKategoriIslemleriKtId.Text = "";
                    kategoridoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Bir hata oluştu. Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnYedekParcaKategoriIslemleriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblYedekParcaKategoriIslemleriKtId.Text == "" || txtYedekParcaKategoriIslemleriKtAd.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Update YedekParcaKategori set Silindi = @p1 where KategoriId = @p2", Ayar.con);
                    cmd.Parameters.AddWithValue("@p1", "1");
                    cmd.Parameters.AddWithValue("@p2", lblYedekParcaKategoriIslemleriKtId.Text);
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    txtYedekParcaKategoriIslemleriKtAd.Text = "";
                    lblYedekParcaKategoriIslemleriKtId.Text = "";
                    kategoridoldur();
                }
            }
            catch (Exception)
            {
                Ayar.con.Close();
                MessageBox.Show("Bir hata oluştu. Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstYedekParcaIslemleri_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lstYedekParcaIslemleri_DoubleClick(object sender, EventArgs e)
        {
            if (LblYedekParcaIslemleriIslemler.Text == "Kategoriler")
            {
                if (lstYedekParcaIslemleri.SelectedValue == null) return;

                int id = int.Parse(lstYedekParcaIslemleri.SelectedValue.ToString());

                LblYedekParcaIslemleriIslemler.Text = "Modeller";

                // Veritabanından ilgili kategorideki yedek parçaları çekiyoruz
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM YedekParca WHERE Kategori = @p1 AND Silindi = 0", Ayar.con);
                adtr.SelectCommand.Parameters.AddWithValue("@p1", id);

                DataTable table = new DataTable();
                adtr.Fill(table);

                // Veriyi tıkladığınız kontrolün kendisine (lstYedekParcaIslemleri) yüklüyoruz
                lstYedekParcaIslemleri.DataSource = null;
                lstYedekParcaIslemleri.DisplayMember = "ParcaAdi"; // Tablonuzdaki gerçek sütun adı (Model yerine ParcaAdi vb.)
                lstYedekParcaIslemleri.ValueMember = "YedekParcaId";
                lstYedekParcaIslemleri.DataSource = table;
            }
            else if (LblYedekParcaIslemleriIslemler.Text == "Modeller")
            {
                if (lstYedekParcaIslemleri.SelectedValue == null) return;

                lblYedekParcaId.Text = lstYedekParcaIslemleri.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand("SELECT * FROM YedekParca WHERE YedekParcaId = @p1", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", lblYedekParcaId.Text);

                try
                {
                    Ayar.con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtYedekParcaIslemleriAdı.Text = dr["Model"].ToString();
                        TxtYedekParcaIslemleriStok.Text = dr["Stok"].ToString();
                        txtYedekParcaIlemleriOzelikler.Text = dr["Ozellikler"].ToString();
                        cbbYedekParcaIslemleriKategori.SelectedValue = dr["Kategori"];
                        cbbMarkaIslemleri.SelectedValue = dr["Marka"];
                    }
                    dr.Close();
                }
                finally
                {
                    Ayar.con.Close();
                }
            }
        }

        private void btnYetki_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            string personelekle, personelsil, kayitac, kayittamamla, yedekparca, carislem, sistemayarlari;
            if (chcCariİslemlei.Checked == true)
            {
                carislem = "1";
            }
            else
            {
                carislem = "0";
            }
            if (chcKayıtAç.Checked == true)
            {
                kayitac = "1";
            }
            else
            {
                kayitac = "0";
            }
            if (chcKayıtTamamla.Checked == true)
            {
                kayittamamla = "1";
            }
            else
            {
                kayittamamla = "0";
            }
            if (chcPersonelekle.Checked == true)
            {
                personelekle = "1";
            }
            else
            {
                personelekle = "0";
            }
            if (chcPersonelsil.Checked == true)
            {
                personelsil = "1";
            }
            else
            {
                personelsil = "0";
            }
            if (chcSistemAyari.Checked == true)
            {
                sistemayarlari = "1";
            }
            else
            {
                sistemayarlari = "0";
            }
            if (chcYedekParca.Checked == true)
                yedekparca = "1";
            else
                yedekparca = "0";
            int id;
            if (cbmYetkiler.SelectedValue == null)
            {
                id = 0;
            }
            else
            {
                id = int.Parse(cbmYetkiler.SelectedValue.ToString());
            }
            SqlCommand cmd = new SqlCommand("Select * from Yetkilendirme where Yetkiid = @p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", id);
            Ayar.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            bool kayitVarMi = dr.Read(); // 1. Okuma sonucunu değişkene alıyoruz
            dr.Close();                 // 2. Hemen kapatıyoruz

            string islem;
            if (kayitVarMi)             // 3. Artık değişkeni kontrol ediyoruz
            {
                islem = "Update Yetkilendirme set PersonelEkleme = @pekle, PersonelSilme=@psil,KayitAcma=@kac,KayıtTamamlama=@ktamamla,YedekParça=@yparca,CariIslemleri=@cislem,SistemAyarlari =@sAyar Where Yetkiid = @p1";
            }
            else
            {
                islem = "Insert into Yetkilendirme (YetkiAdi,PersonelEkleme, PersonelSilme, KayitAcma, KayıtTamamlama, YedekParça, CariIslemleri, SistemAyarlari) values (@pAdi,@pekle, @psil, @kac, @ktamamla, @yparca, @cislem, @sAyar)";
            }

            SqlCommand komut = new SqlCommand(islem, Ayar.con);
            komut.Parameters.AddWithValue("@pAdi", txtYetkiAdi.Text);
            komut.Parameters.AddWithValue("@pekle", personelekle);
            komut.Parameters.AddWithValue("@psil", personelsil);
            komut.Parameters.AddWithValue("@kac", kayitac);
            komut.Parameters.AddWithValue("@ktamamla", kayittamamla);
            komut.Parameters.AddWithValue("@yparca", yedekparca);
            komut.Parameters.AddWithValue("@cislem", carislem);
            komut.Parameters.AddWithValue("@sAyar", sistemayarlari);

            // Eğer Güncelleme ise @p1 parametresini de eklemeliyiz
            if (kayitVarMi)
            {
                komut.Parameters.AddWithValue("@p1", id);
            }


            komut.ExecuteNonQuery();
            Ayar.con.Close();
            yetkidoldur();
        }

        private void cbmYetkiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmYetkiler_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbmYetkiler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Yetkilendirme where Yetkiid =@p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", cbmYetkiler.SelectedValue);

            Ayar.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[2].ToString() == "True")
                {
                    chcPersonelekle.Checked = true;
                }
                else
                {
                    chcPersonelekle.Checked = false;
                }


                if (dr[3].ToString() == "True")
                {
                    chcPersonelsil.Checked = true;
                }
                else
                {
                    chcPersonelsil.Checked = false;
                }

                if (dr[4].ToString() == "True")
                {
                    chcKayıtAç.Checked = true;
                }
                else
                {
                    chcKayıtAç.Checked = false;
                }

                if (dr[5].ToString() == "True")
                {
                    chcKayıtTamamla.Checked = true;
                }
                else
                {
                    chcKayıtTamamla.Checked = false;
                }

                if (dr[6].ToString() == "True")
                {
                    chcYedekParca.Checked = true;
                }
                else
                {
                    chcYedekParca.Checked = false;
                }

                if (dr[7].ToString() == "True")
                {
                    chcCariİslemlei.Checked = true;
                }
                else
                {
                    chcCariİslemlei.Checked = false;
                }

                if (dr[8].ToString() == "True")
                {
                    chcSistemAyari.Checked = true;
                }
                else
                {
                    chcSistemAyari.Checked = false;
                }
            }
            Ayar.con.Close();
        }

        private void btnYetkiGrubuEkle_Click(object sender, EventArgs e)
        {
            yetkidoldur();
            txtYetkiAdi.Visible = true;
            cbmYetkiler.Visible = false;
            btnYetkiGrubuEkle.Visible = false;
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            panellerikapat();
            yetkidoldur();
            pnlPersonelEkle.Visible = true;
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            panellerikapat();
            personeldoldur();
            yetkidoldur();
            pnlPersonelDuzenle.Visible = true;
        }

        private void btnPersonelEklePersonelKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelEkleAdıSoyadı.Text != "" && TxtPersonelEkleAdres.Text != "" && TxtPersonelEkleMail.Text != "" && TxtPersonelEkleGörevi.Text != "" && txtPersonelEkleKullaniciAdi.Text != "" && TxtPersonelEkleMaas.Text != "" && TxtPersonelEkleSifre.Text != "" && TxtPersonelTC.Text != "" && TxtPersonelEkletelefonNo.Text != "" && cbbPersonelEkleYetki.Text != "")
            {
                if (TxtPersonelTC.Text.Length != 11)
                {
                    MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool kayitVarMi = false;

                // 1. Adım: Kullanıcı veya TC kontrolü
                using (SqlCommand kontrol = new SqlCommand("Select TC, KullaniciAdi From Personel Where TC=@p1 OR KullaniciAdi = @p2", Ayar.con))
                {
                    kontrol.Parameters.AddWithValue("@p1", TxtPersonelTC.Text);
                    kontrol.Parameters.AddWithValue("@p2", txtPersonelEkleKullaniciAdi.Text);

                    if (Ayar.con.State == ConnectionState.Closed)
                        Ayar.con.Open();

                    using (SqlDataReader dr = kontrol.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            kayitVarMi = true;
                        }
                    }
                    Ayar.con.Close();
                }

                if (kayitVarMi)
                {
                    MessageBox.Show("Bu TC veya Kullanıcı Adı sistemde zaten kayıtlı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // 2. Adım: Veritabanına Ekleme İşlemi (Maas -> Maaş yapıldı)
                    using (SqlCommand cmd = new SqlCommand("Insert into Personel(TC,KullaniciAdi,AdiSoyadi,Telefon,Mail,Adres,Görevi,Yetkisi,Maaş,Sifre) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", Ayar.con))
                    {
                        cmd.Parameters.AddWithValue("@p1", TxtPersonelTC.Text);
                        cmd.Parameters.AddWithValue("@p2", txtPersonelEkleKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@p3", txtPersonelEkleAdıSoyadı.Text);
                        cmd.Parameters.AddWithValue("@p4", TxtPersonelEkletelefonNo.Text);
                        cmd.Parameters.AddWithValue("@p5", TxtPersonelEkleMail.Text);
                        cmd.Parameters.AddWithValue("@p6", TxtPersonelEkleAdres.Text);
                        cmd.Parameters.AddWithValue("@p7", TxtPersonelEkleGörevi.Text);
                        cmd.Parameters.AddWithValue("@p8", cbbPersonelEkleYetki.SelectedValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@p9", TxtPersonelEkleMaas.Text);
                        cmd.Parameters.AddWithValue("@p10", Ayar.sifrele(TxtPersonelEkleSifre.Text, Ayar.anahtarkelime));

                        if (Ayar.con.State == ConnectionState.Closed)
                            Ayar.con.Open();

                        cmd.ExecuteNonQuery();
                        Ayar.con.Close();
                    }

                    MessageBox.Show("Personel başarıyla eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    yetkidoldur();

                    // Form alanlarını temizleme
                    foreach (Control item in pnlPersonelEkle.Controls)
                    {
                        if (item is TextBox || item is MaskedTextBox || item is RichTextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstPersonelDuzenle_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void lstPersonelDuzenle_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Personel Where PersonelNo = @p1", Ayar.con);
            cmd.Parameters.AddWithValue("@p1", lstPersonelDuzenle.SelectedValue);
            Ayar.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtPersonelDuzenlePersonelNo.Text = dr["PersonelNo"].ToString();
                txtPersonelDuzenleTC.Text = dr["TC"].ToString();
                txtPersonelDuzenleKullanıcıAdı.Text = dr["KullaniciAdi"].ToString();
                txtPersonelDuzenleAdıSoyadı.Text = dr["AdiSoyadi"].ToString();
                txtPersonelDuzenleTelNo.Text = dr["Telefon"].ToString();
                txtPersonelDuzenleMail.Text = dr["Mail"].ToString();
                txtPersonelDuzenleAdres.Text = dr["Adres"].ToString();
                txtPersonelDuzenleGörevi.Text = dr["Görevi"].ToString();
                txtPersonelDuzenleMaas.Text = dr["Maaş"].ToString();
                txtPersonelDuzenleSifre.Text = dr["Sifre"].ToString();
                cbbPersonelDuzenleYetki.SelectedValue = dr["Yetkisi"];

            }
            Ayar.con.Close();
            btnPersonelDuzenleGuncelle.Enabled = true;
            btnPersonelDüzenleSil.Enabled = true;
        }

        private void btnPersonelDuzenleGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPersonelDuzenlePersonelNo.Text != "" && txtPersonelDuzenleMaas.Text != "" && txtPersonelDuzenleKullanıcıAdı.Text != "" && txtPersonelDuzenleGörevi.Text != "" && txtPersonelDuzenleMail.Text != "" && txtPersonelDuzenleAdres.Text != "" && txtPersonelDuzenleAdıSoyadı.Text != "" && txtPersonelDuzenleSifre.Text != "" && txtPersonelDuzenleTC.Text != "" && txtPersonelDuzenleTelNo.Text != "" && cbbPersonelDuzenleYetki.Text != "")
            {


                SqlCommand kontrol = new SqlCommand("Select TC,KullaniciAdi,PersonelNo From Personel Where TC = @p1 OR KullaniciAdi = @p2 AND PersonelNo != @p3", Ayar.con);
                kontrol.Parameters.AddWithValue("@p1", txtPersonelDuzenleTC.Text);
                kontrol.Parameters.AddWithValue("@p2", txtPersonelDuzenleKullanıcıAdı.Text);
                kontrol.Parameters.AddWithValue("@p3", txtPersonelDuzenlePersonelNo.Text);
                Ayar.con.Open();
                SqlDataReader dr = kontrol.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu TC veya Kullanıcı Adı zaten kullanılıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Ayar.con.Close();
                }
                else
                {
                    dr.Close();
                    Ayar.con.Close();
                    SqlCommand cmd = new SqlCommand("Update Personel set KullaniciAdi = @akdi, AdiSoyadi=@ad,TC=@tc, Telefon=@tel, Mail=@mail,Adres=@adres,Görevi=@gorev,Yetkisi=@yetki,Maaş=@maas,Sifre=@sifre where PersonelNo = @pno", Ayar.con);
                    cmd.Parameters.AddWithValue("@pno", txtPersonelDuzenlePersonelNo.Text);
                    cmd.Parameters.AddWithValue("@akdi", txtPersonelDuzenleKullanıcıAdı.Text);
                    cmd.Parameters.AddWithValue("@ad", txtPersonelDuzenleAdıSoyadı.Text);
                    cmd.Parameters.AddWithValue("@tc", txtPersonelDuzenleTC.Text);
                    cmd.Parameters.AddWithValue("@tel", txtPersonelDuzenleTelNo.Text);
                    cmd.Parameters.AddWithValue("@mail", txtPersonelDuzenleMail.Text);
                    cmd.Parameters.AddWithValue("@adres", txtPersonelDuzenleAdres.Text);
                    cmd.Parameters.AddWithValue("@gorev", txtPersonelDuzenleGörevi.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@yetki", cbbPersonelDuzenleYetki.SelectedValue);
                    cmd.Parameters.AddWithValue("@maas", txtPersonelDuzenleMaas.Text);
                    cmd.Parameters.AddWithValue("@sifre", Ayar.sifrele(txtPersonelDuzenleSifre.Text, Ayar.anahtarkelime));
                    Ayar.con.Open();
                    cmd.ExecuteNonQuery();
                    Ayar.con.Close();
                    btnPersonelDuzenleGuncelle.Enabled = false;
                    btnPersonelDüzenleSil.Enabled = false;
                    personeldoldur();
                    yetkidoldur();
                    foreach (Control item in this.pnlPersonelDuzenle.Controls)
                    {
                        if (item is TextBox || item is MaskedTextBox || item is RichTextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnPersonelDüzenleSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelDuzenlePersonelNo.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Personel set Silindi =1 where PersonelNo =@p1 ", Ayar.con);
                cmd.Parameters.AddWithValue("@p1", txtPersonelDuzenlePersonelNo.Text);
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                btnPersonelDuzenleGuncelle.Enabled = false;
                btnPersonelDüzenleSil.Enabled = false;
                personeldoldur();
                yetkidoldur();
                foreach (Control item in this.pnlPersonelDuzenle.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox || item is RichTextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapın", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCihazKayıt_Click(object sender, EventArgs e)
        {
            FrmCihazKayit chz = new FrmCihazKayit();
            chz.Show();
        }
        bool iletisimvar = false;

        private void btnSirgetBilgiveLimitler_Click(object sender, EventArgs e)
        {
            panellerikapat();
            pnlSirgetBilgiveLimitler.Visible = true;
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Islemler Where Silindi = 0", Ayar.con);
            DataTable table = new DataTable();
            Ayar.con.Open();
            adtr.Fill(table);
            cbmIslem.DataSource = null;
            cbmIslem.DisplayMember = "Islem";
            cbmIslem.ValueMember = "IslemId";
            cbmIslem.DataSource = table;
            Ayar.con.Close();
            cbmIslem.SelectedValue = 0;

            SqlCommand cmd = new SqlCommand("Select * From Sistem", Ayar.con);
            Ayar.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                iletisimvar = true;
                txtSirketAdi.Text = dr["SirketAdi"].ToString();
                txtVergiNo.Text = dr["SirketVergiNo"].ToString();
                txtSirketTel.Text = dr["SirketTelefon"].ToString();
                txtSirketFax.Text = dr["SirketFax"].ToString();
                txtSirketAdres.Text = dr["SirketAdres"].ToString();
                txtSirketMail.Text = dr["SirketMail"].ToString();
                TxtGöndericiMail.Text = dr["SirketGonderenMail"].ToString();
                TxtGöndericiMailSifre.Text = Ayar.sifreCoz(dr["GonderenMailSifre"].ToString(), Ayar.anahtarkelime);
                txtSirketCariLimit.Text = dr["MaximunCariTutari"].ToString();
            }
            else
            {
                iletisimvar = false;
            }
            Ayar.con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (iletisimvar == true)
            {
                sql = "Update Sistem set SirketAdi=@p1, SirketVergiNo = @p2, SirketTelefon = @p3, SirketFax=@p4, SirketAdres = @p5, SirketMail=@p6, SirketGonderenMail=@p7, GonderenMailSifre=@p8";
            }
            else
            {
                sql = "Insert Into Sistem (SirketAdi,SirketVergiNo,SirketTelefon,SirketFax,SirketAdres,SirketMail,SirketGonderenMail,GonderenMailSifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            }
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Ayar.con);
                cmd.Parameters.AddWithValue("@p1", txtSirketAdi.Text);
                cmd.Parameters.AddWithValue("@p2", txtVergiNo.Text);
                cmd.Parameters.AddWithValue("@p3", txtSirketTel.Text);
                cmd.Parameters.AddWithValue("@p4", txtSirketFax.Text);
                cmd.Parameters.AddWithValue("@p5", txtSirketAdres.Text);
                cmd.Parameters.AddWithValue("@p6", txtSirketMail.Text);
                cmd.Parameters.AddWithValue("@p7", TxtGöndericiMail.Text);
                cmd.Parameters.AddWithValue("@p8", Ayar.sifrele(TxtGöndericiMailSifre.Text, Ayar.anahtarkelime));
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                MessageBox.Show("İşlem başarılı, değişiklikler kayıt edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panellerikapat();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu. Daha sonra tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCariGüncelle_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (iletisimvar == true)
            {
                sql = "Update Sistem set MaximunCariTutari=@p1";
            }
            else
            {
                sql = "Insert Into Sistem (MaximunCariTutari) values (@p1)";
            }
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Ayar.con);
                cmd.Parameters.AddWithValue("@p1", txtSirketCariLimit.Text);
                Ayar.con.Open();
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                MessageBox.Show("İşlem başarılı, değişiklikler kayıt edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu, daha sonra tekrar deneyin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnIslemSil_Click(object sender, EventArgs e)
        {

            if (cbmIslem.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Islemler set Silindi=1 Where IslemId=@p1", Ayar.con);
                Ayar.con.Open();
                cmd.Parameters.AddWithValue("@p1", cbmIslem.SelectedValue);
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                MessageBox.Show("İşlem başarılı, değişiklikler kayıt edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panellerikapat();
            }
            else
            {
                MessageBox.Show("İşlemenizi seçmelisiniz.");
            }
        }

        private void BtnIslemEkle_Click(object sender, EventArgs e)
        {
            if (txtIslem.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Islemler (Islem) values (@p1)", Ayar.con);
                Ayar.con.Open();
                cmd.Parameters.AddWithValue("@p1", txtIslem.Text.ToUpper());
                cmd.ExecuteNonQuery();
                Ayar.con.Close();
                MessageBox.Show("İşlem başarılı, değişiklikler kayıt edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panellerikapat();
            }
            else
            {
                MessageBox.Show("İşlemenizi seçmelisiniz.");
            }
        }

        private void btnMailGönder_Click(object sender, EventArgs e)
        {
            FrmMailGönder mail = new FrmMailGönder();
            mail.Show();
        }
    }


}

