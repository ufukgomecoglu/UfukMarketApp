using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Satis
    {
        public Satis()
        {
            this.KDV = this.AraToplam * (this.KDVOrani / 100);
            this.Toplam = this.AraToplam + this.KDV;
            this.SatisTarihi=DateTime.Now;
        }
        public int ID { get; set; }
        public int Satis_ID { get; set; }
        public int Urun_ID { get; set; }
        public string BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public int KDVOrani { get; set; }
        public int KUllanici_ID { get; set; }
        public decimal AraToplam { get; set; }
        public decimal KDV { get; set; }
        public decimal Toplam { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
