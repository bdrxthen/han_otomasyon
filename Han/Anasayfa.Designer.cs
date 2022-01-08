namespace Han
{
    partial class Anasayfa
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
            this.Cikis = new System.Windows.Forms.Button();
            this.VeriDepo = new System.Windows.Forms.Button();
            this.Kullanici = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(472, 324);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(100, 25);
            this.Cikis.TabIndex = 5;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // VeriDepo
            // 
            this.VeriDepo.Location = new System.Drawing.Point(342, 64);
            this.VeriDepo.Name = "VeriDepo";
            this.VeriDepo.Size = new System.Drawing.Size(150, 75);
            this.VeriDepo.TabIndex = 3;
            this.VeriDepo.Text = "Veri Deposu";
            this.VeriDepo.UseVisualStyleBackColor = true;
            this.VeriDepo.Click += new System.EventHandler(this.VeriDepo_Click);
            // 
            // Kullanici
            // 
            this.Kullanici.Location = new System.Drawing.Point(342, 184);
            this.Kullanici.Name = "Kullanici";
            this.Kullanici.Size = new System.Drawing.Size(150, 75);
            this.Kullanici.TabIndex = 4;
            this.Kullanici.Text = "Kullanıcı Bilgileri";
            this.Kullanici.UseVisualStyleBackColor = true;
            this.Kullanici.Click += new System.EventHandler(this.Kullanici_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(92, 184);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(150, 75);
            this.Guncelle.TabIndex = 2;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(92, 64);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(150, 75);
            this.Hesapla.TabIndex = 1;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.VeriDepo);
            this.Controls.Add(this.Kullanici);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Hesapla);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.Button VeriDepo;
        private System.Windows.Forms.Button Kullanici;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Hesapla;
    }
}