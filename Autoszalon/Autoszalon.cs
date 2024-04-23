using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszalon
{
    internal class Autoszalon
    {
        public List<Jarmu> Jarmuvek {  get; set; }
        

        public Autoszalon()
        {
            Jarmuvek = new List<Jarmu>();
        }

       public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
            Console.WriteLine("Sikeresen hozzáadva a jármű");
        }
        
       public bool JarmuEladasa(string gyarto, string modell)
        {
           var jarmu = Jarmuvek.Find(j => j.gyarto == gyarto && j.modell == modell);
            if(jarmu != null)
            {
                Jarmuvek.Remove(jarmu);
                Console.WriteLine("Sikeres eladás");
                return true; 
            }
            return false;
           
        }

        public void JarmuKeresese(string gyarto, string modell)
        {
            var jarmu = Jarmuvek.Find(j => j.gyarto == gyarto && j.modell == modell);
            if( jarmu != null) {
                Console.WriteLine("Sikeres találat");
                Console.WriteLine(jarmu.JarmuInfo());

                
            }
            
          
        }

       public void JarmuvekListazasa()
        {
            foreach (var item in Jarmuvek)
            {
                Console.WriteLine(item.JarmuInfo());
            }
        }


        public void UjUgyfel(string ugyfelNev, string ugyfelCim, string ugyfelTelefonSzam)
        {
            Ugyfel ugyfel = new Ugyfel(ugyfelNev, ugyfelCim, ugyfelTelefonSzam);
           
            Console.WriteLine("Sikeres ugyfélfelvétel");

        }
   
    }
}
