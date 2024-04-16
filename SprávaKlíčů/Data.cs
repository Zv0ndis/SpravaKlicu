using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprávaKlíčů
{
    public static class Data
    {
        public readonly static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\zvond\\Documents\\SpravaKlicu.mdf;Integrated Security=True;Connect Timeout=30";
        public static List<Zamestnanec> zamestnanci = new List<Zamestnanec>();
        public static List<Klic> klice = new List<Klic>();
    }
}
