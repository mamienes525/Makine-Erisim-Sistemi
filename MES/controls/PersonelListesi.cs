using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        private string resim_url = "";
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
        private async void listele()
        {
            PersonelListesiTablo.Rows.Clear();
            PersonelListesiTablo.Columns.Clear();
            PersonelListesiTablo.Columns.Add("isim", "Kullanıcı Adı");
            PersonelListesiTablo.Columns.Add("eposta", "E-Posta Adresi");
            PersonelListesiTablo.Columns[0].Width = 200;
            PersonelListesiTablo.Columns[1].Width = 200;
            IReadOnlyCollection<FirebaseObject<Kullanicilar>> veri = await istemci.Child("Kullanıcılar").OnceAsync<Kullanicilar>();
            if (veri != null)
            {
                foreach (var item in veri)
                {
                    PersonelListesiTablo.Rows.Add(item.Object.isim, item.Object.eposta);
                }
            }
        }
        private async void Eklebtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar()
            {
                isim = isimTB.Text,
                eposta = EPostaTB.Text,
            };

            if (resim_url != "")
            {

                FileStream stream = File.Open(resim_url, FileMode.Open);
                FirebaseStorageTask gonder = depolama.Child(kullanici.isim).Child("KullanıcıResim").PutAsync(stream);
                gonder.Progress.ProgressChanged += (s, evnt) => MakineResimPB.Value = evnt.Percentage;
                kullanici.resimUrl = kullanici.isim + "/KullanıcıResim";
            }

            await istemci.Child("Kullanıcılar").Child(kullanici.isim).PutAsync(kullanici);
            listele();
        }

        private void Secbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            if (resimsec.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = File.Open(resimsec.FileName, FileMode.Open);
                Image resim = (Image)Image.FromStream(stream).Clone();
                KullaniciResim.Image = resim;
                stream.Close();
                resim_url = resimsec.FileName;
            }
        }

        private void Personel_Listesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private async void resimsizYap()
        {
            FirebaseStorageReference resimReferansi = depolama.Child("resimsiz.png");
            string resimUrl = await resimReferansi.GetDownloadUrlAsync();
            if (!string.IsNullOrEmpty(resimUrl))
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] resimBytes = await webClient.DownloadDataTaskAsync(resimUrl);
                    using (MemoryStream memoryStream = new MemoryStream(resimBytes))
                    {
                        KullaniciResim.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }

        private async void resimGetir()
        {
            FirebaseStorageReference resimReferansi = depolama.Child(isimTB.Text).Child("KullanıcıResim");
            string resimUrl = await resimReferansi.GetDownloadUrlAsync();
            if (!string.IsNullOrEmpty(resimUrl))
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] resimBytes = await webClient.DownloadDataTaskAsync(resimUrl);
                    using (MemoryStream memoryStream = new MemoryStream(resimBytes))
                    {
                        KullaniciResim.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }

        private async void KullaniciSecili(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow secili = PersonelListesiTablo.Rows[e.RowIndex];
                var veri = await istemci
                                        .Child("Kullanıcılar")
                                        .Child(secili.Cells[0].Value.ToString())
                                        .OnceSingleAsync<Kullanicilar>();
                veriDoldur(veri);

                if (veri.resimUrl == null)
                    resimsizYap();
                else
                    resimGetir();

            }
        }

        private void veriDoldur(Kullanicilar veri)
        {
            isimTB.Text = veri.isim;
            EPostaTB.Text = veri.eposta;
        }
        private void veriTemizle()
        {
            EPostaTB.Text = string.Empty;
        }

        private async void KullaniciAdiGiris(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(isimTB.Text))
            {
                Eklebtn.Text = "Ekle";
                veriTemizle();
                resimsizYap();
            }
            else
            {
                var veri = await istemci
                                        .Child("Kullanıcılar")
                                        .Child(isimTB.Text)
                                        .OnceSingleAsync<Kullanicilar>();
                if (veri == null)
                {
                    Eklebtn.Text = "Ekle";
                    veriTemizle();
                    resimsizYap();
                }
                else
                {
                    Eklebtn.Text = "Güncelle";
                    veriDoldur(veri);
                    if (veri.resimUrl == null)
                        resimsizYap();
                    else
                        resimGetir();
                }
            }
        }

        private async void Silbtn_Click(object sender, EventArgs e)
        {
            var veri = await istemci
                                        .Child("Kullanıcılar")
                                        .Child(isimTB.Text)
                                        .OnceSingleAsync<Kullanicilar>();

            if (veri == null)
                MessageBox.Show("Silmek istediğiniz veri bulunamadı");
            else
            {
                DialogResult result = MessageBox.Show("Kullanıcı silinecek, emin misiniz?", caption: "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    await istemci.Child("Kullanıcılar").Child(isimTB.Text).DeleteAsync();
                    await depolama.Child(isimTB.Text).Child("KullanıcıResim").DeleteAsync();
                    listele();
                    isimTB.Text = string.Empty;
                    veriTemizle();
                    resimsizYap();
                    MessageBox.Show("Silindi");

                }

            }
        }
    }
}
