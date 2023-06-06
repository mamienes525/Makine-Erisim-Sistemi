namespace MES.controls
{
    partial class Personel_Listesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Listesi));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MakineResimPB = new System.Windows.Forms.ProgressBar();
            this.Secbtn = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.PersonelListesiTablo = new System.Windows.Forms.DataGridView();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.KullaniciResim = new System.Windows.Forms.PictureBox();
            this.isimTB = new System.Windows.Forms.TextBox();
            this.EPostaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListesiTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciResim)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MakineResimPB
            // 
            this.MakineResimPB.Location = new System.Drawing.Point(111, 263);
            this.MakineResimPB.Margin = new System.Windows.Forms.Padding(4);
            this.MakineResimPB.Name = "MakineResimPB";
            this.MakineResimPB.Size = new System.Drawing.Size(247, 28);
            this.MakineResimPB.TabIndex = 17;
            this.MakineResimPB.Visible = false;
            // 
            // Secbtn
            // 
            this.Secbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Secbtn.Location = new System.Drawing.Point(365, 263);
            this.Secbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Secbtn.Name = "Secbtn";
            this.Secbtn.Size = new System.Drawing.Size(52, 30);
            this.Secbtn.TabIndex = 6;
            this.Secbtn.Text = "SEÇ";
            this.Secbtn.UseVisualStyleBackColor = true;
            this.Secbtn.Click += new System.EventHandler(this.Secbtn_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Silbtn.Location = new System.Drawing.Point(882, 440);
            this.Silbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(221, 48);
            this.Silbtn.TabIndex = 7;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // PersonelListesiTablo
            // 
            this.PersonelListesiTablo.AllowUserToAddRows = false;
            this.PersonelListesiTablo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent;
            this.PersonelListesiTablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.PersonelListesiTablo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PersonelListesiTablo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonelListesiTablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.PersonelListesiTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonelListesiTablo.DefaultCellStyle = dataGridViewCellStyle13;
            this.PersonelListesiTablo.Location = new System.Drawing.Point(0, 0);
            this.PersonelListesiTablo.Margin = new System.Windows.Forms.Padding(4);
            this.PersonelListesiTablo.Name = "PersonelListesiTablo";
            this.PersonelListesiTablo.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonelListesiTablo.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.PersonelListesiTablo.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.PersonelListesiTablo.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.PersonelListesiTablo.Size = new System.Drawing.Size(607, 777);
            this.PersonelListesiTablo.TabIndex = 8;
            this.PersonelListesiTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KullaniciSecili);
            // 
            // Eklebtn
            // 
            this.Eklebtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eklebtn.Location = new System.Drawing.Point(653, 440);
            this.Eklebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(221, 48);
            this.Eklebtn.TabIndex = 6;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // KullaniciResim
            // 
            this.KullaniciResim.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciResim.Image")));
            this.KullaniciResim.Location = new System.Drawing.Point(111, 27);
            this.KullaniciResim.Margin = new System.Windows.Forms.Padding(4);
            this.KullaniciResim.Name = "KullaniciResim";
            this.KullaniciResim.Size = new System.Drawing.Size(307, 266);
            this.KullaniciResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KullaniciResim.TabIndex = 14;
            this.KullaniciResim.TabStop = false;
            // 
            // isimTB
            // 
            this.isimTB.Location = new System.Drawing.Point(243, 325);
            this.isimTB.Margin = new System.Windows.Forms.Padding(4);
            this.isimTB.Name = "isimTB";
            this.isimTB.Size = new System.Drawing.Size(179, 22);
            this.isimTB.TabIndex = 12;
            this.isimTB.TextChanged += new System.EventHandler(this.KullaniciAdiGiris);
            // 
            // EPostaTB
            // 
            this.EPostaTB.Location = new System.Drawing.Point(245, 366);
            this.EPostaTB.Margin = new System.Windows.Forms.Padding(4);
            this.EPostaTB.Name = "EPostaTB";
            this.EPostaTB.Size = new System.Drawing.Size(179, 22);
            this.EPostaTB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-Posta        :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı  :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.MakineResimPB);
            this.panel2.Controls.Add(this.Secbtn);
            this.panel2.Controls.Add(this.KullaniciResim);
            this.panel2.Controls.Add(this.isimTB);
            this.panel2.Controls.Add(this.EPostaTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(615, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 413);
            this.panel2.TabIndex = 10;
            // 
            // Personel_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.PersonelListesiTablo);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.panel2);
            this.Name = "Personel_Listesi";
            this.Size = new System.Drawing.Size(1172, 777);
            this.Load += new System.EventHandler(this.Personel_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListesiTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciResim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.DataGridView PersonelListesiTablo;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar MakineResimPB;
        private System.Windows.Forms.Button Secbtn;
        private System.Windows.Forms.PictureBox KullaniciResim;
        private System.Windows.Forms.TextBox isimTB;
        private System.Windows.Forms.TextBox EPostaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
