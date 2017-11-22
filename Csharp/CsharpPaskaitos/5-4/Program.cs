using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 5 skaicius:");
                var a = Convert.ToDouble(Console.ReadLine());
                var b = Convert.ToDouble(Console.ReadLine());
                var c = Convert.ToDouble(Console.ReadLine());
                var d = Convert.ToDouble(Console.ReadLine());
                var e = Convert.ToDouble(Console.ReadLine());
            var vidurkis = (a + b + c + d + e) / 5;

            Console.WriteLine("vidurkis  " + vidurkis);
            if (vidurkis >= 5)
            {
                Console.WriteLine("Balas aukstesnis uz 5");
            }
                
        }
    }
}
