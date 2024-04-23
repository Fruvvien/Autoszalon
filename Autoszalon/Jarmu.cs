using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Jarmu
    {

        public string gyarto {  get; set; }
        public string modell { get; set; }
        public int evjarat { get; set; }
        public int alapAr {  get; set; }
        public int kilometerAllas { get; set; }

        public List<string> szervizNaplo { get; set; }

        public Jarmu(string gyarto, string modell, int evjarat, int alapAr, int kilometerAllas, List<string> szervizNaplo)
        {
            this.gyarto = gyarto;   
            this.modell = modell;
            this.evjarat = evjarat;
            this.alapAr = alapAr;
            this.kilometerAllas = kilometerAllas;
            this.szervizNaplo = szervizNaplo;

        }


        public string JarmuInfo()
        {
            return $"{gyarto} {modell} {evjarat}";
        }

        public int ArKalkulacio()
        {
            int ujAr = alapAr - (evjarat * 10000);
            Console.WriteLine($"Új ár {ujAr}");
            return alapAr = ujAr;

        }

        public void KmAllasFrissites(int km)
        {
            kilometerAllas += km;
            Console.WriteLine($"Sikeres km hozzáadás aktuális km{kilometerAllas}");
        }




    }
}
