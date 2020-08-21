namespace projeorn1
{
    partial class frmUrunListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SatisFiyattxt = new System.Windows.Forms.TextBox();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.AlisFiyattxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.Miktartxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.UrunAditxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(29, 270);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 13);
            this.lblMiktari.TabIndex = 32;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(116, 261);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Satış Fiyatı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Alış Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ürün Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Barkod No";
            // 
            // SatisFiyattxt
            // 
            this.SatisFiyattxt.Location = new System.Drawing.Point(91, 229);
            this.SatisFiyattxt.Name = "SatisFiyattxt";
            this.SatisFiyattxt.Size = new System.Drawing.Size(100, 20);
            this.SatisFiyattxt.TabIndex = 24;
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(91, 61);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 20);
            this.BarkodNotxt.TabIndex = 17;
            // 
            // AlisFiyattxt
            // 
            this.AlisFiyattxt.Location = new System.Drawing.Point(91, 201);
            this.AlisFiyattxt.Name = "AlisFiyattxt";
            this.AlisFiyattxt.Size = new System.Drawing.Size(100, 20);
            this.AlisFiyattxt.TabIndex = 23;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(90, 89);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(100, 20);
            this.Kategoritxt.TabIndex = 19;
            // 
            // Miktartxt
            // 
            this.Miktartxt.Location = new System.Drawing.Point(91, 173);
            this.Miktartxt.Name = "Miktartxt";
            this.Miktartxt.Size = new System.Drawing.Size(100, 20);
            this.Miktartxt.TabIndex = 22;
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(91, 117);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(100, 20);
            this.Markatxt.TabIndex = 20;
            // 
            // UrunAditxt
            // 
            this.UrunAditxt.Location = new System.Drawing.Point(91, 145);
            this.UrunAditxt.Name = "UrunAditxt";
            this.UrunAditxt.Size = new System.Drawing.Size(100, 20);
            this.UrunAditxt.TabIndex = 21;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(627, 29);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(412, 29);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNoAra.TabIndex = 34;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Barkod No Ara";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(291, 284);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(100, 21);
            this.comboKategori.TabIndex = 36;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(291, 313);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(100, 21);
            this.comboMarka.TabIndex = 37;
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(412, 284);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(59, 50);
            this.btnMarkaGuncelle.TabIndex = 38;
            this.btnMarkaGuncelle.Text = "Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kategori";
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblMiktari);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SatisFiyattxt);
            this.Controls.Add(this.BarkodNotxt);
            this.Controls.Add(this.AlisFiyattxt);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.Miktartxt);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.UrunAditxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMiktari;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SatisFiyattxt;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.TextBox AlisFiyattxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox Miktartxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox UrunAditxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}