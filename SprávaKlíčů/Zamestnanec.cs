using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprávaKlíčů
{
    public class Zamestnanec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Zkratka { get; set; }

        public List<Klic> VypujceneKlice { get; set; } = new List<Klic>();

        public Zamestnanec(string jmeno, string prijmeni, string zkratka)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Zkratka = zkratka.ToUpper(); 
        }
        public void PridatVypujcenyKlic(Klic klic)
        {
            VypujceneKlice.Add(klic);
        }

        public void OdebratVypujcenyKlic(Klic klic)
        {
            VypujceneKlice.Remove(klic);
        }
    }

}
