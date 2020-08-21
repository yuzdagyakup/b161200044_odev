/**                          SAKARYA ÜNİVERSİTESİ                               
 **                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  
 *                     BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                    
 *                        NESNEYE DAYALI PROGRAMLAMA DERSİ                     
 *                           2019-2020 BAHAR DÖNEMİ     
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
using System.Data.SqlClient;

namespace projeorn1
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=IBRAHIMOZ\\IBRAHIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        // veritababnı bağlantısı açıldı.
        bool durum;
        private void KategoriKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text==read["kategori"].ToString() || textBox1.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriKontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();                               // kategori bilgileri tablosuna kayıt ekleme işlemleri yapıldı.
                baglanti.Close();
               MessageBox.Show("Kategori Eklendi");   // işlem sonrası mesaj gösteriliyor.
            }
            else
            {
                MessageBox.Show("Geçersiz Giriş", "UYARI");         
            }
            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
