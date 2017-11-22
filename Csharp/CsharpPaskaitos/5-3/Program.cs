using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama skaiciu:");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Prasome atidziau skaityti uzduoti!!!!!!!");
            }
            if (a > 0)
            {
                Console.WriteLine("Sveikiname, ivedete teigiama skaiciu!!!");
            }
            if (a %2 == 0)
            { 
                Console.WriteLine("skaicius Lyginis");
            }
            if (a %4 == 0)
            {
                Console.WriteLine("sakicius dalinasi is 4");
            }
            if (a > 10)
            {
                Console.WriteLine("skaicius didesnis uz 10");
            }
            Console.ReadLine();
        }
    }
}
