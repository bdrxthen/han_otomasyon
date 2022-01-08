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
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }

        //Tablomuzun konumunu baglanti adı altında bir köprü aracılığı ile bağladım
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Taha.mdb");
        DataSet tablo = new DataSet();
        
        //Datadaki verileri listelemek için sınıf oluşturdum
        private void Goster()
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Enes", baglanti);
            adtr.Fill(tablo, "Enes");
            Guncelle_DataGridView.DataSource = tablo.Tables["Enes"];
            baglanti.Close();
        }

        //Text ve List boxların içini sıfırlamak için sınıf oluşturdum
        private void Temizle()
        {
            Firma_Adi.Clear();
            Adet.Text = null;
            Kumas_Uzunluk.SelectedItem = null;
            Kesim_Uzunluk.SelectedItem = null;
            Aktarma_Turu.SelectedItem = null;
            Fiyat.Text = "0";
        }
        
        //Listeleme yapacağımız button burda listeleme class'ını yazdım 
        private void Listele_Click(object sender, EventArgs e)
        {
            Goster();
        }

        //Kumas uzunluğu , Kesim Uzunluğu ve Aktarma türüne göre kumas fiyatlarını belirtip adetle çarpıp toplam fiyatı hesaplatma
        private void Hesapla_Click(object sender, EventArgs e)
        {
            int adet = 0;
            if (Adet.Text != null)
            {
                adet = int.Parse(Adet.Text.ToString());
            }

            string kuzunluk = Kumas_Uzunluk.Text.ToString();
            string kesim = Kesim_Uzunluk.Text.ToString();
            string aktarma = Aktarma_Turu.Text.ToString();

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

        //Yanlış kaydedilen verileri ıd'yi sabit alıp verileri değiştirmemize olanak sağlayıp kaydediyor
        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncelleme = "UPDATE Enes SET FirmaAdi=@firmaadi,KumasAdet=@adet,KumasUzunluk=@kumasuzunluk,KesimUzunluk=@kesimuzunluk,AktarmaTuru=@aktarma,Fiyat=@fiyat,Tarih=@tarih WHERE Id=@ıd" ;
            OleDbCommand komutGuncelleme = new OleDbCommand(guncelleme, baglanti);
            komutGuncelleme.Parameters.AddWithValue("@firmaadi",Firma_Adi.Text);
            komutGuncelleme.Parameters.AddWithValue("@adet",Convert.ToInt32(Adet.Text));
            komutGuncelleme.Parameters.AddWithValue("@kumasuzunluk",Kumas_Uzunluk.Text);
            komutGuncelleme.Parameters.AddWithValue("@kesimuzunluk",Kesim_Uzunluk.Text);
            komutGuncelleme.Parameters.AddWithValue("@aktarma",Aktarma_Turu.Text );
            komutGuncelleme.Parameters.AddWithValue("@fiyat",Convert.ToInt32(Fiyat.Text));
            komutGuncelleme.Parameters.AddWithValue("@tarih", Tarih.Text);
            komutGuncelleme.Parameters.AddWithValue("@ıd",Convert.ToInt32( Guncelle_DataGridView.CurrentRow.Cells[0].Value.ToString()));
            komutGuncelleme.ExecuteNonQuery();
            baglanti.Close();
            Goster();
            Temizle();
        }

        //Veri kaydı fazla veya yanlış yapıldıysa Id sabiti temel alınarak veriyi siler
        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("DELETE from Enes where Id="+ Convert.ToInt32(Id.Text)+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Goster();
            Temizle();
        }
        
        //Anasayfaya dönmek için kullanılıyor
        private void Geri_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        //Uygulamadan çıkmaya/kapatmaya yarıyor
        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Datadan seçilen verileri text ve list boxlara işlemek/doldurmak için veri tabanından konuma göre veri işler 
        private void Guncelle_DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = Guncelle_DataGridView.CurrentRow.Cells[0].Value.ToString();
            Firma_Adi.Text = Guncelle_DataGridView.CurrentRow.Cells[1].Value.ToString();
            Adet.Text = Guncelle_DataGridView.CurrentRow.Cells[2].Value.ToString();
            Kumas_Uzunluk.Text = Guncelle_DataGridView.CurrentRow.Cells[3].Value.ToString();
            Kesim_Uzunluk.Text = Guncelle_DataGridView.CurrentRow.Cells[4].Value.ToString();
            Aktarma_Turu.Text = Guncelle_DataGridView.CurrentRow.Cells[5].Value.ToString();
            Fiyat.Text = Guncelle_DataGridView.CurrentRow.Cells[6].Value.ToString();
            Tarih.Text = Guncelle_DataGridView.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
