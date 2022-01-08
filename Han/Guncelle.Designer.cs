namespace Han
{
    partial class Guncelle
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
            this.Listele = new System.Windows.Forms.Button();
            this.Guncelle_DataGridView = new System.Windows.Forms.DataGridView();
            this.Sil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Firma_Adi = new System.Windows.Forms.TextBox();
            this.Aktarma_Turu = new System.Windows.Forms.ComboBox();
            this.Kesim_Uzunluk = new System.Windows.Forms.ComboBox();
            this.Kumas_Uzunluk = new System.Windows.Forms.ComboBox();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Geri = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.Adet1 = new System.Windows.Forms.Label();
            this.Adet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.Hesapla = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Guncelle_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(472, 8);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(100, 25);
            this.Listele.TabIndex = 1;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Guncelle_DataGridView
            // 
            this.Guncelle_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Guncelle_DataGridView.Location = new System.Drawing.Point(12, 199);
            this.Guncelle_DataGridView.Name = "Guncelle_DataGridView";
            this.Guncelle_DataGridView.Size = new System.Drawing.Size(560, 150);
            this.Guncelle_DataGridView.TabIndex = 34;
            this.Guncelle_DataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Guncelle_DataGridView_CellEnter);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(472, 101);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(100, 25);
            this.Sil.TabIndex = 4;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Aktarma Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Kesim Uzunluğu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Kumaş Uzunluğu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Firma Adı :";
            // 
            // Firma_Adi
            // 
            this.Firma_Adi.Location = new System.Drawing.Point(169, 22);
            this.Firma_Adi.Name = "Firma_Adi";
            this.Firma_Adi.Size = new System.Drawing.Size(138, 20);
            this.Firma_Adi.TabIndex = 5;
            // 
            // Aktarma_Turu
            // 
            this.Aktarma_Turu.FormattingEnabled = true;
            this.Aktarma_Turu.Items.AddRange(new object[] {
            "Aktarmalı",
            "Aktarmasız"});
            this.Aktarma_Turu.Location = new System.Drawing.Point(169, 128);
            this.Aktarma_Turu.Name = "Aktarma_Turu";
            this.Aktarma_Turu.Size = new System.Drawing.Size(138, 21);
            this.Aktarma_Turu.TabIndex = 9;
            // 
            // Kesim_Uzunluk
            // 
            this.Kesim_Uzunluk.FormattingEnabled = true;
            this.Kesim_Uzunluk.Items.AddRange(new object[] {
            "1 - 1.5 cm",
            "2 - 3 cm",
            "4 - 10 cm",
            "10 - 15 cm",
            "20 - 80 cm"});
            this.Kesim_Uzunluk.Location = new System.Drawing.Point(169, 101);
            this.Kesim_Uzunluk.Name = "Kesim_Uzunluk";
            this.Kesim_Uzunluk.Size = new System.Drawing.Size(138, 21);
            this.Kesim_Uzunluk.TabIndex = 8;
            // 
            // Kumas_Uzunluk
            // 
            this.Kumas_Uzunluk.FormattingEnabled = true;
            this.Kumas_Uzunluk.Items.AddRange(new object[] {
            "100gr 200m x 160cm",
            "30gr 1000m x 160cm",
            "70 - 80 gr Tela"});
            this.Kumas_Uzunluk.Location = new System.Drawing.Point(169, 74);
            this.Kumas_Uzunluk.Name = "Kumas_Uzunluk";
            this.Kumas_Uzunluk.Size = new System.Drawing.Size(138, 21);
            this.Kumas_Uzunluk.TabIndex = 7;
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(472, 70);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(100, 25);
            this.Güncelle.TabIndex = 3;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(472, 132);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(100, 25);
            this.Geri.TabIndex = 10;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(472, 163);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(100, 25);
            this.Cikis.TabIndex = 11;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Adet1
            // 
            this.Adet1.AutoSize = true;
            this.Adet1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adet1.Location = new System.Drawing.Point(111, 48);
            this.Adet1.Name = "Adet1";
            this.Adet1.Size = new System.Drawing.Size(52, 19);
            this.Adet1.TabIndex = 48;
            this.Adet1.Text = "Adet :";
            // 
            // Adet
            // 
            this.Adet.Location = new System.Drawing.Point(169, 48);
            this.Adet.Name = "Adet";
            this.Adet.Size = new System.Drawing.Size(138, 20);
            this.Adet.TabIndex = 6;
            this.Adet.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Fiyat :";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat.Location = new System.Drawing.Point(165, 157);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(17, 19);
            this.Fiyat.TabIndex = 51;
            this.Fiyat.Text = "0";
            // 
            // Tarih
            // 
            this.Tarih.Enabled = false;
            this.Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tarih.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Tarih.Location = new System.Drawing.Point(341, 23);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(90, 20);
            this.Tarih.TabIndex = 52;
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(472, 39);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(100, 25);
            this.Hesapla.TabIndex = 2;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Id.Location = new System.Drawing.Point(12, 9);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(24, 19);
            this.Id.TabIndex = 54;
            this.Id.Text = "Id";
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adet);
            this.Controls.Add(this.Adet1);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.Guncelle_DataGridView);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Firma_Adi);
            this.Controls.Add(this.Aktarma_Turu);
            this.Controls.Add(this.Kesim_Uzunluk);
            this.Controls.Add(this.Kumas_Uzunluk);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.Cikis);
            this.Name = "Guncelle";
            this.Text = "Guncelle";
            ((System.ComponentModel.ISupportInitialize)(this.Guncelle_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.DataGridView Guncelle_DataGridView;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Firma_Adi;
        private System.Windows.Forms.ComboBox Aktarma_Turu;
        private System.Windows.Forms.ComboBox Kesim_Uzunluk;
        private System.Windows.Forms.ComboBox Kumas_Uzunluk;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.Label Adet1;
        private System.Windows.Forms.TextBox Adet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Label Id;
    }
}