using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + b + c);
            Console.WriteLine(a - b - c);
            Console.WriteLine(a * b * c);
            Console.WriteLine(a / b / c);
            Console.ReadLine();
        }
    }
}
