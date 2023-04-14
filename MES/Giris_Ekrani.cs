using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MES
{
    public partial class Giris_Ekrani : Form
    {
        
        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        IFirebaseConfig ayar = new FirebaseConfig()
        {
            BasePath = "https://mes-856ce-default-rtdb.europe-west1.firebasedatabase.app/",
            AuthSecret =  "GPUiUqI8cfVbnGlitQjHuLg51u73o0GBqPaQlmPE"
        };
        IFirebaseClient baglanti;


        private void Giris_Ekrani_Load(object sender, EventArgs e)
        {

        }

        private void kapatD_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Giris_Ekrani_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void KullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (KullaniciAdi.Text == "\r\nKullanıcı Adı veya E-Posta")
            KullaniciAdi.Text = "";
        }

        private void KullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (KullaniciAdi.Text == "")
                KullaniciAdi.Text = "\r\nKullanıcı Adı veya E-Posta";
        }

        private void Sifre_Enter(object sender, EventArgs e)
        {
            if (Sifre.Text == "Şifre")
                Sifre.Text = "";
        }

        private void Sifre_Leave(object sender, EventArgs e)
        {
            if (Sifre.Text == "")
                Sifre.Text = "Şifre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new FireSharp.FirebaseClient(ayar);

            if (baglanti != null)
                MessageBox.Show("Bağlantı sağlandı.");

            var kullanici = new Kullanicilar()
            {
                kullaniciAdi = KullaniciAdi.Text,
                sifre = Sifre.Text
            };
            /*
            var setet = baglanti.SetAsync("Kullanicilar/" + kullanici.kullaniciAdi, kullanici);
            if (setet != null)
                MessageBox.Show("Eklendi");*/

            FirebaseResponse getir = baglanti.Get(@"Kullanicilar");
            Dictionary<string, Kullanicilar> veri = JsonConvert.DeserializeObject < Dictionary<string, Kullanicilar> > (getir.Body.ToString());

            foreach(var item in veri)
            {
                if(item.Value.kullaniciAdi == KullaniciAdi.Text && item.Value.sifre == Sifre.Text)
                {
                    MessageBox.Show("Giriş yapıldı.");
                }
            }
        }
    }
}