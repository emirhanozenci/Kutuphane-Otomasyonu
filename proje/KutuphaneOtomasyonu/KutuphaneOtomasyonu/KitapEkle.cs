using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AM7B9OB;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(barkodno,kitapadı,yazarı,yayınevi,sayfasayısı,turu,stoksayısı,rafno,acıklama,kayıttarihi) values(@barkodno,@kitapadı,@yazarı,@yayınevi,@sayfasayısı,@turu,@stoksayısı,@rafno,@acıklama,@kayıttarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text); 
            komut.Parameters.AddWithValue("@kitapadı",txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@yazarı",txtYazarı.Text);
            komut.Parameters.AddWithValue("yayınevi",txtYayınEvi.Text);
            komut.Parameters.AddWithValue("sayfasayısı",txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@turu",comboTuru.Text);
            komut.Parameters.AddWithValue("@stoksayısı",txtStokSayısı.Text);
            komut.Parameters.AddWithValue("@rafno",txtRafNo.Text);
            komut.Parameters.AddWithValue("@acıklama",txtAcıklama.Text);
            komut.Parameters.AddWithValue("@kayıttarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap kaydı yapıldı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                   
                        item.Text = "";
                    

                }
            }
        }

        private void txtYayınEvi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAcıklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRafNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStokSayısı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSayfaSayısı_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKitapAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYazarı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
