using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a daugiau uz b");
            }
            else if (b > c)
            {
                Console.WriteLine("b daugiau uz c");

            }
            else if (c > a)
            {
                Console.WriteLine("c daugiau uz a");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("skaiciai lygus");
            }

          
            }
        }
    }

