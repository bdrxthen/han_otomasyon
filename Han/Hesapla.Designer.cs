namespace Han
{
    partial class Hesapla
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.Fiyat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirmaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AktarmaTuru = new System.Windows.Forms.ComboBox();
            this.KesimUzunluk = new System.Windows.Forms.ComboBox();
            this.KumasUzunluk = new System.Windows.Forms.ComboBox();
            this.KumasAdet = new System.Windows.Forms.ComboBox();
            this.Hesap = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Geri = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 170);
            this.dataGridView1.TabIndex = 43;
            // 
            // Tarih
            // 
            this.Tarih.Enabled = false;
            this.Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tarih.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Tarih.Location = new System.Drawing.Point(482, 12);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(90, 20);
            this.Tarih.TabIndex = 46;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Location = new System.Drawing.Point(135, 152);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(13, 13);
            this.Fiyat.TabIndex = 45;
            this.Fiyat.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fiyat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Aktarma Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kesim Uzunluğu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kumaş Uzunluğu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kumaş Adeti :";
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.Location = new System.Drawing.Point(135, 12);
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.Size = new System.Drawing.Size(138, 20);
            this.FirmaAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Firma Adı :";
            // 
            // AktarmaTuru
            // 
            this.AktarmaTuru.FormattingEnabled = true;
            this.AktarmaTuru.Items.AddRange(new object[] {
            "Aktarmalı",
            "Aktarmasız"});
            this.AktarmaTuru.Location = new System.Drawing.Point(135, 118);
            this.AktarmaTuru.Name = "AktarmaTuru";
            this.AktarmaTuru.Size = new System.Drawing.Size(138, 21);
            this.AktarmaTuru.TabIndex = 5;
            // 
            // KesimUzunluk
            // 
            this.KesimUzunluk.FormattingEnabled = true;
            this.KesimUzunluk.Items.AddRange(new object[] {
            "1 - 1.5 cm",
            "2 - 3 cm",
            "4 - 10 cm",
            "10 - 15 cm",
            "20 - 80 cm"});
            this.KesimUzunluk.Location = new System.Drawing.Point(135, 91);
            this.KesimUzunluk.Name = "KesimUzunluk";
            this.KesimUzunluk.Size = new System.Drawing.Size(138, 21);
            this.KesimUzunluk.TabIndex = 4;
            // 
            // KumasUzunluk
            // 
            this.KumasUzunluk.FormattingEnabled = true;
            this.KumasUzunluk.Items.AddRange(new object[] {
            "100gr 200m x 160cm",
            "30gr 1000m x 160cm",
            "70 - 80 gr Tela"});
            this.KumasUzunluk.Location = new System.Drawing.Point(135, 64);
            this.KumasUzunluk.Name = "KumasUzunluk";
            this.KumasUzunluk.Size = new System.Drawing.Size(138, 21);
            this.KumasUzunluk.TabIndex = 3;
            // 
            // KumasAdet
            // 
            this.KumasAdet.FormattingEnabled = true;
            this.KumasAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.KumasAdet.Location = new System.Drawing.Point(135, 37);
            this.KumasAdet.Name = "KumasAdet";
            this.KumasAdet.Size = new System.Drawing.Size(138, 21);
            this.KumasAdet.TabIndex = 2;
            // 
            // Hesap
            // 
            this.Hesap.Location = new System.Drawing.Point(328, 85);
            this.Hesap.Name = "Hesap";
            this.Hesap.Size = new System.Drawing.Size(100, 25);
            this.Hesap.TabIndex = 6;
            this.Hesap.Text = "Hesapla";
            this.Hesap.UseVisualStyleBackColor = true;
            this.Hesap.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(328, 9);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(100, 25);
            this.Kaydet.TabIndex = 7;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(472, 51);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(100, 25);
            this.Geri.TabIndex = 8;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(472, 112);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(100, 25);
            this.Cikis.TabIndex = 9;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Hesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirmaAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AktarmaTuru);
            this.Controls.Add(this.KesimUzunluk);
            this.Controls.Add(this.KumasUzunluk);
            this.Controls.Add(this.KumasAdet);
            this.Controls.Add(this.Hesap);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hesapla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirmaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AktarmaTuru;
        private System.Windows.Forms.ComboBox KesimUzunluk;
        private System.Windows.Forms.ComboBox KumasUzunluk;
        private System.Windows.Forms.ComboBox KumasAdet;
        private System.Windows.Forms.Button Hesap;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button Cikis;
    }
}