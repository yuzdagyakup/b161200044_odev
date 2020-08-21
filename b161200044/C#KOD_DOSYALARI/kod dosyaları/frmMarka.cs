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
using System.Data.SqlClient;

namespace projeorn1
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=IBRAHIMOZ\\IBRAHIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || comboBox1.Text=="" || textBox1.Text == "")
                {                                          
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();                                         // marka tablosuna eklenen bilgiler veritabanına kaydediliyor.
                baglanti.Close();                                               // marka tablosuna kayıt işlemleri yapıldı.
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Geçersiz Giriş", "UYARI");
            }
            
            textBox1.Text = "";
            comboBox1.Text = "";   // ekleme işlemi sonrası text leri temizliyoruz.
           
        }
        private void KategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"]).ToString();         //form açıldığında kategoriler combobox a geliyor.
            }                                                             // burada bunun metodunu oluşturuyoruz.
            baglanti.Close();
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            KategoriGetir();    
        }

        
    }
}
