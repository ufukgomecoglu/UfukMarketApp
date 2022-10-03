namespace UfukMarketApp
{
    partial class KategoriIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_KategoriAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_KategoriSec = new System.Windows.Forms.ComboBox();
            this.btn_KategoriEkle = new System.Windows.Forms.Button();
            this.checkBox_Aktif = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSMI_Guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_YeniEkle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Guncelle);
            this.groupBox2.Controls.Add(this.btn_YeniEkle);
            this.groupBox2.Controls.Add(this.checkBox_Aktif);
            this.groupBox2.Controls.Add(this.btn_KategoriEkle);
            this.groupBox2.Controls.Add(this.cb_KategoriSec);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_KategoriAdi);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori Bilgileri";
            // 
            // tb_KategoriAdi
            // 
            this.tb_KategoriAdi.Location = new System.Drawing.Point(90, 44);
            this.tb_KategoriAdi.Name = "tb_KategoriAdi";
            this.tb_KategoriAdi.Size = new System.Drawing.Size(471, 20);
            this.tb_KategoriAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori Seç";
            // 
            // cb_KategoriSec
            // 
            this.cb_KategoriSec.FormattingEnabled = true;
            this.cb_KategoriSec.Location = new System.Drawing.Point(90, 20);
            this.cb_KategoriSec.Name = "cb_KategoriSec";
            this.cb_KategoriSec.Size = new System.Drawing.Size(471, 21);
            this.cb_KategoriSec.TabIndex = 3;
            // 
            // btn_KategoriEkle
            // 
            this.btn_KategoriEkle.Location = new System.Drawing.Point(486, 70);
            this.btn_KategoriEkle.Name = "btn_KategoriEkle";
            this.btn_KategoriEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_KategoriEkle.TabIndex = 2;
            this.btn_KategoriEkle.Text = "Ekle";
            this.btn_KategoriEkle.UseVisualStyleBackColor = true;
            this.btn_KategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // checkBox_Aktif
            // 
            this.checkBox_Aktif.AutoSize = true;
            this.checkBox_Aktif.Location = new System.Drawing.Point(19, 76);
            this.checkBox_Aktif.Name = "checkBox_Aktif";
            this.checkBox_Aktif.Size = new System.Drawing.Size(89, 17);
            this.checkBox_Aktif.TabIndex = 3;
            this.checkBox_Aktif.Text = "Aktif Kategori";
            this.checkBox_Aktif.UseVisualStyleBackColor = true;
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
            // 
            // CMSMI_Sil
            // 
            this.CMSMI_Sil.Name = "CMSMI_Sil";
            this.CMSMI_Sil.Size = new System.Drawing.Size(120, 22);
            this.CMSMI_Sil.Text = "Sil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_YeniEkle
            // 
            this.btn_YeniEkle.Location = new System.Drawing.Point(405, 69);
            this.btn_YeniEkle.Name = "btn_YeniEkle";
            this.btn_YeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_YeniEkle.TabIndex = 4;
            this.btn_YeniEkle.Text = "Yeni Ekle";
            this.btn_YeniEkle.UseVisualStyleBackColor = true;
            this.btn_YeniEkle.Click += new System.EventHandler(this.btn_YeniEkle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(486, 70);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // KategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "KategoriIslemleri";
            this.Text = "KategoriIslemleri";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Aktif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_KategoriEkle;
        private System.Windows.Forms.ComboBox cb_KategoriSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_KategoriAdi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Guncelle;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_YeniEkle;
    }
}