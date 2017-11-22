using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite egzamino rezultata:");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a == 100)
            {
                Console.WriteLine("rezultatas 100");
            }
            else if (a > 80)

                    {
                Console.WriteLine("Rezultatatas aukstesnis nei 80");
                    }

            else if (a > 50)
               {
                Console.WriteLine("Rezultatas aukstesnis nei 50");
            }
            
            else if (a >20)
                {
                Console.WriteLine("Rezultatas aukstesnis nei 20");
            }
            else if (a < 20)
                {
                Console.WriteLine("rezultatas mazesnis nei 20");
            }

               
        }
    }
}
