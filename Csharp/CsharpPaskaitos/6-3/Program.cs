﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite sios dienos temperatura:");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("ziauriai salta");
             }
            else if (a < 10)
            {
                Console.WriteLine("Labai salta");

            }
            else if (a < 20)
                {
                Console.WriteLine("Salta");
            }
            else if (0 < 30)
                {
                Console.WriteLine("Normali Temperatura");
            }
            else if (0 < 40)
            {
                Console.WriteLine("karsta");
            }
            else if (0 > 40)
            {
                Console.WriteLine("visiskai degina");
            }
        }
    }
}
