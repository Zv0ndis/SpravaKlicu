using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprávaKlíčů
{
    public class Zamestnanec
    {
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Zkratka { get; set; }

        public Zamestnanec(string jmeno, string prijmeni, string zkratka,int ID)
        {
            this.ID = ID;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Zkratka = zkratka.ToUpper(); 
        }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni}";
        }

    }

}
