using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Ugyfel
    {
        public  string nev {  get; set; }
        public string cim { get; set; }
        public string telefonszam { get; set; }
        public List<string> vasarlasiElozmeny { get; set; }

        public Ugyfel(string nev, string cim, string telefonszam)
        {
            this.nev = nev;
            this.cim = cim;
            this.telefonszam = telefonszam;
            this.vasarlasiElozmeny = new List<string>();
        }

        public void VasarlasiElozmenyHozzaadas(string elozmeny)
        {
            vasarlasiElozmeny.Add(elozmeny);
        }
    }
}
