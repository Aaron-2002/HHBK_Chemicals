﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS
{
    class Produkt
    {
        private int artikelnummer;
        private string artikelname;
        private int verkaufseinheit;
        private double preisVK;

        public int Artikelnummer { get => artikelnummer; set => artikelnummer = value; }
        public string Artikelname { get => artikelname; set => artikelname = value; }
        public int Verkaufseinheit { get => verkaufseinheit; set => verkaufseinheit = value; }
        public double PreisVK { get => preisVK; set => preisVK = value; }
    }
}
