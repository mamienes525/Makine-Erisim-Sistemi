namespace MES.controls
{
    partial class MakineEkleCikar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Guncellebt = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.MakineListesiTablo = new System.Windows.Forms.DataGridView();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MakineListesiTablo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guncellebt
            // 
            this.Guncellebt.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guncellebt.Location = new System.Drawing.Point(685, 487);
            this.Guncellebt.Name = "Guncellebt";
            this.Guncellebt.Size = new System.Drawing.Size(163, 39);
            this.Guncellebt.TabIndex = 5;
            this.Guncellebt.Text = "GÜNCELLE";
            this.Guncellebt.UseVisualStyleBackColor = true;
            this.Guncellebt.Click += new System.EventHandler(this.Guncellebt_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Silbtn.Location = new System.Drawing.Point(514, 487);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(166, 39);
            this.Silbtn.TabIndex = 4;
            this.Silbtn.Text = "SİL";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Eklebtn
            // 
            this.Eklebtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eklebtn.Location = new System.Drawing.Point(344, 487);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(166, 39);
            this.Eklebtn.TabIndex = 3;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // MakineListesiTablo
            // 
            this.MakineListesiTablo.AllowUserToAddRows = false;
            this.MakineListesiTablo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent;
            this.MakineListesiTablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.MakineListesiTablo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MakineListesiTablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.MakineListesiTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MakineListesiTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriNo,
            this.Adi,
            this.Departman});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MakineListesiTablo.DefaultCellStyle = dataGridViewCellStyle13;
            this.MakineListesiTablo.Dock = System.Windows.Forms.DockStyle.Left;
            this.MakineListesiTablo.Location = new System.Drawing.Point(0, 0);
            this.MakineListesiTablo.Name = "MakineListesiTablo";
            this.MakineListesiTablo.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MakineListesiTablo.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            this.MakineListesiTablo.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.MakineListesiTablo.Size = new System.Drawing.Size(344, 631);
            this.MakineListesiTablo.TabIndex = 4;
            this.MakineListesiTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MakineListesiTablo_CellContentClick);
            // 
            // SeriNo
            // 
            this.SeriNo.Frozen = true;
            this.SeriNo.HeaderText = "Makine Seri No";
            this.SeriNo.Name = "SeriNo";
            this.SeriNo.ReadOnly = true;
            // 
            // Adi
            // 
            this.Adi.Frozen = true;
            this.Adi.HeaderText = "MakineAdi";
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            // 
            // Departman
            // 
            this.Departman.Frozen = true;
            this.Departman.HeaderText = "Bulunduğu Departman";
            this.Departman.Name = "Departman";
            this.Departman.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(384, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 185);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = " ";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = " ";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = " ";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Makine Departmanı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Makine Adı               :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Makine Seri No        :";
            // 
            // MakineEkleCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Guncellebt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.MakineListesiTablo);
            this.Controls.Add(this.Eklebtn);
            this.Name = "MakineEkleCikar";
            this.Size = new System.Drawing.Size(879, 631);
            ((System.ComponentModel.ISupportInitialize)(this.MakineListesiTablo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Guncellebt;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.DataGridView MakineListesiTablo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
    }
}
