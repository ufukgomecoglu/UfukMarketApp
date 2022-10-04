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
    public partial class KategoriIslemleri : Form
    {
        DataModel dm = new DataModel();
        int kategoriid = 0;
        public KategoriIslemleri()
        {
            InitializeComponent();
        }

        private void btn_YeniEkle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Kategori k = dm.KategoriGetir(kategoriid);
            if (cb_KategoriSec.SelectedItem != null)
            {
                k.Isim = tb_KategoriAdi.Text;
                k.UstKategori_ID = Convert.ToInt32(cb_KategoriSec.SelectedValue);
                k.Durum = checkBox_Aktif.Checked;
            }
            else
            {
                k.Isim = tb_KategoriAdi.Text;
                k.UstKategori_ID = 0;
                k.Durum = checkBox_Aktif.Checked;
            }

            if (dm.KategoriGuncelle(k))
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

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            if (cb_KategoriSec.SelectedItem != null)
            {
                k.Isim = tb_KategoriAdi.Text;
                k.UstKategori_ID = Convert.ToInt32(cb_KategoriSec.SelectedValue);
                k.Durum = checkBox_Aktif.Checked;
            }
            else
            {
                k.Isim = tb_KategoriAdi.Text;
                k.UstKategori_ID = 0;
                k.Durum = checkBox_Aktif.Checked;
            }
            if (dm.KategoriEkle(k))
            {
                FormTemizle();
                GridDoldur();
                MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi");
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CbDoldur()
        {
            if (dm.KategoriListeleReader().Count != 0)
            {
                cb_KategoriSec.DataSource = dm.KategoriListeleReader();
                cb_KategoriSec.ValueMember = "ID";
                cb_KategoriSec.DisplayMember = "Isim";
                cb_KategoriSec.Text = "Alt kategori eklemek istiyorsanız kategori seçiniz";
            }
            else
            {
                cb_KategoriSec.ValueMember = "ID";
                cb_KategoriSec.DisplayMember = "Isim";
                cb_KategoriSec.Text = "Henüz kategori eklenmedi";
            }
        }

        private void KategoriIslemleri_Load(object sender, EventArgs e)
        {
            CbDoldur();
            GridDoldur();
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
        }

        private void GridDoldur()
        {
            dataGridView1.DataSource = dm.KategoriListeleReader();
            dataGridView1.Columns["Silinmis"].Visible = false;
        }
        private void FormTemizle()
        {
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
            tb_KategoriAdi.Text = "";
            CbDoldur();
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
                    kategoriid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells["ID"].Value);
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void CMSMI_Guncelle_Click(object sender, EventArgs e)
        {
            Kategori k = dm.KategoriGetir(kategoriid);
            tb_KategoriAdi.Text = k.Isim;
            checkBox_Aktif.Checked = k.Durum;
            if (k.UstKategori_ID != 0)
            {
                cb_KategoriSec.Text = dm.KategoriGetir(k.UstKategori_ID).Isim;
            }
            btn_Guncelle.Visible = true;
            btn_YeniEkle.Enabled = true;
        }

        private void CMSMI_Sil_Click(object sender, EventArgs e)
        {
            string isim = dm.KategoriGetir(kategoriid).Isim;
            if (MessageBox.Show(isim + "\nKategori Silinecek. Emin misin?", "Kategori Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dm.KategoriSil(kategoriid);
            }
            else
            {
                MessageBox.Show("Kullanıcı Silme İşlemini İptal Etti", "İptal");
            }
            GridDoldur();
            CbDoldur();
        }
    }
}
