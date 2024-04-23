using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jarmu jarmu = new Jarmu("BMW","BMW iX", 2022, 22222222, 2222, null );
            Jarmu jarmu2 = new Jarmu("asd2", "asd2iX", 2010, 312312313, 33321, null);

            Jarmu jarmu3 = new Jarmu("asd3", "asd3iX", 2011, 3233131, 111111, null);
            Jarmu jarmu4 = new Jarmu("Toyota", "Corolla", 2021, 8000000, 15000, null);
            Jarmu jarmu5 = new Jarmu("Land Rover", "Defender", 2020, 15000000, 2000, null);

            Szemelyauto szemelyauto = new Szemelyauto(5, 6.5, "Fehér", "Toyota", "Corolla", 2021, 8000000, 15000, null);
            Terepjaro terepjaro = new Terepjaro("4WD", 2000, false, "Land Rover", "Defender", 2020, 15000000, 2000, null) ;


            Autoszalon autoszalon = new Autoszalon();
            autoszalon.UjJarmuHozzaadasa(jarmu);
            autoszalon.UjJarmuHozzaadasa(jarmu2);
            autoszalon.UjJarmuHozzaadasa(jarmu3);
            autoszalon.UjJarmuHozzaadasa(jarmu4);
            autoszalon.UjJarmuHozzaadasa(jarmu5);

            //terepjaro.OffroadCsomagFelszerel();
            //terepjaro.VontatóképességBeállítása(3500);
            autoszalon.JarmuKeresese("Land Rover", "Defender");
            //autoszalon.JarmuvekListazasa();


            //autoszalon.JarmuEladasa("Toyota", "Corolla");
            //autoszalon.JarmuvekListazasa();


        }
    }
}
