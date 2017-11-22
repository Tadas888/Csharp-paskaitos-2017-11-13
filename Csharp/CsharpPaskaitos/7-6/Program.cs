using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if ( a > b || a == 0)
            {
                Console.WriteLine("a yra didesnis uz b arba lygus 0");
            }
            else if (b > a || a == 5)
            {
                Console.WriteLine("b yra didesnis uz a arba lygus 5");
            }
            else if (a > b && a == 20 )
            {
                Console.WriteLine("a daugiau uz b arba lygu 20");
            }
            else if ( b > a && b < 100)
            {
                Console.WriteLine("b yra daugiau uz a ir maziau uz 100");
            }

        }
    }
}
