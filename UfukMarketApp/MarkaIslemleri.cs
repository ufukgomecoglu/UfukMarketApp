using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfukMarketApp
{
    public partial class MarkaIslemleri : Form
    {
        DataModel dm = new DataModel();
        int markaid = 0;
        public MarkaIslemleri()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Marka m = new Marka()
            {
                Isim=tb_MarkaAdi.Text,
                Durum=checkBox_Aktif.Checked
            };
            if (dm.MarkaEkle(m))
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
            Marka m = dm.MarkaGetir(markaid);
            m.Isim = tb_MarkaAdi.Text;
            m.Durum = checkBox_Aktif.Checked;
            if (dm.MarkaGuncelle(m))
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
        private void GridDoldur()
        {
            dataGridView1.DataSource = dm.MarkaListeleReader();
        }
        private void FormTemizle()
        {
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
            tb_MarkaAdi.Text = "";
        }

        private void MarkaIslemleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
            btn_Guncelle.Visible = false;
            btn_YeniEkle.Enabled = false;
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
                    markaid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells["ID"].Value);
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void CMSMI_Guncelle_Click(object sender, EventArgs e)
        {
            Marka m = dm.MarkaGetir(markaid);
            tb_MarkaAdi.Text = m.Isim;
            checkBox_Aktif.Checked = m.Durum;
            btn_Guncelle.Visible = true;
            btn_YeniEkle.Enabled = true;
        }

        private void CMSMI_Sil_Click(object sender, EventArgs e)
        {
            string isim = dm.MarkaGetir(markaid).Isim;
            if (MessageBox.Show(isim + "\nMarka Silinecek. Emin misin?", "Marka Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dm.MarkaSil(markaid);
            }
            else
            {
                MessageBox.Show("Kullanıcı Silme İşlemini İptal Etti", "İptal");
            }
            GridDoldur();
        }
    }
}
