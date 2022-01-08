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
    public partial class VeriDepo : Form
    {
        public VeriDepo()
        {
            InitializeComponent();
        }

        //Tablomuzun konumunu baglanti adı altında bir köprü aracılığı ile bağladım
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Taha.mdb");
        DataSet tablo = new DataSet();

        //Datadaki verileri listelemek için sınıf oluşturdum
        private void BtnVeri_Click(object sender, EventArgs e)
        {
            Goster();
        }

        //Datadaki verileri listelemek için sınıf oluşturdum
        private void Goster()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Enes", baglanti);
            adtr.Fill(tablo, "Enes");
            Firma_Arama_DataGridView1.DataSource = tablo.Tables["Enes"];
            baglanti.Close();
        }

        //Anasayfaya dönmek için kullanılıyor
        private void Btngeri_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        //Uygulamadan çıkış yapmayı sağlar
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*Text box içine girileni veri deposundaki firma adları ile karşılaştırarak kullanıcının aradığı firmayı bulmasını ve 
        işlem geçmişini görmesini sağlıyor. */ 
        private void Firma_Arama_TextChanged(object sender, EventArgs e)
        {
            if (Firma_Arama.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Enes", baglanti);
                adtr.Fill(tablo, "Enes");
                Firma_Arama_DataGridView1.DataSource = tablo.Tables["Enes"];
            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Enes Where Firmaadi Like '%" + Firma_Arama.Text + "%' ", baglanti);
                adtr.Fill(tablo, "Enes");
                Firma_Arama_DataGridView1.DataSource = tablo.Tables["Enes"];
            }
        }
    }
}
