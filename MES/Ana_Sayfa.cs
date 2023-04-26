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
        public Ana_Sayfa()
        {
            InitializeComponent();
        }


        private void kapatD_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void makiinelistesibtn_Click(object sender, EventArgs e)
        {
            var nesne = new MakineListesi();
            panel.Controls.Clear();
            panel.Controls.Add(nesne);

        }

        private void makineeklecikarbtn_Click(object sender, EventArgs e)
        {
            var nesne = new MakineEkleCikar();
            panel.Controls.Clear();
            panel.Controls.Add(nesne);
        }

        private void panel_Enter(object sender, EventArgs e)
        {

        }

        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
