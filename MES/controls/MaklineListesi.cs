using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MES.controls
{
    public partial class MakineListesi: UserControl
    {
        private UserCredential kullanici_kimligi;
        private FirebaseClient istemci;
        private string resim_url = "";
        FirebaseStorage depolama;
        public MakineListesi(UserCredential kullanici_kimligi)
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
        

        private async void Eklebtn_Click(object sender, EventArgs e)
        {
            Makineler makine = new Makineler()
            {
                adi = makineAdiTB.Text,
                seriNo = makineSeriNoTB.Text,
                dep = MakineDepTB.Text,
                durum = MakineDurumTB.Text,
                
            };

            if (resim_url != "")
            {
             
                FileStream stream = File.Open(resim_url, FileMode.Open);
                FirebaseStorageTask gonder = depolama.Child(makine.seriNo).Child("MakinaResim").PutAsync(stream);
                gonder.Progress.ProgressChanged += (s, evnt) => MakineResimPB.Value = evnt.Percentage;
                makine.resimUrl = makineSeriNoTB.Text + "/MakinaResim";
            }


            await istemci.Child("Makineler").Child(makine.seriNo.ToString()).PutAsync(makine);

            liste();
            resim_url = "";
        }


        public async void liste()
        {

            MakineListesiTablo.Rows.Clear();
            MakineListesiTablo.Columns.Clear();
            MakineListesiTablo.Columns.Add("seriNo", "Makine Seri No");
            MakineListesiTablo.Columns.Add("Adi", "Makine Adı");
            MakineListesiTablo.Columns.Add("Departman","Bulunduğu Departman");
            MakineListesiTablo.Columns.Add("Durum", "Makine Durumu");

            IReadOnlyCollection<FirebaseObject<Makineler>> veri = await istemci.Child("Makineler").OnceAsync<Makineler>();
            if (veri != null)
            {
                foreach (var item in veri)
                {
                    MakineListesiTablo.Rows.Add(item.Object.seriNo, item.Object.adi, item.Object.dep, item.Object.durum);
                }
            }
        }

        private async void Silbtn_Click(object sender, EventArgs e)
        {
            var veri = await istemci
                                     .Child("Makineler")
                                     .Child(makineSeriNoTB.Text)
                                     .OnceSingleAsync<Makineler>();

            if (veri == null)
                MessageBox.Show("Silmek istediğiniz veri bulunamadı");
            else
            {
                DialogResult result = MessageBox.Show("Makine silinecek, emin misiniz?", caption: "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    await istemci.Child("Makineler").Child(makineSeriNoTB.Text).DeleteAsync();
                    await depolama.Child(makineSeriNoTB.Text).Child("MakinaResim").DeleteAsync();
                    liste();
                    makineSeriNoTB.Text = string.Empty;
                    veriTemizle();
                    resimsizYap();
                    MessageBox.Show("Silindi");

                }

            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (makineAdiTB.Text.StartsWith(" "))
                makineAdiTB.Clear();
            else return;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (makineSeriNoTB.Text.StartsWith(" "))
                makineSeriNoTB.Clear();
            else return;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            if (MakineDepTB.Text.StartsWith(" "))
                MakineDepTB.Clear();
            else return;
        }


        private void MakineEkleCikar_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void Secbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            if(resimsec.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = File.Open(resimsec.FileName, FileMode.Open);
                Image resim = (Image)Image.FromStream(stream).Clone();
                MakineResim.Image = resim;
                stream.Close();
                resim_url = resimsec.FileName;
            }
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
                        MakineResim.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }
        private async void resimGetir()
        {
            FirebaseStorageReference resimReferansi = depolama.Child(makineSeriNoTB.Text).Child("MakinaResim");
            string resimUrl = await resimReferansi.GetDownloadUrlAsync();
            if (!string.IsNullOrEmpty(resimUrl))
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] resimBytes = await webClient.DownloadDataTaskAsync(resimUrl);
                    using (MemoryStream memoryStream = new MemoryStream(resimBytes))
                    {
                        MakineResim.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }
        private void veriTemizle()
        {
            makineAdiTB.Text = string.Empty;
            MakineDepTB.Text = string.Empty;
            MakineDurumTB.Text = string.Empty;
        }
        private void veriDoldur(Makineler veri)
        {
            makineSeriNoTB.Text = veri.seriNo;
            makineAdiTB.Text = veri.adi;
            MakineDepTB.Text = veri.dep;
            MakineDurumTB.Text = veri.durum;
        }

        private async void MakinaSecili(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow secili = MakineListesiTablo.Rows[e.RowIndex];
                var veri = await istemci
                                        .Child("Makineler")
                                        .Child(secili.Cells[0].Value.ToString())
                                        .OnceSingleAsync<Makineler>();
                veriDoldur(veri);

                if (veri.resimUrl == null)
                    resimsizYap();
                else
                    resimGetir();

            }
        }

        private async void MakineSeiNoGris(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(makineSeriNoTB.Text))
            {
                Eklebtn.Text = "Ekle";
                veriTemizle();
                resimsizYap();
            }
            else
            {
                var veri = await istemci
                                        .Child("Makineler")
                                        .Child(makineSeriNoTB.Text)
                                        .OnceSingleAsync<Makineler>();
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
    }
}
