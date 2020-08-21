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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=IBRAHIMOZ\\IBRAHIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();  
        // "" içinde yazılan kodun veritabanı üzerinde çalışıp işlemler yapmasını sağlıyoruz.
        // daset'i kayıtları geçici olarak tutmak için tanımladık.
        
        private void KayıtGoster()  // güncelleme sayfası için de kulanıcağımız için ve kod yığınından kurtulmak için metod haline getiriyoruz.
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Musteri", baglanti);
            // müşteri tablosundaki bütün kayıtların gösterilmesini sağlar.
            adtr.Fill(daset, "Musteri");
            dataGridView1.DataSource = daset.Tables["Musteri"]; 
            // müşteri tablosundaki bilgilerin listlenmesini sağlıyoruz(datagridview ekranında)
            baglanti.Close();
        }
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            KayıtGoster(); // metodumuzu çağırdık
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            // datagridview ekranında kayıt satırına çift tıklandığı zaman kayıtlar textboxlarda gösteriliyor.
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc",baglanti);

            komut.Parameters.AddWithValue("@tc", txtTc.Text);                      // buralarda belirtilen
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);            //parametrelere
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);            // girilen değerler göre
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);                // sql üzerinde
            komut.Parameters.AddWithValue("@email", txtEmail.Text);                // işlem yapılıyor
            komut.ExecuteNonQuery();                                               //(güncelleme işlemi)
            baglanti.Close();
            daset.Tables["Musteri"].Clear(); // geçici kayıt bölümünü temizliyoruz ki tekrar işlem gerçekleştiğinde eskileri görmeyelim.
            KayıtGoster();                   // daha önce oluşturduğumuz metodu çağırdık
            MessageBox.Show("Müşteri Kaydı Güncellendi");  // işlem sonrası mesaj gösteriliyor.
            foreach (Control item in this.Controls)
            {                                                // işlem sonrası
                if (item is TextBox)                         // textbox ların
                {                                            // temizlenmesini
                    item.Text = "";                          // sağlıyoruz
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();  // sql bağlantısını açıyoruz.
            SqlCommand komut = new SqlCommand("delete from Musteri where tc='"+dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();                       //seçilen tcno ya göre müşteri silme işlemi yapılıyor
            baglanti.Close();
            daset.Tables["Musteri"].Clear();              // geçici kayıt bölümü temizleniyor.
            KayıtGoster();                                 // metodumuzu çağırdık.
            MessageBox.Show("Kayıt Silindi");              // işlem sonrası mesaj gösteriliyor.
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Musteri where tc like'%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(tablo);                                  // tcara textbox ına girilen herhangi bir değer için tabloda arama yapılıyor(tcno'ya göre)
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
