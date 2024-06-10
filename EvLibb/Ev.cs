namespace EvLibb
{
    public abstract class Ev
    {
        public byte Odasayisi { get; set; }
        public double Alan { get; set; }
        public string BinaIsim { get; set; }
        public byte KatNo { get; set; }

        public Ev(byte odasayisi, double alan, string binaisim, byte katno)
        {
            this.Odasayisi = odasayisi;
            this.Alan = alan;
            this.BinaIsim = binaisim;
            this.KatNo = katno; 
        }
        public Ev()
        {
            
        }

        public abstract string ToString();
        //private byte odaSayisi;
        //private int Alan;
        //private string Binaİsmi;
        //private byte KatNo;


    }

}
