using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ev
{
    internal class Emlak
    {
        int odasayisi;
        string il;
        string ilce;
        int fiyat;
        int binayasi;
        string isitmatürü;
        string depremriski;
        string emlaktipi;
        int metrekare;
        string satiliktürü;
        string tapudurümu;
        int banyosayisi;
        int balkonsayisi;

        public int Odasayisi { get => odasayisi; set => odasayisi = value; }
        public string Il { get => il; set => il = value; }
        public string Ilce { get => ilce; set => ilce = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public int Binayasi { get => binayasi; set => binayasi = value; }
        public string Isitmatürü { get => isitmatürü; set => isitmatürü = value; }
        public string Depremriski { get => depremriski; set => depremriski = value; }
        public string Emlaktipi { get => emlaktipi; set => emlaktipi = value; }
        public int Metrekare { get => metrekare; set => metrekare = value; }
        public string Satiliktürü { get => satiliktürü; set => satiliktürü = value; }
        public string Tapudurümu { get => tapudurümu; set => tapudurümu = value; }
        public int Banyosayisi { get => banyosayisi; set => banyosayisi = value; }
        public int Balkonsayisi { get => balkonsayisi; set => balkonsayisi = value; }

        public Emlak(int odasayisi, string il, string ilce, int fiyat, int binayasi, string isitmatürü, string depremriski, string emlaktipi, int metrekare, string satiliktürü, string tapudurümu, int banyosayisi, int balkonsayisi)
        {
            this.odasayisi = odasayisi;
            this.il = il;
            this.ilce = ilce;
            this.fiyat = fiyat;
            this.binayasi = binayasi;
            this.isitmatürü = isitmatürü;
            this.depremriski = depremriski;
            this.emlaktipi = emlaktipi;
            this.metrekare = metrekare;
            this.satiliktürü = satiliktürü;
            this.tapudurümu = tapudurümu;
            this.banyosayisi = banyosayisi;
            this.balkonsayisi = balkonsayisi;
            
        }
    }

}
