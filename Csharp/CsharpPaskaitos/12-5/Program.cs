using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<int> pazymiai = new List<int>();

            Console.WriteLine("Kiek skaiciu norite ivesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("iveskite skaicius:");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));

            }
           
            


            Console.WriteLine("Didziausias pazymys: " + pazymiai.Max);
            Console.WriteLine("maziausias pazymys: " + pazymiai.Min);
            Console.WriteLine("Vidurkis:  " + pazymiai.Average);
            Console.WriteLine("Vidurkis:  " + pazymiai.[rnd.next);
        }
    }
}
