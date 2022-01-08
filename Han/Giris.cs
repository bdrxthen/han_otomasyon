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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        //Kullanıcı adı ve şifresini girerek ana sayfaya gitmesini sağlar
        private void KGiris_Click(object sender, EventArgs e)
        {
            if (KAdi.Text == "bdrx")
            {
                if (KSifre.Text == "123")
                {
                    Anasayfa frm = new Anasayfa();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı sifre Girdiniz!!");
                }
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı girdiniz!");
            }
        }

        //Uygulamadan çıkış yapmayı sağlar
        private void KCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
