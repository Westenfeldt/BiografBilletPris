using System;

namespace BiografBilletPris
{
    class Program
    {
        static void Main(string[] args)
        {

            string alder;
            double age;
            double billet18 = 35;
            double billet1860 = 60;
            double billet60 = 30;

            Console.WriteLine("Velkommen til online delen af vores billetsystem. Angiv alder for at se priser");

            alder = Console.ReadLine();

            age = float.Parse(alder);

            if (age < 18)
            {
                Console.WriteLine("Din billet pris er {0}", billet18);
            }
            else if (age >= 18 && age < 60)
            {
                Console.WriteLine("Din billet pris er {0}", billet1860);
            }
            else if (age > 60)
            {
                Console.WriteLine("Din billet pris er {0}", billet60);
            }





        }
    }
}
