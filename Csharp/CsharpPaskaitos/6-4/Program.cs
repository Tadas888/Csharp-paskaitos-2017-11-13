using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pazymi:");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a == 10)
            {
                Console.WriteLine("Puikiai!");
            }
            else if (a == 8 || a == 9)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (a == 7 || a == 5)
            {
                Console.WriteLine("Patenkinamai");

            }
            else if (a == 3 || a == 4)
            {
                Console.WriteLine("Prastai");

            }
            else if (a == 1 || a == 2)
            {
                Console.WriteLine("Labai Blogai");

            }
        }
    }
}
