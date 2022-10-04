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
    public partial class AnaForm : Form
    {
        public static KullaniciLoginModel LoginUser;
        public AnaForm()
        {
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            InitializeComponent();
            TSSL_Kullanici.Text = "Aktif Kullanıcı = " + LoginUser.KullaniciAdi;
            this.WindowState = FormWindowState.Maximized;
        }

        private void TSMI_TedarikciIslemleri_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;
            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(TedarikciIslemleri))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if (acikmi == false)
            {
                TedarikciIslemleri frm = new TedarikciIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_KategoriIslemleri_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;
            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(KategoriIslemleri))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if (acikmi == false)
            {
                KategoriIslemleri frm = new KategoriIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_MarkaIslemleri_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;
            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(MarkaIslemleri))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if (acikmi == false)
            {
                MarkaIslemleri frm = new MarkaIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
