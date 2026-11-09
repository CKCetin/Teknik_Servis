using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.IO;


namespace Teknik_Servis
{
    public partial class DatabaseBilgiler : Form
    {
        public DatabaseBilgiler()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAnahtar.Text != "" && txtKullanici.Text !="" && txtSifre.Text !="" && txtSunucuAdi.Text !="" && txtVeritabani.Text !="")
            {
                XmlTextWriter yaz = new XmlTextWriter(Application.StartupPath + "\\settings.xml", System.Text.UTF8Encoding.UTF8);
                yaz.Formatting = Formatting.Indented;
                try 
                {
                    yaz.WriteStartDocument();
                    yaz.WriteStartElement("Setting");
                    yaz.WriteStartElement("DB");
                    yaz.WriteElementString("Provider", "SQLOLEDB.1");
                    yaz.WriteElementString("ServerName", txtSunucuAdi.Text);
                    yaz.WriteElementString("DatabaseName", txtVeritabani.Text);
                    yaz.WriteElementString("UserID", txtKullanici.Text);
                    yaz.WriteElementString("Password", Ayar.sifrele(txtSifre.Text , txtAnahtar.Text));
                    yaz.WriteElementString("Keys", txtAnahtar.Text);
                    yaz.WriteEndElement();
                    yaz.WriteEndElement();
                    yaz.Close();
                    MessageBox.Show("Ayarlar Dosyanız Oluştu, Program yeniden başladıktan sonra hazır olacacktır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hata Mesajı :" + ex.Message.ToString(), "Hata Alındı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
        }
    }
}
