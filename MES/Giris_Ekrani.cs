using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MES
{
    public partial class Giris_Ekrani : Form
    {
        
        public Giris_Ekrani()
        {
            InitializeComponent();
        }
      
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
    }
}