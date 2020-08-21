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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=IBRAHIMOZ\\IBRAHIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text==read["barkodno"].ToString() || txtBarkodNo.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void kategoriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())                                        
            {
                comboKategori.Items.Add(read["kategori"]).ToString();
            }
            baglanti.Close();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            kategoriGetir();             //  Form açıldığında kategoriler combobox a geliyor. 
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='"+comboKategori.SelectedItem+"' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"]).ToString();              // kategori seçildiğinde o kategoriye bağlı markaların listelenmesi işlemi yapıldı.
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);                      // texboxlara girilen değerler
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);                             // veritabanı ile eşleştirilip
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);                            // sütünlara girilen değerler
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));                   // kaydediliyor
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyat.Text));            
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyat.Text));         
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());                     
                komut.ExecuteNonQuery();                                                                    
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Geçersiz Giriş", "UYARI");
            }
           
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {                                                            // işlem sonrası 
                    item.Text = "";                                          // text ler ve combo lar
                }                                                            // temizleniyor.   
                if (item is ComboBox)                                          
                {                                                             
                    item.Text = "";
                }
            }
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text=="")
            {
                lblMiktari.Text = "";                             // label ide barkod no ile beraber boşaltıyoruz.
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";       // barkodno text i boş olduğunda tüm textboxları boş yapıyoruz
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select *from urun where barkodno like '"+BarkodNotxt.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Kategoritxt.Text = read["kategori"].ToString();                       //barkodno girildiğinde
                Markatxt.Text = read["marka"].ToString();                              // diğer bilgilerin
                UrunAditxt.Text = read["urunadi"].ToString();                            // textlerde verilmesini
                lblMiktari.Text = read["miktari"].ToString();                             // sağlıyoruz
                AlisFiyattxt.Text = read["alisfiyati"].ToString();                         
                SatisFiyattxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(Miktartxt.Text)+"' where barkodno='"+BarkodNotxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı");
        }
    }
}
