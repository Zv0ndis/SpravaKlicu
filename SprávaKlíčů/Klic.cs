using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprávaKlíčů
{
    public class Klic
    {
        public int ID { get; set; }
        public string Cislo { get; set; }
        public string NazevMistnosti { get; set; }
        public string OznaceniDveri { get; set; }
        public int PocetVyrobenychKusu { get; set; }
        public int PocetVypujcenychKusu { get; set; }

        public Klic(string cislo, string nazevMistnosti, string oznaceniDveri, int pocetVyrobenychKusu,int pocetVypujcenych,int ID)
        {
            this.ID = ID;
            Cislo = cislo;
            NazevMistnosti = nazevMistnosti;
            OznaceniDveri = oznaceniDveri;
            PocetVyrobenychKusu = pocetVyrobenychKusu;
            PocetVypujcenychKusu = pocetVypujcenych;
        }

        public override string ToString()
        {
            return $"{Cislo} {OznaceniDveri} {NazevMistnosti}";
        }
    }
}
