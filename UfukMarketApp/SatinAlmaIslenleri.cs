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
    public partial class SatinAlmaIslenleri : Form
    {
        DataModel dm = new DataModel();
        int satinalmaid = 0;
        bool tamamlandi = false;
        public SatinAlmaIslenleri()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SatinAlma s = new SatinAlma()
            {
                Urun_ID =Convert.ToInt32(cb_urun.SelectedValue),
                Tedarikci_ID = Convert.ToInt32(cb_tedarikci.SelectedValue),
                BirimAdet =Convert.ToDecimal(tb_miktar.Text),
                AlisFiyati = Convert.ToDecimal(tb_alisfiyati.Text),
                AlisTarihi = Convert.ToDateTime(mtb_alindigitarih.Text),
            };
            if (dm.SatinAlmaEkle(s))
            {
                GridDoldur();
                FormTemizle();
                Urun u = dm.UrunGetir(s.Urun_ID);
                u.Stok = u.Stok + s.BirimAdet;
                dm.UrunGuncelle(u);
                MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi");
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SatinAlma s = dm.SatinAlmaGetir(satinalmaid);
            s.Urun_ID = Convert.ToInt32(cb_urun.SelectedValue);
            s.Tedarikci_ID = Convert.ToInt32(cb_tedarikci.SelectedValue);
            s.BirimAdet = Convert.ToDecimal(tb_miktar.Text);
            s.AlisFiyati = Convert.ToDecimal(tb_alisfiyati.Text);
            s.AlisTarihi = Convert.ToDateTime(mtb_alindigitarih.Text);
            if (dm.SatinAlmaGüncelle(s))
            {
                Urun u = dm.UrunGetir(s.Urun_ID);
                u.Stok = u.Stok - s.BirimAdet;
                u.Stok = u.Stok + Convert.ToDecimal(tb_miktar.Text);
                dm.UrunGuncelle(u);
                MessageBox.Show("Başardık Dorothy", "Başarılı");
            }
            else
            {
                MessageBox.Show("Ne Oldu Anlamadık.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormTemizle();
            GridDoldur();
        }

        private void btn_YeniEkle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void SatinAlmaIslenleri_Load(object sender, EventArgs e)
        {
            CbDoldur();
            GridDoldur();
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
            tb_Birim.ReadOnly = true;
        }

        private void CMSMI_Guncelle_Click(object sender, EventArgs e)
        {
            SatinAlma s = dm.SatinAlmaGetir(satinalmaid);
            cb_urun.Text = s.UrunIsmi;
            cb_tedarikci.Text = s.TedarikciIsmi;
            tb_miktar.Text =Convert.ToString(s.BirimAdet);
            tb_alisfiyati.Text = Convert.ToString(s.AlisFiyati);
            mtb_alindigitarih.Text = s.AlisTarihi.ToString("dd-MM-yyyy");
            btn_Guncelle.Visible = true;
            btn_YeniEkle.Enabled = true;
        }

        private void CMSMI_Sil_Click(object sender, EventArgs e)
        {
            SatinAlma s = dm.SatinAlmaGetir(satinalmaid);
            string isim = s.UrunIsmi;
            if (MessageBox.Show(isim + "\nalınan ürün Silinecek. Emin misin?", "Satınalma Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Urun u = dm.UrunGetir(s.Urun_ID);
                u.Stok = u.Stok - s.BirimAdet;
                dm.SatinAlmaSil(satinalmaid);
            }
            else
            {
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
                    satinalmaid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells["ID"].Value);
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }
        private void FormTemizle()
        {
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
            tb_Birim.ReadOnly = true;
            tb_miktar.Text = tb_alisfiyati.Text =mtb_alindigitarih.Text=tb_Birim.Text= "";
            CbDoldur();
        }
        private void GridDoldur()
        {
            dataGridView1.DataSource = dm.SatinAlmaListeleReader();
            dataGridView1.Columns["Tedarikci_ID"].Visible = dataGridView1.Columns["Urun_ID"].Visible = false;
        }
        private void CbDoldur()
        {
            cb_urun.DataSource = dm.UrunListeleReader();
            cb_urun.ValueMember = "ID";
            cb_urun.DisplayMember = "Isim";
            cb_urun.Text = "Ürün seçiniz..";
            cb_tedarikci.DataSource = dm.TedarikciListeleReader();
            cb_tedarikci.ValueMember = "ID";
            cb_tedarikci.DisplayMember = "FirmaAdi";
            cb_tedarikci.Text = "Tedarikçi seçiniz..";
            tamamlandi = true;
        }

        private void cb_urun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tamamlandi == true)
            {
                Urun u = dm.UrunGetir(Convert.ToInt32(cb_urun.SelectedValue));
                tb_Birim.Text = dm.BirimGetir(u.Birim_ID).Isim;
            }
        }
    }
}
