﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Urun
    {
        public int ID { get; set; }
        public string BarkodNo { get; set; }
        public int Kategori_ID { get; set; }
        public string KategoriIsmi { get; set; }
        public int Marka_ID { get; set; }
        public string MarkaIsmi { get; set; }
        public int Birim_ID { get; set; }
        public string BirimIsmi { get; set; }
        public int KDVOrani { get; set; }
        public string Isim { get; set; }
        public decimal Stok { get; set; }
        public string Aciklama { get; set; }
        public decimal BirimFiyat { get; set; }
        public bool Durum { get; set; }
    }
}
