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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   // sql bağlantısının bulunduğu kütüphane
namespace projeorn1
{
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=IBRAHIMOZ\\IBRAHIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        // veritabanı bağlantısını ekliyoruz.
        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();     // sql bağlantısını açar
            SqlCommand komut = new SqlCommand("insert into Musteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)", baglanti);
           // "" içinde yazılan kodun veritabanı üzerinde çalışıp işlemler yapmasını sağlıyoruz.
            komut.Parameters.AddWithValue("@tc", txtTc.Text);                  //         buralarda belirtilen 
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);        //         parametre değerlerine
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);        //        girilen değerlere göre 
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);            //         sql üzerinde işlem 
            komut.Parameters.AddWithValue("@email", txtEmail.Text);            //             yapılıyor.
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Eklendi");    // veritabanına eklenen kayıt sonrası bu mesajı görüyoruz.
            foreach(Control item in this.Controls)
            {                                            // bu foreach döngüsüyle
                if(item is TextBox)                      // işlem yapıldıktan sonra 
                {                                        // daha doğrusu ekrana mesaj verildikten  
                    item.Text = "";                      //textbox ları teker teker dolaşıp
                }                                        // içlerini boş yapıyoruz
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
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
    }
}
