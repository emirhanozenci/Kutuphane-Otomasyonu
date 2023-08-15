using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            uyeekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapEkle kitapekle = new KitapEkle();
            kitapekle.ShowDialog();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListeleme uyeliste = new UyeListeleme();
            uyeliste.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListele kitapListele = new KitapListele();
            kitapListele.ShowDialog();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVer emanetkitapver = new EmanetKitapVer();
            emanetkitapver.ShowDialog();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListele listele = new EmanetKitapListele();
            listele.ShowDialog();
        }

        private void btnEmanetIade_Click(object sender, EventArgs e)
        {
            EmanetKitapIade iade = new EmanetKitapIade();   
            iade.ShowDialog();
        }

        private void btnSıralama_Click(object sender, EventArgs e)
        {
            Sıralama sırala = new Sıralama();
            sırala.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik();
            grafik.ShowDialog();
        }
    }
}
