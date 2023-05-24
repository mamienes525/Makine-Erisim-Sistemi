using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MES.controls
{
    public partial class MakineEkleCikar : UserControl
    {

        IFirebaseConfig ayar = new FirebaseConfig() { };
        IFirebaseClient baglanti;

        public MakineEkleCikar(string AuthDomian, string ApiKey)
        {
            ayar.BasePath = AuthDomian;
            ayar.AuthSecret = ApiKey;
            ayar.AuthSecret = ApiKey;
            baglanti = new FireSharp.FirebaseClient(ayar);
            InitializeComponent();
        }
        

        private void  Eklebtn_Click(object sender, EventArgs e)
        {

                Makineler makine = new Makineler()
                {
                    adi = makineAdiTB.Text,
                    seriNo = makineSeriNoTB.Text,
                    dep = MakineDepTB.Text
                };

                var setet = baglanti.Set("Makineler/" + makineSeriNoTB.Text, makine);
                liste();
            if (setet != null) {
                MessageBox.Show("Eklendi");
            }
        }


        public void liste()
        {

            MakineListesiTablo.Rows.Clear();
            MakineListesiTablo.Columns.Clear();
            MakineListesiTablo.Columns.Add("seriNo", "Makine Seri No");
            MakineListesiTablo.Columns.Add("Adi", "Makine Adı");
            MakineListesiTablo.Columns.Add("Departman","Bulunduğu Departman");

            FirebaseResponse getir = baglanti.Get(@"Makineler/");
            Dictionary<string, Makineler> veri = JsonConvert.DeserializeObject<Dictionary<string, Makineler>>(getir.Body.ToString());
            if (veri != null)
            {
                foreach (var item in veri)
                {
                    MakineListesiTablo.Rows.Add(item.Value.seriNo, item.Value.adi, item.Value.dep);
                }
            }
        }

        private void Guncellebt_Click(object sender, EventArgs e)
        {
            if (MakineListesiTablo.SelectedRows.Count == 0)
                return;
            else 
            {
                 DataGridViewRow a = MakineListesiTablo.SelectedRows[0];
                a.Cells[0].Value = makineAdiTB.Text.ToString();
                a.Cells[1].Value = makineSeriNoTB.Text.ToString();
                a.Cells[2].Value = MakineDepTB.Text.ToString();
               
            }
                
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            if (MakineListesiTablo.SelectedRows.Count == 0)
                return;
            else
            {
               DialogResult result= MessageBox.Show("Seçilen kayıtlı makine silinecek, emin misiniz?", caption:"uyarı",MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if (result != DialogResult.Yes)
                {

                    return;
                }
                else
                {
                    var sil = baglanti.Delete("Makineler/" + MakineListesiTablo.SelectedRows[0].Cells[0].Value.ToString());
                    liste();
                    if (sil != null)
                    {
                        MessageBox.Show("Silindi");
                    }
                }
                 
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (makineAdiTB.Text.StartsWith(" "))
                makineAdiTB.Clear();
            else return;
            
           // textBox1.Text=" ";
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (makineSeriNoTB.Text.StartsWith(" "))
                makineSeriNoTB.Clear();
            else return;
            //textBox1.Text = " ";
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            if (MakineDepTB.Text.StartsWith(" "))
                MakineDepTB.Clear();
            else return;
        }

      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MakineEkleCikar_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
