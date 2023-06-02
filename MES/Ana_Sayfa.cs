using Firebase.Auth;
using Firebase.Database;
using FireSharp.Config;
using FireSharp.Interfaces;
using MES.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class Ana_Sayfa : Form
    {
        private UserCredential kullanici_kimligi;

        public Ana_Sayfa(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            try
            {
                this.kullanici_kimligi = kullanici_kimligi;
                var firebaseClient = new FirebaseClient(Config.FBDomain,
                    new FirebaseOptions
                    {
                        AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                    }
                );
            }
            catch(Exception exc) {
                MessageBox.Show("Hata: " + exc.Message);
            
            }

        }


        private void kapatD_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void makiinelistesibtn_Click(object sender, EventArgs e)
        {
            var nesne = new MakineListesi(kullanici_kimligi);
            panel.Controls.Clear();
            panel.Controls.Add(nesne);

        }

        private void panel_Enter(object sender, EventArgs e)
        {

        }

        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {

        }

        private void personellistesibtn_Click(object sender, EventArgs e)
        {
            var nesne = new Personel_Listesi(kullanici_kimligi);
            panel.Controls.Clear();
            panel.Controls.Add(nesne);
        }
    }
}
