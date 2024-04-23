using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Szemelyauto : Jarmu

    {

        public int  ulesekSzama {  get; set; }
        public double fogyasztas {  get; set; }

        public string ujSzin {  get; set; }

        public Szemelyauto(int ulesekSzama, double fogyasztas, string ujSzin, string gyarto, string modell, int evjarat, int alapAr, int kilometerAllas, List<string> szervizNaplo) : base(gyarto, modell, evjarat, alapAr, kilometerAllas, szervizNaplo)
        {
            this.ulesekSzama = ulesekSzama;
            this.fogyasztas = fogyasztas;
            this.ujSzin= ujSzin;
        }


        public void KenyelmiExtraBeszerzese(string extra)
        {
            switch (extra)
            {
                case "Led":
                    alapAr += 15000;
                    szervizNaplo.Add("Kenyelmi funkció: Led");
                    Console.WriteLine($"Extra beszerzéseének az ára {15000}");

                    break;

                case "Párna":
                    alapAr += 20000;
                    szervizNaplo.Add("Kényelmi funckió: párna");
                    Console.WriteLine($"Extra beszerzéseének az ára {20000}");
                    break;

                default:
                    return;

            }
        }
        public void SzínFrissítése(string ujSzín)
        {
            ujSzin = ujSzin;
            Console.WriteLine($"Sikeres szín beállítás, aktuális szín {ujSzin}");
        }
    }
}
