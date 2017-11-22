using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite, bet koki simbolį");
            var a = Console.ReadLine();        
            Console.WriteLine("{0}{0}{0}",a);
            Console.WriteLine("{0}{0}{0}",a);
            Console.WriteLine("{0}{0}{0}",a);
            Console.ReadLine();
        }
    }
}
