/**                           SAKARYA ÜNİVERSİTESİ       
 *                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ  
 *                     BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ  
 *                        NESNEYE DAYALI PROGRAMLAMA DERSİ   
 *                            2019-2020 BAHAR DÖNEMİ     
 *                            
 *                       PROJE NUMARASI.........: 01 
 *                       ÖĞRENCİ ADI............: İbrahim ÖZTÜRK
 *                       ÖĞRENCİ NUMARASI.......: B161200005
 *                       DERSİN ALINDIĞI GRUP...: A 
 *                                                                                                         ****/
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

namespace projeorn1
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=IBRAHIMOZ\\IBRAHIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        //veritabanı bağlantısı eklendi.
        DataSet daset = new DataSet();
        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti); // form yüklendiğinde sepetteki bilgileri getirir
            adtr.Fill(daset, "sepet");   // geçici tabloya sepet tablosundaki bilgileri aktarır
            dataGridView1.DataSource = daset.Tables["sepet"]; // satışları listeleme sayfasında
            dataGridView1.Columns[0].Visible = false;     //tablodaki ilk 3 
            dataGridView1.Columns[1].Visible = false;     //parametre için
            dataGridView1.Columns[2].Visible = false;     //işlem yapılmamasını istiyoruz.

            baglanti.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle(); // müşteri ekle butonuna tıklandığında müşteri ekleme formunu açar
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();  // müşteri listele butonuna tıklandığında müşteri listeleme formu açılıyor.
            listele.ShowDialog();
             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUrunEkle ekle = new frmUrunEkle();  // urun ekle butonuna tıklandığında urun ekleme formun açar.
            ekle.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();   // kategori butonuna tıklandığında kategori ekleme formunu açar.
            kategori.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();    // marka butonuna tıklandığında marka ekleme formunu açar.
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmUrunListele listele = new frmUrunListele();  // urun listeleme butonuna tıklandığında ürün listeleme formunu açar.
            listele.ShowDialog();

        }
        private void Hesapla()
        {
            try                       //hata mesajı almamak için
            {                          // istenilen değer alımadığında 
                baglanti.Open();       // try catch ile işlem yapılmamasını istiyoruz.
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL"; // sepetteki ürünlerin fiyat toplamlarını alıyoruz ve genel toplam label ına atıyoruz.
                baglanti.Close();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text=="")
            {                                       // tc boş olduğunda adsoyad ve telefonunda boş olmasını sağlıyoruz.
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Musteri where tc like '" + txtTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {                                                          //while döngüsü ile kayıtlar her okunduğunda işlemim yapılmasını sağlıyoruz.
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();                 // girilen tc noya göre diğer bilgiler ekrana geliyor

            }
            baglanti.Close();
        }
        private void Temizle()
        {
            if (txtBarNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)       //burada miktar textbox'ı
                {                                                   // harici tüm textbox ların
                    if (item is TextBox)                            // temizlenmesini sağlayan
                    {                                                // metodu yazıyoruz.(groupbox2'nin içindeki)
                        if (item != txtMiktar)
                        {
                            item.Text = "";
                        }
                    }

                }

            }
        }
        private void txtBarNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();             // önce textbox ları temizliyoruz.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + txtBarNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUrunAd.Text = read["urunadi"].ToString();                         // barkod no girildiğinde diğer bilgilerin ekrana gelmesini sağlıyor.
                txtSatisFiyat.Text = read["satisfiyati"].ToString();                 // (ürünadi va satiş fiyatının)

            }
            baglanti.Close();
        }

        

        bool durum;
        private void BarkodKontrol()
        {                                                                            // barkodno veritabanında var ise
            durum = true;                                                            // onun üzerine ekleme yapsın 
            baglanti.Open();                                                         // yok ise yeni ekleme yapsın.
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);       // bu işlem için barkodkontrol
            SqlDataReader read = komut.ExecuteReader();                              // metodu oluşturuldu.
            while (read.Read())                                                       
            {                                                                       
                if (txtBarNo.Text==read["barkodno"].ToString())                         
                {
                    durum = false;                                    //girilen değer barkodno'ya eşitse altalta ekleme yapılmıyor 
                }                                                      // daha önce girimiş bir değer varsa üstüne ekliyor.
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);               // girilen değerler göre datagridview e ekleme yapılyor.
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtTopFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktari = miktari+'"+int.Parse(txtMiktar.Text)+ "' where barkodno='" + txtBarNo.Text + "'", baglanti);
                                                              // aynı barkodno ile tekrar işlem yapıldığında yeni işlemi eskisinin üzerine eklemesini istiyoruz.
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati=miktari*satisfiyati where barkodno='"+txtBarNo.Text+"'", baglanti);
                                                         // toplam fiyatta aynı şekilde üzerine ekleme yapıyoruz.
                komut3.ExecuteNonQuery();

                baglanti.Close();
            }
   
            txtMiktar.Text = "1";  //işlemden sonra miktar text ini de tekrar 1 e eşitliyoruz 
            daset.Tables["sepet"].Clear();   // geçici tabloyu yeniliyoruz
            SepetListele();  // forma yeni bilgileri getiriyoruz.
            Hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar)            //miktar text i harici diğer text lerin temizlenmisini sağlıyoruz.
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTopFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)                                   //  toplamfiyat text ine miktar*satisfiyatını
            {                                                   //   getiriyoruz. bu işlemi try catch in içinde apıyoruz ki
                                                                //  belirtilenden farklı türde bir değer girilirse
              ;                                                 //  hata vermesin işlem de yapmasın.
            }                                                   //

        }

        private void txtSatisFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTopFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)                // toplam fiyat miktar ile satış fiyatının çarpımı ile elde ediliyor.
            {                                // hata almamak için try catch in içine yazdık

                ;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno= '"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();                // seçilen satırın silme işlemini yapıyoruz.(hem formdan hem veritabanından)
            baglanti.Close();
    
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();        // silme işlemi sonrası tabloyu yeniliyoruz
            SepetListele();
            Hesapla();  // genel toplam label ı güncelleniyor
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();                  // tabloya eklenen tüm işlemlerin iptal edilmesini sağlıyoruz
            baglanti.Close();
           
            MessageBox.Show("Ürünler  Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();             // iptal işlemi sonrası tablo tekrar yenileniyor.
            SepetListele();
            Hesapla();  // genel toplam label ıda güncelleniyor 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatisListele listele = new frmSatisListele();    // satış listeleme butonuna basıldığında stış listeleme formunu açan bağlantı oluşturuldu.
            listele.ShowDialog();

        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)  // tablodaki satır sayısı kadar işlem yapılmasını sağlıyoruz
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString()); // kaçtane satır varsa onu barkod noya aktarıyoruz.
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());   // aynı şekilde urunadi
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString())); // miktarı
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));  //satis fiyatı
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString())); // toplam fiyat sütunlarınada aktarıyoruz.
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());  // işlem yapıldığındaki tarihi kaydediyor. 
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();                      // stok kayıtlarından düşüüyor satılan ürünler.
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();  // kayıtlar yenileniyor
            SepetListele();         // forma yeni bilgiler getiriliyor.
            Hesapla();         // genel toplam label ıda güncellendi.
        }
    }
}
