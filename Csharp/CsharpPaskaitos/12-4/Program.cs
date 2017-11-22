using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();

            var rnd = new Random();
                var kieksugeneruoti = rnd.Next(1, 101);

                for (int i = 0; i< kieksugeneruoti; i++)
			{
             skaiciai.Add(rnd.Next(1, 101));
                Console.Write(skaiciai[i] + "  ");
			}

            Console.WriteLine("maziausias skaicius:  " + skaiciai.Min());
            Console.WriteLine("Didziausias skaicius: " + skaiciai.Max());
            var vidurkis = skaiciai.Average();
            Console.WriteLine("Vidurkis  " + skaiciai.Average());

            var zemesniuuzvidurki = 0;
            var suma = 0; 
            foreach (var skaicius in skaiciai)

            {
                if (skaicius < vidurkis)
                {
                    zemesniuuzvidurki++;
                }
                if (skaicius % 2 == 0)
                {
                    suma += skaicius;
                }
            }
            Console.WriteLine("Lyginiai skaiciu suma  " + suma);
            Console.ReadLine();
            
            

            



            
            
            

            



                    }
    }
}
