using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class SatinAlma
    {
        public int ID { get; set; }
        public int Urun_ID { get; set; }
        public string UrunIsmi { get; set; }
        public int Tedarikci_ID { get; set; }
        public string TedarikciIsmi { get; set; }
        public decimal BirimAdet { get; set; }
        public int Birim_ID { get; set; }
        public string BirimIsmi { get; set; }
        public decimal AlisFiyati { get; set; }
        public DateTime AlisTarihi { get; set; }
    }
}
