using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfukMarketApp
{
    public partial class UrunIslemleri : Form
    {
        DataModel dm = new DataModel();
        int urunid = 0;
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun()
            {
                BarkodNo = mtb_barkodno.Text,
                Kategori_ID = Convert.ToInt32(cb_kategori.SelectedValue),
                Marka_ID = Convert.ToInt32(cb_marka.SelectedValue),
                Birim_ID = Convert.ToInt32(cb_birim.SelectedValue),
                KDVOrani = Convert.ToInt32(nud_kdv.Value),
                Isim= tb_isim.Text,
                Stok = Convert.ToDecimal(tb_stok.Text),
                Aciklama =  tb_aciklama.Text,
                BirimFiyat = Convert.ToDecimal(tb_birimfiyat.Text),
                Durum=checkBox_aktif.Checked,
            };
            if (dm.UrunEkle(u))
            {
                GridDoldur();
                FormTemizle();
                MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi");
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_YeniEkle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Urun u = dm.UrunGetir(urunid);
            u.BarkodNo = mtb_barkodno.Text;
            u.Kategori_ID = Convert.ToInt32(cb_kategori.SelectedValue);
            u.Marka_ID = Convert.ToInt32(cb_marka.SelectedValue);
            u.Birim_ID = Convert.ToInt32(cb_birim.SelectedValue);
            u.KDVOrani = Convert.ToInt32(nud_kdv.Value);
            u.Isim = tb_isim.Text;
            u.Stok = Convert.ToDecimal(tb_stok.Text);
            u.Aciklama = tb_aciklama.Text;
            u.BirimFiyat = Convert.ToDecimal(tb_birimfiyat.Text);
            u.Durum = checkBox_aktif.Checked;
            if (dm.UrunGuncelle(u))
            {
                MessageBox.Show("Güncelleme işlemi başarılı", "Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormTemizle();
            GridDoldur();
        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            CbDoldur();
            GridDoldur();
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
        }

        private void CMSMI_Guncelle_Click(object sender, EventArgs e)
        {
            Urun u = dm.UrunGetir(urunid);
            mtb_barkodno.Text = u.BarkodNo;
            cb_kategori.Text = u.KategoriIsmi;
            cb_marka.Text = u.MarkaIsmi;
            tb_stok.Text = Convert.ToString(u.Stok);
            cb_birim.Text = u.BirimIsmi;
            nud_kdv.Value =Convert.ToDecimal( u.KDVOrani);
            tb_isim.Text = u.Isim;
            tb_birimfiyat.Text = Convert.ToString(u.BirimFiyat);
            tb_aciklama.Text = u.Aciklama;
            checkBox_aktif.Checked = u.Durum;
            btn_Guncelle.Visible = true;
            btn_YeniEkle.Enabled = true;
        }

        private void CMSMI_Sil_Click(object sender, EventArgs e)
        {
            string isim = dm.UrunGetir(urunid).Isim;
            if (MessageBox.Show(isim + "\nFirma Silinecek. Emin misin?", "Ürün Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dm.UrunSil(urunid);
            }
            else
            {
                DataTable dt = new DataTable();
                MessageBox.Show("Kullanıcı Silme İşlemini İptal Etti", "İptal");
            }
            GridDoldur();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                //MessageBox.Show(hit.RowIndex.ToString());
                dataGridView1.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    urunid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells["ID"].Value);
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }
        private void CbDoldur()
        {
            cb_kategori.DataSource = dm.KategoriListeleReader();
            cb_kategori.ValueMember = "ID";
            cb_kategori.DisplayMember = "Isim";
            cb_kategori.Text = "Kategori Seçiniz..";
            cb_marka.DataSource = dm.MarkaListeleReader();
            cb_marka.ValueMember = "ID";
            cb_marka.DisplayMember = "Isim";
            cb_marka.Text = "Marka Seçiniz..";
            cb_birim.DataSource = dm.BirimListeleReader();
            cb_birim.ValueMember = "ID";
            cb_birim.DisplayMember = "Isim";
            cb_birim.Text = "Birim Seçiniz..";
        }
        private void GridDoldur()
        {
            dataGridView1.DataSource = dm.UrunListeleReader();
            dataGridView1.Columns["Kategori_ID"].Visible = dataGridView1.Columns["Marka_ID"].Visible = dataGridView1.Columns["Birim_ID"].Visible = false;
        }
        private void FormTemizle()
        {
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
            mtb_barkodno.Text = tb_stok.Text = tb_isim.Text = tb_birimfiyat.Text = tb_aciklama.Text = "";
            nud_kdv.Value = 0;
            checkBox_aktif.Checked = false;
            CbDoldur();
        }
    }
}
