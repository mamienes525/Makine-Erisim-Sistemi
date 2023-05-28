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
        private string AuthDomain;
        private string ApiKey;
        private FirebaseAuthClient client;

        public Giris_Ekrani(string AuthDomian, string ApiKey)
        {
            InitializeComponent();
            this.AuthDomain = AuthDomian;
            this.ApiKey = ApiKey;

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
            try
            {
                var kullanici_kimligi = await client.SignInWithEmailAndPasswordAsync
                (KullaniciAdi.Text.Trim(), Sifre.Text.Trim());
                Ana_Sayfa ana_Sayfa = new Ana_Sayfa(kullanici_kimligi);
                ana_Sayfa.Show();
                this.Hide();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Hata: "+ exc.Message);
            }  
            
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
    }
}