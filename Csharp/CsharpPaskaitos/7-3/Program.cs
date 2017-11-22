using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(" a didziausias");
            }
            else if (b > a && b > c)
            { 
                Console.WriteLine(" b didziausias");
            }
            else
            {
                Console.WriteLine("c didziausias");
              }
        }
    }
}
