namespace MES
{
    partial class makine_listesi_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kutu = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // kutu
            // 
            this.kutu.Location = new System.Drawing.Point(1, 1);
            this.kutu.Name = "kutu";
            this.kutu.Size = new System.Drawing.Size(1368, 750);
            this.kutu.TabIndex = 0;
            this.kutu.TabStop = false;
            this.kutu.Text = "groupBox1";
            // 
            // makine_listesi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.kutu);
            this.Name = "makine_listesi_form";
            this.Text = "makine_listesi_form";
            this.Load += new System.EventHandler(this.makine_listesi_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox kutu;
    }
}