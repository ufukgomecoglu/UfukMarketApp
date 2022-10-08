using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class SatisDetaylari
    {
        public SatisDetaylari()
        {

        }
        public SatisDetaylari( decimal adet, decimal birimfiyat , int kdvorani)
        {
            this.Adet = adet;
            this.BirimFiyat = birimfiyat;
            this.KDVOrani = kdvorani;
            this.AraToplam = this.Adet * this.BirimFiyat;
            this.KDV = this.AraToplam * (Convert.ToDecimal(this.KDVOrani) / 100);
            this.Toplam = this.AraToplam + this.KDV;
        }
        public int ID { get; set; }
        public int Satis_ID { get; set; }
        public int Urun_ID { get; set; }
        public int KDVOrani { get; set; }
        public decimal Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal AraToplam { get; set; }
        public decimal Toplam { get; set; }
        public decimal KDV { get; set; }
    }
}
