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
    public partial class MakineEkleCikar : UserControl
    {
        public MakineEkleCikar()
        {
            InitializeComponent();
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith(" ") || textBox2.Text.StartsWith(" ") || textBox3.Text.StartsWith(" "))
                MessageBox.Show("Eksik bilgi girdiniz ??");
            else
            {
                MakineListesiTablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
            }
        }

        private void Guncellebt_Click(object sender, EventArgs e)
        {
            if (MakineListesiTablo.SelectedRows.Count == 0)
                return;
            else 
            {
                 DataGridViewRow a = MakineListesiTablo.SelectedRows[0];
                a.Cells[0].Value = textBox1.Text.ToString();
                a.Cells[1].Value = textBox2.Text.ToString();
                a.Cells[2].Value = textBox3.Text.ToString();
               
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
                    return;
                else
                {
                    MakineListesiTablo.Rows.Remove(MakineListesiTablo.SelectedRows[0]);
                }
                 
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith(" "))
                textBox1.Clear();
            else return;
            
           // textBox1.Text=" ";
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.StartsWith(" "))
                textBox2.Clear();
            else return;
            //textBox1.Text = " ";
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.StartsWith(" "))
                textBox3.Clear();
            else return;
        }
    }
}
