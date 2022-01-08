using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Han
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        //Hesaplama sayfasına gider ve anasayfayı kapatır
        private void Hesapla_Click(object sender, EventArgs e)
        {
            Hesapla hsp = new Hesapla();
            hsp.Show();
            this.Hide();
        }

        //Güncelleme sayfasına gider ve anasayfayı kapatır
        private void Guncelle_Click(object sender, EventArgs e)
        {

            Guncelle gnc = new Guncelle();
            gnc.Show();
            this.Hide();
        }

        //Veri deposu sayfasına gider ve anasayfayı kapatır
        private void VeriDepo_Click(object sender, EventArgs e)
        {

            VeriDepo depo = new VeriDepo();
            depo.Show();
            this.Hide();
        }

        //Kullanıcı bilgileri sayfasına gider ve anasayfayı kapatır
        private void Kullanici_Click(object sender, EventArgs e)
        {

            Kullanici klnc = new Kullanici();
            klnc.Show();
            this.Hide();
        }

        //Uygulamadan çıkış yapmayı sağlar
        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
