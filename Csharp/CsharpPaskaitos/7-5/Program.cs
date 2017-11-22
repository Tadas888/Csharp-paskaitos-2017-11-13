using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris rezultatus:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (double)(a + b + c) / 3;
            
            if (vidurkis >= 8 && vidurkis <= 10)

           {
                Console.WriteLine("Jusu vidurkis patenka tarp 8 - 10" + vidurkis);
            }

            else if (vidurkis >= 5 && vidurkis == 8 )
            {
                Console.WriteLine("jusu vidurkis patenka tarp 5 - 8" + vidurkis);
            }

            else if (vidurkis < 5)
            {
                Console.WriteLine("Jusu vidurkis zemesnis nei 5" + vidurkis);
            }
            else
            {
                Console.WriteLine("netinkami duomenys");
            }

        }
    }
}
