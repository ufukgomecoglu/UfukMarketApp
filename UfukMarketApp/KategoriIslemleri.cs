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
        public KategoriIslemleri()
        {
            InitializeComponent();
        }

        private void btn_YeniEkle_Click(object sender, EventArgs e)
        {
            Kategori k;
            if (cb_KategoriSec.SelectedItem==null)
            {
                k = new Kategori()
                {
                    Isim = tb_KategoriAdi.Text,
                    UstKategori_ID = Convert.ToInt32(cb_KategoriSec.SelectedValue),
                    Durum = checkBox_Aktif.Checked
                };
            }
            else
            {
                k = new Kategori()
                {
                    Isim = tb_KategoriAdi.Text,
                    UstKategori_ID = 0,
                    Durum = checkBox_Aktif.Checked
                };
            }
            if (dm.KategoriEkle(k))
            {

            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {

        }

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {

        }
        private void CbDoldur()
        {
            //cb_Sehir.DataSource = dm.SehirleriListele();
            //cb_Sehir.ValueMember = "ID";
            //cb_Sehir.DisplayMember = "Isim";
            //tamamlandi = true;
            //cb_Ilce.Text = "Sehir Seçiniz...";
        }
    }
}
