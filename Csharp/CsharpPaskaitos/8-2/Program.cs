using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite gyvuno rusi:");
            var gyvunas = Console.ReadLine();

            switch (gyvunas)
            {
                case  ("suo"):
                    Console.WriteLine("ivestas gyvunas yra suo");
                    break;
                case  ("kate"):
                    Console.WriteLine("Ivestas gyvunas yra kate");
                    break;
                case  ("ziurkenas"):
                    Console.WriteLine("ivestas gyvunas yra ziurkenas");
                    break;
                case ("triusis"):
                    Console.WriteLine("ivestas gyvunas yra triusis");
                    break;
                case ("papuga"):
                    Console.WriteLine("ivestas gyvunas yra papuga");
                    break;
            }
        }
    }
}
