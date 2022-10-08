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
    public partial class Satisİslemleri : Form
    {
        DataModel dm = new DataModel();
        int id = 0;
        decimal tumtoplam=0;
        public Satisİslemleri()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
        }

        private void Satisİslemleri_Load(object sender, EventArgs e)
        {
            tb_urun.ReadOnly = true;
            tb_birimfiyat.ReadOnly = true;
            tb_aratoplam.ReadOnly = true;
            tb_kdvtutari.ReadOnly = true;
            tb_kdvtuzdesi.ReadOnly = true;
            tb_toplam.ReadOnly = true;
            tb_tumtoplam.ReadOnly = true;
            tb_barkono.Select();
        }

        private void tb_barkono_TextChanged(object sender, EventArgs e)
        {
            if(dm.UrunGetir(tb_barkono.Text).ID!=0)
            {
                Urun u = dm.UrunGetir(tb_barkono.Text);
                tb_urun.Text = u.Isim;
                tb_birimfiyat.Text =u.BirimFiyat.ToString();
                tb_kdvtuzdesi.Text = u.KDVOrani.ToString();
                tb_miktar.Select();
                tb_miktar.SelectAll();
            }
        }

        private void tb_miktar_TextChanged(object sender, EventArgs e)
        {
            Urun u = dm.UrunGetir(tb_barkono.Text);
            if (tb_miktar.Text != "")
            {
                SatisDetaylari sd = new SatisDetaylari(Convert.ToDecimal(tb_miktar.Text), u.BirimFiyat, u.KDVOrani);
                sd.ID = id + 1;
                sd.Urun_ID = u.ID;
                tb_aratoplam.Text = sd.AraToplam.ToString();
                tb_kdvtutari.Text = sd.KDV.ToString();
                tb_toplam.Text = sd.Toplam.ToString();
                dm.SatisDetayEkle(sd);
                tumtoplam = tumtoplam + sd.Toplam;
                tb_tumtoplam.Text = tumtoplam.ToString();
                tb_barkono.Select();
                tb_barkono.SelectAll();
            }
        }
        
    }
}
