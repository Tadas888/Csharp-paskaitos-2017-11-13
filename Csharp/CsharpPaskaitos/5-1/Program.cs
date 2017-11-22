using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());


            if (a == b) 
            {
                Console.WriteLine("a lygu b");
            }
            if (b == c) 
            {
                Console.WriteLine("b lygu c");
            }
                if (a > b) 
                {
                    Console.Write("a daugiau uz b");
                }
            if (a > b * 2) 
            {
                Console.WriteLine("a daugiau uz b kart 2");
            }
            if (a % 2==0) 
            {
                Console.WriteLine("skaicius lyginis");

            }
            if (b % 2 != 0)
            {
                Console.WriteLine("Skaicius nelyginis");
            }
                if (c > 0) 
                {
                    Console.WriteLine("Skaiciu teigiamas");
                }
                if (c < 0) 
                {
                    Console.WriteLine("skaicius neigiamas");
                }
            }
            
            }

        }
    
