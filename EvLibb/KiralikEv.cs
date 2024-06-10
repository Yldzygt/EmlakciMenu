using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvLibb
{
    public class KiralikEv : Ev
    {
        public double Kira { get; set; }
        public double Depozito { get; set; }
        public KiralikEv(byte odasayisi, double alan, string binaisim, byte katno,double kira,double depozito): base(odasayisi, alan, binaisim, katno)
        {
            this.Kira = kira;
            this.Depozito = depozito;
        }
        public KiralikEv()
        {
            
        }

      
        public override string ToString()
        {
            return $"Oda sayısı:{Odasayisi}\nAlan:{Alan}\nBina İsmi:{BinaIsim}\nKat No:{KatNo}\nKira:{Kira}\nDepozito:{Depozito}\n";
        }
    }
}
    