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
using System.Net.Mail;

namespace Teknik_Servis
{
    public partial class FrmMailGönder : Form
    {
        public FrmMailGönder()
        {
            InitializeComponent();
        }
        string gondericimail = "", gondericimailsifre = "", sirketadi = "";
        void doldur()
        {
            SqlCommand cmd = new SqlCommand("Select * From Sistem", Ayar.con);

            if (Ayar.con.State == ConnectionState.Closed)
            {
                Ayar.con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtGondericiMail.Text = dr["SirketGonderenMail"].ToString();
                gondericimail = dr["SirketGonderenMail"].ToString();
                sirketadi = dr["SirketAdi"].ToString();
                gondericimailsifre = dr["GonderenMailSifre"].ToString();
                txtImza.Text = dr["SirketAdi"].ToString() + "\n Telefon :" + dr["SirketTelefon"].ToString() + "\n Fax:" + dr["SirketFax"].ToString() + "\n Mail:" + dr["SirketMail"].ToString() + "\n Adres:" + dr["SirketAdres"].ToString();
            }
            Ayar.con.Close();


        }
        private void grpGönderici_Enter(object sender, EventArgs e)
        {
 
        }

        private void chcDuzenle_CheckedChanged(object sender, EventArgs e)
        {
            if (chcDuzenle.Checked == true)
            {
                txtImza.Enabled = true;
            }
            else
            {
                txtImza.Enabled = false;
            }
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGönder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlıcıMail.Text))
            {
                MessageBox.Show("Lütfen alıcı e-posta adresini giriniz.");
                return;
            }

            try
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress(gondericimail, sirketadi);
                ePosta.To.Add(txtAlıcıMail.Text);
                ePosta.Subject = txtKonu.Text;
                ePosta.Body = txtMesaj.Text + Environment.NewLine + txtImza.Text;

                SmtpClient smtp = new SmtpClient();

                // === GOOGLE UYGULAMA ŞİFRESİ BURAYA İŞLENDİ ===
                // Tırnak içindeki yazı silinip yerine Google'dan aldığın 16 haneli şifre yazılacak:
                string guncelSifre = "xqde wajq uqmi gnhf";

                smtp.Credentials = new System.Net.NetworkCredential(gondericimail, guncelSifre);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;

                // Bağlantı kopmalarını önleyen güvenlik protokolü
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls13;

                smtp.Send(ePosta);
                MessageBox.Show("Mail Başarıyla Gönderildi!");
                this.Close();
            }
            catch (Exception ex)
            {
                string hataDetayi = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Mail Gönderilemedi!\n\nDetay: " + hataDetayi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMailGönder_Load(object sender, EventArgs e)
        {
            txtGondericiMail.Text = "";
            txtAlıcıMail.Text = "";
            txtKonu.Text = "";
            txtMesaj.Text = "";
            txtImza.Text = "";
            doldur();
        }
    }
}
