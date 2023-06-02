using Firebase.Auth;
using Firebase.Database;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.controls
{
    public partial class Personel_Listesi : UserControl
    {
        private UserCredential kullanici_kimligi;
        private FirebaseClient istemci;
        private FirebaseStorage depolama;
        public Personel_Listesi(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            this.kullanici_kimligi = kullanici_kimligi;
            try
            {
                this.kullanici_kimligi = kullanici_kimligi;
                this.istemci = new FirebaseClient(Config.FBDomain,
                    new FirebaseOptions
                    {
                        AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                    });
                this.depolama = new FirebaseStorage(Config.FSDomain,
                 new FirebaseStorageOptions
                 {
                     AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync(),
                     ThrowOnCancel = true,
                 });
            }
            catch (Exception exc)
            {
                MessageBox.Show("Hata: " + exc.Message);

            }
        }

        private void SifreGor(object sender, EventArgs e)
        {
            SifreTB.PasswordChar = '\0';
        }

        private void SifreKapa(object sender, EventArgs e)
        {
            SifreTB.PasswordChar = '*';
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
