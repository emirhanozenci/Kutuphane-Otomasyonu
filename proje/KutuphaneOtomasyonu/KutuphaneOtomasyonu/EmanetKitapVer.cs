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
    public partial class EmanetKitapVer : Form
    {
        public EmanetKitapVer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-AM7B9OB;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void grpKitapBilgi_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitapsayısı()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayısı) from sepet",baglanti);
            lblKitapSayı.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void EmanetKitapVer_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayısı();
        }
         
        private void sepetlistele()
        {
            baglanti.Open();    
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet",baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitapadı,yazarı,yayınevi,sayfasayısı,kitapsayısı,teslimtarihi,iadetarihi) values(@barkodno,@kitapadı,@yazarı,@yayınevi,@sayfasayısı,@kitapsayısı,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadı", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@yazarı", txtYazarı.Text);
            komut.Parameters.AddWithValue("@yayınevi", txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@sayfasayısı", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@kitapsayısı", int.Parse(txtKitapSayısı.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) sepete eklendi", "Ekleme İşlemi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblKitapSayı.Text = "";
            kitapsayısı();
            foreach (Control item in grpKitapBilgi.Controls)
            {
                if (item is TextBox)
                {
                    if (item!=txtKitapSayısı)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where tc like '"+txtTcAra.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString() ;
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close() ;

            baglanti.Open() ;
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayısı) from emanetkitaplar where tc='"+txtTcAra.Text+"'",baglanti);
            lblKayıtlıKitapSayı.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTcAra.Text=="")
            {
                foreach (Control item in grpUyeBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        
                    }
                   
                }
                lblKayıtlıKitapSayı.Text = "";
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open() ;
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like '"+txtBarkodNo.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()){
                txtKitapAdı.Text = read["kitapadı"].ToString();
                txtYazarı.Text = read["yazarı"].ToString();
                txtYayınEvi.Text = read["yayınevi"].ToString();
                txtSayfaSayısı.Text = read["sayfasayısı"].ToString();
            }
            baglanti.Close();
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayısı)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi yapıldı", "Silme İşlemi");
                daset.Tables["sepet"].Clear();
                sepetlistele();
                lblKitapSayı.Text = "";
                kitapsayısı();
            }
           
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayı.Text!="")
            {
                if (lblKayıtlıKitapSayı.Text=="" && int.Parse(lblKitapSayı.Text)<=3 || lblKayıtlıKitapSayı.Text!="" && int.Parse(lblKayıtlıKitapSayı.Text)+int.Parse(lblKitapSayı.Text)<3)
                {
                    if (txtTcAra.Text!="" && txtAdSoyad.Text!="" && txtYas.Text!="" && txtTelefon.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into emanetkitaplar(tc,adsoyad,yas,telefon,barkodno,kitapadı,yazarı,yayınevi,sayfasayısı,kitapsayısı,teslimtarihi,iadetarihi) values(@tc,@adsoyad,@yas,@telefon,@barkodno,@kitapadı,@yazarı,@yayınevi,@sayfasayısı,@kitapsayısı,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc", txtTcAra.Text);
                            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@yas", txtYas.Text);
                            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                            komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapadı", dataGridView1.Rows[i].Cells["kitapadı"].Value.ToString());
                            komut.Parameters.AddWithValue("yazarı", dataGridView1.Rows[i].Cells["yazarı"].Value.ToString());
                            komut.Parameters.AddWithValue("yayınevi", dataGridView1.Rows[i].Cells["yayınevi"].Value.ToString());
                            komut.Parameters.AddWithValue("sayfasayısı", dataGridView1.Rows[i].Cells["sayfasayısı"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapsayısı", int.Parse(dataGridView1.Rows[i].Cells["kitapsayısı"].Value.ToString()));
                            komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 =new SqlCommand("update uye set okukitapsayısı=okukitapsayısı+'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayısı"].Value.ToString())+"' where tc='"+txtTcAra.Text+"'",baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update kitap set stoksayısı=stoksayısı-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayısı"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet",baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close() ;
                        MessageBox.Show("Kitap(lar) emanet edildi");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txtTcAra.Text = "";

                        lblKitapSayı.Text = "";
                        kitapsayısı();
                        lblKayıtlıKitapSayı.Text = "";
                        //komut satırları
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gerekir!!!", "Uyarı");
                    }

                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz!!!", "Uyarı");
                }




            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir!!!","Uyarı");
            }
            
            
            
            
          
        }

        private void grpUyeBilgi_Enter(object sender, EventArgs e)
        {

        }
    }
}
