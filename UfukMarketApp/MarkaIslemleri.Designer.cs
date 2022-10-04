namespace UfukMarketApp
{
    partial class MarkaIslemleri
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
            this.checkBox_Aktif = new System.Windows.Forms.CheckBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MarkaAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSMI_Guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Aktif);
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.btn_YeniEkle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_MarkaAdi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Bilgileri";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(462, 36);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 11;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_YeniEkle
            // 
            this.btn_YeniEkle.Location = new System.Drawing.Point(381, 36);
            this.btn_YeniEkle.Name = "btn_YeniEkle";
            this.btn_YeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_YeniEkle.TabIndex = 10;
            this.btn_YeniEkle.Text = "Yeni Ekle";
            this.btn_YeniEkle.UseVisualStyleBackColor = true;
            this.btn_YeniEkle.Click += new System.EventHandler(this.btn_YeniEkle_Click);
            // 
            // checkBox_Aktif
            // 
            this.checkBox_Aktif.AutoSize = true;
            this.checkBox_Aktif.Location = new System.Drawing.Point(9, 39);
            this.checkBox_Aktif.Name = "checkBox_Aktif";
            this.checkBox_Aktif.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Aktif.TabIndex = 9;
            this.checkBox_Aktif.Text = "Aktif Marka";
            this.checkBox_Aktif.UseVisualStyleBackColor = true;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(462, 35);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 8;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka adı";
            // 
            // tb_MarkaAdi
            // 
            this.tb_MarkaAdi.Location = new System.Drawing.Point(66, 9);
            this.tb_MarkaAdi.Name = "tb_MarkaAdi";
            this.tb_MarkaAdi.Size = new System.Drawing.Size(471, 20);
            this.tb_MarkaAdi.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 354);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSMI_Guncelle,
            this.CMSMI_Sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // CMSMI_Guncelle
            // 
            this.CMSMI_Guncelle.Name = "CMSMI_Guncelle";
            this.CMSMI_Guncelle.Size = new System.Drawing.Size(180, 22);
            this.CMSMI_Guncelle.Text = "Güncelle";
            this.CMSMI_Guncelle.Click += new System.EventHandler(this.CMSMI_Guncelle_Click);
            // 
            // CMSMI_Sil
            // 
            this.CMSMI_Sil.Name = "CMSMI_Sil";
            this.CMSMI_Sil.Size = new System.Drawing.Size(180, 22);
            this.CMSMI_Sil.Text = "Sil";
            this.CMSMI_Sil.Click += new System.EventHandler(this.CMSMI_Sil_Click);
            // 
            // MarkaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MarkaIslemleri";
            this.Text = "Marka İşlemleri";
            this.Load += new System.EventHandler(this.MarkaIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_YeniEkle;
        private System.Windows.Forms.CheckBox checkBox_Aktif;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MarkaAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Guncelle;
        private System.Windows.Forms.ToolStripMenuItem CMSMI_Sil;
    }
}