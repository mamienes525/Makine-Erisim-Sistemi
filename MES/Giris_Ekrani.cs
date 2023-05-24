using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace MES
{
    public partial class Giris_Ekrani : Form
    {

        //IFirebaseConfig ayar = new FirebaseConfig() { };
        //IFirebaseClient baglanti;
        private string AuthDomain;
        private string ApiKey;
        private FirebaseAuthClient client;

        public Giris_Ekrani(string AuthDomian, string ApiKey)
        {
            //ayar.BasePath = AuthDomian;
            //ayar.AuthSecret = ApiKey;
            InitializeComponent();
            this.AuthDomain = AuthDomian;
            this.ApiKey = ApiKey;

            //***
            var config = new FirebaseAuthConfig
            {
                ApiKey = this.ApiKey,
                AuthDomain = this.AuthDomain,
                Providers = new FirebaseAuthProvider[]{new EmailProvider() },
            };

            
            client = new FirebaseAuthClient(config);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            
            var kullanici_kimligi = await client.SignInWithEmailAndPasswordAsync
                (KullaniciAdi.Text.Trim(),Sifre.Text.Trim ());
            MessageBox.Show(kullanici_kimligi.User.Uid);
            /*
            baglanti = new FireSharp.FirebaseClient(ayar);

            //if (baglanti != null)
             //   MessageBox.Show("Bağlantı sağlandı.");

            var kullanici = new Kullanicilar()
            {
                kullaniciAdi = KullaniciAdi.Text,
                sifre = Sifre.Text
            };

            FirebaseResponse getir = baglanti.Get(@"Kullanicilar");
            Dictionary<string, Kullanicilar> veri = JsonConvert.DeserializeObject < Dictionary<string, Kullanicilar> > (getir.Body.ToString());

            foreach(var item in veri)
            {
                if(item.Value.kullaniciAdi == KullaniciAdi.Text && item.Value.sifre == Sifre.Text)
                {
                   Ana_Sayfa ana_Sayfa = new Ana_Sayfa(ayar.BasePath, ayar.AuthSecret);
                    ana_Sayfa.Show();
                    this.Hide();
                }

            }
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyDopog4FqATkfDDHHTzF251Pux6YBJsVHE",
                AuthDomain = "mess-4073b.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
    {
                // Add and configure individual providers
                new GoogleProvider().AddScopes("email"),
                new EmailProvider()
                 // ...
    },  
                // WPF:
                //UserRepository = new FileUserRepository("FirebaseSample") // persist data into %AppData%\FirebaseSample
                // UWP:
                //UserRepository = new StorageRepository() // persist data into ApplicationDataContainer
            };

            // ...and create your FirebaseAuthClient
            var client = new FirebaseAuthClient(config);*/
        }

        private void kapatD_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}