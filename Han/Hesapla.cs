using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Han
{
    public partial class Hesapla : Form
    {
        public Hesapla()
        {
            InitializeComponent();
        }

        //Anasayfaya dönmek için kullanılıyor
        private void Geri_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        //Uygulamadan çıkış yapmayı sağlar
        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Kumas uzunluğu , Kesim Uzunluğu ve Aktarma türüne göre kumas fiyatlarını belirtip adetle çarpıp toplam fiyatı hesaplatma
        private void Hesap_Click(object sender, EventArgs e)
        {
                int adet = 0;
                if (KumasAdet.SelectedItem != null)
                {
                    adet = int.Parse(KumasAdet.SelectedItem.ToString());
                }

                string kuzunluk = KumasUzunluk.Text.ToString();
                string kesim = KesimUzunluk.Text.ToString();
                string aktarma = AktarmaTuru.Text.ToString();

                if (kuzunluk == "100gr 200m x 160cm" && kesim == "1 - 1.5 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 50 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "2 - 3 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 30 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "4 - 10 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 25 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "10 - 15 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 20 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "20 - 80 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 15 * adet;
                    Fiyat.Text = toplam.ToString();
                }

                //

                if (kuzunluk == "100gr 200m x 160cm" && kesim == "1 - 1.5 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 30 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "2 - 3 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 20 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "4 - 10 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 15 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "10 - 15 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 12 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "100gr 200m x 160cm" && kesim == "20 - 80 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 10 * adet;
                    Fiyat.Text = toplam.ToString();
                }

                //

                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "1 - 1.5 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 35 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "2 - 3 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 25 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "4 - 10 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 20 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "10 - 15 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 15 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "20 - 80 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 10 * adet;
                    Fiyat.Text = toplam.ToString();
                }

                //

                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "1 - 1.5 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 60 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "2 - 3 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 40 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "4 - 10 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 30 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "10 - 15 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 25 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "30gr 1000m x 160cm" && kesim == "20 - 80 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 20 * adet;
                    Fiyat.Text = toplam.ToString();
                }

                //

                if (kuzunluk == "70 - 80 gr Tela" && kesim == "1 - 1.5 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 50 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "2 - 3 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 30 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "4 - 10 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 25 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "10 - 15 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 20 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "20 - 80 cm" && aktarma == "Aktarmalı")
                {
                    int toplam = 15 * adet;
                    Fiyat.Text = toplam.ToString();
                }

                //

                if (kuzunluk == "70 - 80 gr Tela" && kesim == "1 - 1.5 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 30 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "2 - 3 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 20 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "4 - 10 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 15 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "10 - 15 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 12 * adet;
                    Fiyat.Text = toplam.ToString();
                }
                if (kuzunluk == "70 - 80 gr Tela" && kesim == "20 - 80 cm" && aktarma == "Aktarmasız")
                {
                    int toplam = 10 * adet;
                    Fiyat.Text = toplam.ToString();
                }
        }

        //Tablomuzun konumunu baglanti adı altında bir köprü aracılığı ile bağladım
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Taha.mdb");
        DataSet tablo = new DataSet();

        //Girilen verileri dataya kaydetmek için verileri isimlerine uygun text veya list boxları eşleştiriyoruz key value olarak
        private void Kaydet_Click(object sender, EventArgs e)
        {

            if (FirmaAdi.Text==null && KumasAdet.Text == null && KumasUzunluk.Text == null && KesimUzunluk.Text == null && AktarmaTuru.Text == null && Fiyat.Text == "0")
            {
                MessageBox.Show("Boş alanları doldurunuz!!!");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Enes (FirmaAdi,KumasAdet," +
                    "KumasUzunluk,KesimUzunluk,AktarmaTuru,Fiyat,Tarih)values('" + FirmaAdi.Text + "'" +
                    ",'" + KumasAdet.Text + "','" + KumasUzunluk.Text + "','" + KesimUzunluk.Text + "'" +
                    ",'" + AktarmaTuru.Text + "','" + Fiyat.Text + "','" + Tarih.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Goster();
                Temizle();
            }
        }

        //Datadaki verileri listelemek için sınıf oluşturdum
        private void Goster()
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Enes", baglanti);
            adtr.Fill(tablo, "Enes");
            dataGridView1.DataSource = tablo.Tables["Enes"];
            baglanti.Close();
        }

        //Text ve List boxların içini sıfırlamak için sınıf oluşturdum
        private void Temizle()
        {
            FirmaAdi.Clear();
            KumasAdet.SelectedItem = null;
            KumasUzunluk.SelectedItem = null;
            KesimUzunluk.SelectedItem = null;
            AktarmaTuru.SelectedItem = null;
            Fiyat.Text = "0";
        }

    }
}