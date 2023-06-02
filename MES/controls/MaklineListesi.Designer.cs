namespace MES.controls
{
    partial class MakineListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakineListesi));
            this.Silbtn = new System.Windows.Forms.Button();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.MakineListesiTablo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MakineResimPB = new System.Windows.Forms.ProgressBar();
            this.Secbtn = new System.Windows.Forms.Button();
            this.MakineDurumTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MakineResim = new System.Windows.Forms.PictureBox();
            this.MakineDepTB = new System.Windows.Forms.TextBox();
            this.makineSeriNoTB = new System.Windows.Forms.TextBox();
            this.makineAdiTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MakineListesiTablo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MakineResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Silbtn
            // 
            this.Silbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Silbtn.Location = new System.Drawing.Point(888, 512);
            this.Silbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(221, 48);
            this.Silbtn.TabIndex = 4;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Eklebtn
            // 
            this.Eklebtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eklebtn.Location = new System.Drawing.Point(649, 512);
            this.Eklebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(221, 48);
            this.Eklebtn.TabIndex = 3;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // MakineListesiTablo
            // 
            this.MakineListesiTablo.AllowUserToAddRows = false;
            this.MakineListesiTablo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            this.MakineListesiTablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MakineListesiTablo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MakineListesiTablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MakineListesiTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MakineListesiTablo.DefaultCellStyle = dataGridViewCellStyle3;
            this.MakineListesiTablo.Dock = System.Windows.Forms.DockStyle.Left;
            this.MakineListesiTablo.Location = new System.Drawing.Point(0, 0);
            this.MakineListesiTablo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MakineListesiTablo.Name = "MakineListesiTablo";
            this.MakineListesiTablo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MakineListesiTablo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MakineListesiTablo.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.MakineListesiTablo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.MakineListesiTablo.Size = new System.Drawing.Size(607, 777);
            this.MakineListesiTablo.TabIndex = 4;
            this.MakineListesiTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MakinaSecili);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.MakineResimPB);
            this.panel2.Controls.Add(this.Secbtn);
            this.panel2.Controls.Add(this.MakineDurumTB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MakineResim);
            this.panel2.Controls.Add(this.MakineDepTB);
            this.panel2.Controls.Add(this.makineSeriNoTB);
            this.panel2.Controls.Add(this.makineAdiTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(615, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 485);
            this.panel2.TabIndex = 5;
            // 
            // MakineResimPB
            // 
            this.MakineResimPB.Location = new System.Drawing.Point(111, 263);
            this.MakineResimPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Secbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Secbtn.Name = "Secbtn";
            this.Secbtn.Size = new System.Drawing.Size(52, 30);
            this.Secbtn.TabIndex = 6;
            this.Secbtn.Text = "SEÇ";
            this.Secbtn.UseVisualStyleBackColor = true;
            this.Secbtn.Click += new System.EventHandler(this.Secbtn_Click);
            // 
            // MakineDurumTB
            // 
            this.MakineDurumTB.Location = new System.Drawing.Point(273, 448);
            this.MakineDurumTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MakineDurumTB.Name = "MakineDurumTB";
            this.MakineDurumTB.Size = new System.Drawing.Size(179, 22);
            this.MakineDurumTB.TabIndex = 16;
            this.MakineDurumTB.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Makine Durumu         :";
            // 
            // MakineResim
            // 
            this.MakineResim.Image = ((System.Drawing.Image)(resources.GetObject("MakineResim.Image")));
            this.MakineResim.Location = new System.Drawing.Point(111, 27);
            this.MakineResim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MakineResim.Name = "MakineResim";
            this.MakineResim.Size = new System.Drawing.Size(307, 266);
            this.MakineResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MakineResim.TabIndex = 14;
            this.MakineResim.TabStop = false;
            // 
            // MakineDepTB
            // 
            this.MakineDepTB.Location = new System.Drawing.Point(273, 405);
            this.MakineDepTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MakineDepTB.Name = "MakineDepTB";
            this.MakineDepTB.Size = new System.Drawing.Size(179, 22);
            this.MakineDepTB.TabIndex = 13;
            this.MakineDepTB.Text = " ";
            this.MakineDepTB.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // makineSeriNoTB
            // 
            this.makineSeriNoTB.Location = new System.Drawing.Point(273, 321);
            this.makineSeriNoTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makineSeriNoTB.Name = "makineSeriNoTB";
            this.makineSeriNoTB.Size = new System.Drawing.Size(179, 22);
            this.makineSeriNoTB.TabIndex = 12;
            this.makineSeriNoTB.Text = " ";
            this.makineSeriNoTB.Click += new System.EventHandler(this.textBox2_Click);
            this.makineSeriNoTB.TextChanged += new System.EventHandler(this.MakineSeiNoGris);
            // 
            // makineAdiTB
            // 
            this.makineAdiTB.Location = new System.Drawing.Point(273, 362);
            this.makineAdiTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makineAdiTB.Name = "makineAdiTB";
            this.makineAdiTB.Size = new System.Drawing.Size(179, 22);
            this.makineAdiTB.TabIndex = 11;
            this.makineAdiTB.Text = " ";
            this.makineAdiTB.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Makine Departmanı  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Makine Adı                :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Makine Seri No         :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MakineListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.MakineListesiTablo);
            this.Controls.Add(this.Eklebtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MakineListesi";
            this.Size = new System.Drawing.Size(1172, 777);
            this.Load += new System.EventHandler(this.MakineEkleCikar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MakineListesiTablo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MakineResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.DataGridView MakineListesiTablo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox MakineDepTB;
        private System.Windows.Forms.TextBox makineSeriNoTB;
        private System.Windows.Forms.TextBox makineAdiTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MakineDurumTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox MakineResim;
        private System.Windows.Forms.Button Secbtn;
        private System.Windows.Forms.ProgressBar MakineResimPB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
