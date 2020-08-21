namespace projeorn1
{
    partial class frmSatis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTopFiyat = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtBarNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnSatisListele = new System.Windows.Forms.Button();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Location = new System.Drawing.Point(33, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(96, 72);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(96, 46);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(96, 20);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTopFiyat);
            this.groupBox2.Controls.Add(this.txtSatisFiyat);
            this.groupBox2.Controls.Add(this.txtMiktar);
            this.groupBox2.Controls.Add(this.txtUrunAd);
            this.groupBox2.Controls.Add(this.txtBarNo);
            this.groupBox2.Location = new System.Drawing.Point(33, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod No";
            // 
            // txtTopFiyat
            // 
            this.txtTopFiyat.Location = new System.Drawing.Point(96, 123);
            this.txtTopFiyat.Name = "txtTopFiyat";
            this.txtTopFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtTopFiyat.TabIndex = 5;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(96, 97);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyat.TabIndex = 4;
            this.txtSatisFiyat.TextChanged += new System.EventHandler(this.txtSatisFiyat_TextChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(96, 71);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.Text = "1";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(96, 45);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAd.TabIndex = 2;
            // 
            // txtBarNo
            // 
            this.txtBarNo.Location = new System.Drawing.Point(96, 19);
            this.txtBarNo.Name = "txtBarNo";
            this.txtBarNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarNo.TabIndex = 1;
            this.txtBarNo.TextChanged += new System.EventHandler(this.txtBarNo_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(258, 425);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = " EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(775, 142);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(775, 186);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatisIptal.TabIndex = 5;
            this.btnSatisIptal.Text = "Satış İptal";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            this.btnSatisIptal.Click += new System.EventHandler(this.btnSatisIptal_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(687, 425);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(75, 23);
            this.btnSatisYap.TabIndex = 6;
            this.btnSatisYap.Text = " SATIŞ YAP";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(593, 430);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 13);
            this.lblGenelToplam.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnSatisListele);
            this.panel1.Controls.Add(this.btnUrunListele);
            this.panel1.Controls.Add(this.btnUrunEkle);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 91);
            this.panel1.TabIndex = 9;
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(661, 34);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(74, 36);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(741, 34);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(74, 36);
            this.btnMarka.TabIndex = 5;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatisListele
            // 
            this.btnSatisListele.Location = new System.Drawing.Point(527, 34);
            this.btnSatisListele.Name = "btnSatisListele";
            this.btnSatisListele.Size = new System.Drawing.Size(109, 36);
            this.btnSatisListele.TabIndex = 4;
            this.btnSatisListele.Text = "Satışları Listeleme";
            this.btnSatisListele.UseVisualStyleBackColor = true;
            this.btnSatisListele.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(400, 34);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(104, 36);
            this.btnUrunListele.TabIndex = 3;
            this.btnUrunListele.Text = "Ürün Listeleme";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(293, 34);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(101, 36);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekleme";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(148, 34);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(104, 36);
            this.btnMusteriListele.TabIndex = 1;
            this.btnMusteriListele.Text = "Müşteri Listeleme";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(38, 34);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(104, 36);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Müşteri Ekleme";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmSatis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(865, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnSatisIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ekle";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTopFiyat;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtBarNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatisListele;
        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
    }
}

