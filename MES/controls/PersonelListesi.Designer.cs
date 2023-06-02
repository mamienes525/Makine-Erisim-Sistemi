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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Listesi));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MakineResimPB = new System.Windows.Forms.ProgressBar();
            this.Secbtn = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.MakineListesiTablo = new System.Windows.Forms.DataGridView();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.MakineResim = new System.Windows.Forms.PictureBox();
            this.isimTB = new System.Windows.Forms.TextBox();
            this.EPostaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gor = new System.Windows.Forms.Label();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakineListesiTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakineResim)).BeginInit();
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
            // 
            // Silbtn
            // 
            this.Silbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Silbtn.Location = new System.Drawing.Point(888, 480);
            this.Silbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(221, 48);
            this.Silbtn.TabIndex = 7;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = true;
            // 
            // MakineListesiTablo
            // 
            this.MakineListesiTablo.AllowUserToAddRows = false;
            this.MakineListesiTablo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            this.MakineListesiTablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.MakineListesiTablo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakineListesiTablo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MakineListesiTablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MakineListesiTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MakineListesiTablo.DefaultCellStyle = dataGridViewCellStyle8;
            this.MakineListesiTablo.Location = new System.Drawing.Point(0, 0);
            this.MakineListesiTablo.Margin = new System.Windows.Forms.Padding(4);
            this.MakineListesiTablo.Name = "MakineListesiTablo";
            this.MakineListesiTablo.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MakineListesiTablo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MakineListesiTablo.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.MakineListesiTablo.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.MakineListesiTablo.Size = new System.Drawing.Size(607, 777);
            this.MakineListesiTablo.TabIndex = 8;
            // 
            // Eklebtn
            // 
            this.Eklebtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eklebtn.Location = new System.Drawing.Point(649, 480);
            this.Eklebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(221, 48);
            this.Eklebtn.TabIndex = 6;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // MakineResim
            // 
            this.MakineResim.Image = ((System.Drawing.Image)(resources.GetObject("MakineResim.Image")));
            this.MakineResim.Location = new System.Drawing.Point(111, 27);
            this.MakineResim.Margin = new System.Windows.Forms.Padding(4);
            this.MakineResim.Name = "MakineResim";
            this.MakineResim.Size = new System.Drawing.Size(307, 266);
            this.MakineResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MakineResim.TabIndex = 14;
            this.MakineResim.TabStop = false;
            // 
            // isimTB
            // 
            this.isimTB.Location = new System.Drawing.Point(243, 325);
            this.isimTB.Margin = new System.Windows.Forms.Padding(4);
            this.isimTB.Name = "isimTB";
            this.isimTB.Size = new System.Drawing.Size(179, 22);
            this.isimTB.TabIndex = 12;
            this.isimTB.Text = " ";
            // 
            // EPostaTB
            // 
            this.EPostaTB.Location = new System.Drawing.Point(245, 366);
            this.EPostaTB.Margin = new System.Windows.Forms.Padding(4);
            this.EPostaTB.Name = "EPostaTB";
            this.EPostaTB.Size = new System.Drawing.Size(179, 22);
            this.EPostaTB.TabIndex = 11;
            this.EPostaTB.Text = " ";
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
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "İsim             :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gor);
            this.panel2.Controls.Add(this.MakineResimPB);
            this.panel2.Controls.Add(this.Secbtn);
            this.panel2.Controls.Add(this.MakineResim);
            this.panel2.Controls.Add(this.SifreTB);
            this.panel2.Controls.Add(this.isimTB);
            this.panel2.Controls.Add(this.EPostaTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(615, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 458);
            this.panel2.TabIndex = 10;
            // 
            // gor
            // 
            this.gor.AutoSize = true;
            this.gor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gor.Location = new System.Drawing.Point(398, 402);
            this.gor.Name = "gor";
            this.gor.Size = new System.Drawing.Size(39, 29);
            this.gor.TabIndex = 18;
            this.gor.Text = "👀";
            this.gor.MouseLeave += new System.EventHandler(this.SifreKapa);
            this.gor.MouseHover += new System.EventHandler(this.SifreGor);
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(247, 409);
            this.SifreTB.Margin = new System.Windows.Forms.Padding(4);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.PasswordChar = '*';
            this.SifreTB.Size = new System.Drawing.Size(153, 22);
            this.SifreTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre             :";
            // 
            // Personel_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.MakineListesiTablo);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.panel2);
            this.Name = "Personel_Listesi";
            this.Size = new System.Drawing.Size(1172, 777);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakineListesiTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakineResim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.DataGridView MakineListesiTablo;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar MakineResimPB;
        private System.Windows.Forms.Button Secbtn;
        private System.Windows.Forms.PictureBox MakineResim;
        private System.Windows.Forms.TextBox isimTB;
        private System.Windows.Forms.TextBox EPostaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gor;
    }
}
