using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Marke = "Audi";
            var Modelis = "a4";
            var Metai = 2007;
            var Rida = 250000;

                Console.WriteLine("Automobilis {0} {1} ( {2} m.) ", Marke, Modelis, Metai );
            Console.WriteLine("automoblis nuvaziaves {0}", Rida);
            Console.ReadLine();
        }
    }
}
