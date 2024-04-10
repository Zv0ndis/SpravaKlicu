using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprávaKlíčů
{
    public class Klic
    {
        public int Cislo { get; set; }
        public string NazevMistnosti { get; set; }
        public string OznaceniDveri { get; set; }
        public int PocetVyrobenychKusu { get; set; }

        public int PocetVypujcenychKusu { get; set; }

        public Klic(int cislo, string nazevMistnosti, string oznaceniDveri, int pocetVyrobenychKusu)
        {
            Cislo = cislo;
            NazevMistnosti = nazevMistnosti;
            OznaceniDveri = oznaceniDveri;
            PocetVyrobenychKusu = pocetVyrobenychKusu;
            PocetVypujcenychKusu = 0;
        }
    }
}
