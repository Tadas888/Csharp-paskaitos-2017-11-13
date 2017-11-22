using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Stacionarus kompiuteris");
            Console.WriteLine("2 - Nesiojamas kompiuteris");
            Console.WriteLine("3 - Plansete");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)

            {
                case 1:
                    Console.WriteLine("Stacionarus Kompiuteris, turi savo vieta");
                    break;
                case 2:
                    Console.WriteLine("Nesiojamas Kompiuteris, galima naudotis bet kur");
                    break;
                case 3:
                    Console.WriteLine("Plansete, galima greitai ir visur naudotis");
                    break;

                    default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;


            }
        }
    }
}
