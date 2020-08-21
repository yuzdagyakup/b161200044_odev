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
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=IBRAHIMOZ\\IBRAHIM;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"]; 

            baglanti.Close();

        }

        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            satislistele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
