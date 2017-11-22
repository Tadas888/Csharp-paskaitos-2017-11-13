using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Skaicius teigiamas");

            }
            else if (a < 0)
            {
                Console.WriteLine("Skaicius neigiamas");

            }
            else
            {
                Console.WriteLine("Skaicius lygus nuliui");

            }
        }
    }
}
