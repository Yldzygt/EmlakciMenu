using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvLibb
{
    public class SatilikEv : Ev
    {
        public double Fiyat { get; set; }

        public SatilikEv()
        {

        }
        public SatilikEv(byte odasayisi, double alan, string binaisim, byte katno, double fiyat) : base(odasayisi, alan, binaisim, katno)
        {

        }

        public override string ToString()
        {
            return $"Oda sayısı:{Odasayisi}\nAlan:{Alan}\nBina İsmi:{BinaIsim}\nKat No:{KatNo}\nFiyat:{Fiyat}\n";
        }
    }
}

