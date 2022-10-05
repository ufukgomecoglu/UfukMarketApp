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
    public partial class BirimIslemleri : Form
    {
        DataModel dm = new DataModel();
        int birimid = 0;
        public BirimIslemleri()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Birim b = new Birim()
            {
                Isim = tb_BirimAdi.Text,
                Durum = checkBox_Aktif.Checked
            };
            if (dm.BirimEkle(b))
            {
                MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi");
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
            FormTemizle();
        }

        private void btn_YeniEkle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Birim b = dm.BirimGetir(birimid);
            b.Isim = tb_BirimAdi.Text;
            b.Durum = checkBox_Aktif.Checked;
            if (dm.BirimGuncelle(b))
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

        private void BirimIslemleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
        }
        private void GridDoldur()
        {
            dataGridView1.DataSource = dm.BirimListeleReader();
        }
        private void FormTemizle()
        {
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
            tb_BirimAdi.Text = "";
        }

        private void CMSMI_Guncelle_Click(object sender, EventArgs e)
        {
            Birim b = dm.BirimGetir(birimid);
            tb_BirimAdi.Text = b.Isim;
            checkBox_Aktif.Checked = b.Durum;
            btn_Guncelle.Visible = true;
            btn_YeniEkle.Enabled = true;
        }

        private void CMSMI_Sil_Click(object sender, EventArgs e)
        {
            string isim = dm.BirimGetir(birimid).Isim;
            if (MessageBox.Show(isim + "\nBirim Silinecek. Emin misin?", "Birim Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dm.BirimSil(birimid);
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
                    birimid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells["ID"].Value);
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }
    }
}
