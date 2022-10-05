namespace UfukMarketApp
{
    partial class SatinAlmaIslenleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_urun = new System.Windows.Forms.ComboBox();
            this.cb_tedarikci = new System.Windows.Forms.ComboBox();
            this.tb_miktar = new System.Windows.Forms.TextBox();
            this.tb_alisfiyati = new System.Windows.Forms.TextBox();
            this.mtb_alindigitarih = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSMI_Guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_YeniEkle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Birim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Birim);
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.btn_YeniEkle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.mtb_alindigitarih);
            this.groupBox1.Controls.Add(this.tb_alisfiyati);
            this.groupBox1.Controls.Add(this.tb_miktar);
            this.groupBox1.Controls.Add(this.cb_tedarikci);
            this.groupBox1.Controls.Add(this.cb_urun);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satın Alma Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tedarikçi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Alış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alındığı Tarih";
            // 
            // cb_urun
            // 
            this.cb_urun.FormattingEnabled = true;
            this.cb_urun.Location = new System.Drawing.Point(79, 17);
            this.cb_urun.Name = "cb_urun";
            this.cb_urun.Size = new System.Drawing.Size(309, 21);
            this.cb_urun.TabIndex = 4;
            this.cb_urun.SelectedIndexChanged += new System.EventHandler(this.cb_urun_SelectedIndexChanged);
            // 
            // cb_tedarikci
            // 
            this.cb_tedarikci.FormattingEnabled = true;
            this.cb_tedarikci.Location = new System.Drawing.Point(79, 43);
            this.cb_tedarikci.Name = "cb_tedarikci";
            this.cb_tedarikci.Size = new System.Drawing.Size(309, 21);
            this.cb_tedarikci.TabIndex = 5;
            // 
            // tb_miktar
            // 
            this.tb_miktar.Location = new System.Drawing.Point(79, 70);
            this.tb_miktar.Name = "tb_miktar";
            this.tb_miktar.Size = new System.Drawing.Size(123, 20);
            this.tb_miktar.TabIndex = 6;
            // 
            // tb_alisfiyati
            // 
            this.tb_alisfiyati.Location = new System.Drawing.Point(79, 97);
            this.tb_alisfiyati.Name = "tb_alisfiyati";
            this.tb_alisfiyati.Size = new System.Drawing.Size(309, 20);
            this.tb_alisfiyati.TabIndex = 8;
            // 
            // mtb_alindigitarih
            // 
            this.mtb_alindigitarih.Location = new System.Drawing.Point(79, 124);
            this.mtb_alindigitarih.Mask = "00/00/0000";
            this.mtb_alindigitarih.Name = "mtb_alindigitarih";
            this.mtb_alindigitarih.Size = new System.Drawing.Size(309, 20);
            this.mtb_alindigitarih.TabIndex = 9;
            this.mtb_alindigitarih.ValidatingType = typeof(System.DateTime);
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
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(313, 150);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 16;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_YeniEkle
            // 
            this.btn_YeniEkle.Location = new System.Drawing.Point(232, 150);
            this.btn_YeniEkle.Name = "btn_YeniEkle";
            this.btn_YeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_YeniEkle.TabIndex = 15;
            this.btn_YeniEkle.Text = "Yeni Ekle";
            this.btn_YeniEkle.UseVisualStyleBackColor = true;
            this.btn_YeniEkle.Click += new System.EventHandler(this.btn_YeniEkle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(313, 150);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 315);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // tb_Birim
            // 
            this.tb_Birim.Location = new System.Drawing.Point(244, 69);
            this.tb_Birim.Name = "tb_Birim";
            this.tb_Birim.Size = new System.Drawing.Size(144, 20);
            this.tb_Birim.TabIndex = 17;
            // 
            // SatinAlmaIslenleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SatinAlmaIslenleri";
            this.Text = "Satın Alma İşlemleri";
            this.Load += new System.EventHandler(this.SatinAlmaIslenleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_alisfiyati;
        private System.Windows.Forms.TextBox tb_miktar;
        private System.Windows.Forms.ComboBox cb_tedarikci;
        private System.Windows.Forms.ComboBox cb_urun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_alindigitarih;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Guncelle;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Sil;
        private System.Windows.Forms.Button btn_YeniEkle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Birim;
    }
}