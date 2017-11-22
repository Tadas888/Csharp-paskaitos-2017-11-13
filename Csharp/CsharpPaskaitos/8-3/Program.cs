using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - kava");
            Console.WriteLine("2 - arbata");
            Console.WriteLine("3 - vanduo");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("jus pasirinkote kava");
                    break;
                case 2:
                    Console.WriteLine("jus pasirinkote arbata");
                    break;
                case 3:
                    Console.WriteLine("jus pasirinkote vandeni ");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }

        }
    }
}
