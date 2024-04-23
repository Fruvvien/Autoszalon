using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Terepjaro : Jarmu


    {
        public string hajtas {  get; set; }
        public bool offroadKepessegek {  get; set; }
        public int vontatoKepesseg {  get; set; }

        public Terepjaro(string hajtas, int vontatoKepesseg, bool offroadKepessegek, string gyarto, string modell, int evjarat, int alapAr, int kilometerAllas, List<string> szervizNaplo) : base(gyarto, modell, evjarat, alapAr, kilometerAllas, szervizNaplo)
        {
           this.hajtas = hajtas;
           this.offroadKepessegek = offroadKepessegek;
           this.vontatoKepesseg = vontatoKepesseg;
        }


        public void OffroadCsomagFelszerel()
        {
            alapAr += 30000;
            offroadKepessegek = true;
            szervizNaplo.Add("offroad csomag felszerelve");
            Console.WriteLine($"offroad képességek hozzá lettek adva, az ára {30000} volt, offroad képesség mostantól {offroadKepessegek}");
        }

        public void VontatóképességBeállítása(int kepesseg)
        {
            vontatoKepesseg = kepesseg;
            szervizNaplo.Add("vontató képesség beállítva");
            Console.WriteLine($"Sikeres vontatóképesség hozzáadva, aktuális ereje {vontatoKepesseg}");
        }
    }
}
