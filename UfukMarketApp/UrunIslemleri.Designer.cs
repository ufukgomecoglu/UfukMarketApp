namespace UfukMarketApp
{
    partial class UrunIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_YeniEkle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_birim = new System.Windows.Forms.ComboBox();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.tb_birimfiyat = new System.Windows.Forms.TextBox();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.nud_kdv = new System.Windows.Forms.NumericUpDown();
            this.cb_marka = new System.Windows.Forms.ComboBox();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.mtb_barkodno = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_aktif = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSMI_Guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kdv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.btn_YeniEkle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_birim);
            this.groupBox1.Controls.Add(this.tb_aciklama);
            this.groupBox1.Controls.Add(this.tb_birimfiyat);
            this.groupBox1.Controls.Add(this.tb_stok);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.nud_kdv);
            this.groupBox1.Controls.Add(this.cb_marka);
            this.groupBox1.Controls.Add(this.cb_kategori);
            this.groupBox1.Controls.Add(this.mtb_barkodno);
            this.groupBox1.Controls.Add(this.checkBox_aktif);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(703, 174);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_YeniEkle
            // 
            this.btn_YeniEkle.Location = new System.Drawing.Point(622, 174);
            this.btn_YeniEkle.Name = "btn_YeniEkle";
            this.btn_YeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_YeniEkle.TabIndex = 12;
            this.btn_YeniEkle.Text = "Yeni Ekle";
            this.btn_YeniEkle.UseVisualStyleBackColor = true;
            this.btn_YeniEkle.Click += new System.EventHandler(this.btn_YeniEkle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(703, 174);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 11;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birimi";
            // 
            // cb_birim
            // 
            this.cb_birim.FormattingEnabled = true;
            this.cb_birim.Location = new System.Drawing.Point(265, 85);
            this.cb_birim.Name = "cb_birim";
            this.cb_birim.Size = new System.Drawing.Size(117, 21);
            this.cb_birim.TabIndex = 5;
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(458, 63);
            this.tb_aciklama.Multiline = true;
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(317, 105);
            this.tb_aciklama.TabIndex = 10;
            // 
            // tb_birimfiyat
            // 
            this.tb_birimfiyat.Location = new System.Drawing.Point(458, 36);
            this.tb_birimfiyat.Name = "tb_birimfiyat";
            this.tb_birimfiyat.Size = new System.Drawing.Size(317, 20);
            this.tb_birimfiyat.TabIndex = 9;
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(86, 86);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(137, 20);
            this.tb_stok.TabIndex = 8;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(458, 9);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(317, 20);
            this.tb_isim.TabIndex = 7;
            // 
            // nud_kdv
            // 
            this.nud_kdv.Location = new System.Drawing.Point(86, 114);
            this.nud_kdv.Name = "nud_kdv";
            this.nud_kdv.Size = new System.Drawing.Size(296, 20);
            this.nud_kdv.TabIndex = 6;
            // 
            // cb_marka
            // 
            this.cb_marka.FormattingEnabled = true;
            this.cb_marka.Location = new System.Drawing.Point(86, 60);
            this.cb_marka.Name = "cb_marka";
            this.cb_marka.Size = new System.Drawing.Size(296, 21);
            this.cb_marka.TabIndex = 4;
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(86, 35);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(296, 21);
            this.cb_kategori.TabIndex = 3;
            // 
            // mtb_barkodno
            // 
            this.mtb_barkodno.Location = new System.Drawing.Point(86, 8);
            this.mtb_barkodno.Mask = "9999999999999";
            this.mtb_barkodno.Name = "mtb_barkodno";
            this.mtb_barkodno.Size = new System.Drawing.Size(296, 20);
            this.mtb_barkodno.TabIndex = 2;
            // 
            // checkBox_aktif
            // 
            this.checkBox_aktif.AutoSize = true;
            this.checkBox_aktif.Location = new System.Drawing.Point(6, 151);
            this.checkBox_aktif.Name = "checkBox_aktif";
            this.checkBox_aktif.Size = new System.Drawing.Size(73, 17);
            this.checkBox_aktif.TabIndex = 1;
            this.checkBox_aktif.Text = "Aktif Ürun";
            this.checkBox_aktif.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Birim Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stok Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "İsim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "KDV Oranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSMI_Guncelle,
            this.CMSMI_Sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // CMSMI_Guncelle
            // 
            this.CMSMI_Guncelle.Name = "CMSMI_Guncelle";
            this.CMSMI_Guncelle.Size = new System.Drawing.Size(120, 22);
            this.CMSMI_Guncelle.Text = "Güncelle";
            this.CMSMI_Guncelle.Click += new System.EventHandler(this.CMSMI_Guncelle_Click);
            // 
            // CMSMI_Sil
            // 
            this.CMSMI_Sil.Name = "CMSMI_Sil";
            this.CMSMI_Sil.Size = new System.Drawing.Size(120, 22);
            this.CMSMI_Sil.Text = "Sil";
            this.CMSMI_Sil.Click += new System.EventHandler(this.CMSMI_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 287);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunIslemleri";
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.UrunIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kdv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.NumericUpDown nud_kdv;
        private System.Windows.Forms.ComboBox cb_birim;
        private System.Windows.Forms.ComboBox cb_marka;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.MaskedTextBox mtb_barkodno;
        private System.Windows.Forms.CheckBox checkBox_aktif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.TextBox tb_birimfiyat;
        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_YeniEkle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Guncelle;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}