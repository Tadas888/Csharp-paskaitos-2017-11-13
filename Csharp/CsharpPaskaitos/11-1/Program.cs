using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 7, 3, 6, 8, 9 };

            Console.WriteLine(pazymiai[0]);
            Console.WriteLine(pazymiai[1]);
            Console.WriteLine(pazymiai[2]);
            Console.WriteLine(pazymiai[3]);
            Console.WriteLine(pazymiai[4]);

            string[] markes =new string[3];
            markes[0] = "audi";
            markes[1] = "lada";
            markes[2] = "kamaz";

            Console.WriteLine(markes[0]);
            Console.WriteLine(markes[1]);
            Console.WriteLine(markes[2]);


            string[] kompiuteriai = new string[3];
            kompiuteriai[0] = "dell";
            kompiuteriai[2] = "asus";
            kompiuteriai[3] = "toshiba";

            Console.WriteLine("masyvu dydziai");
            Console.WriteLine("pazymiai" + pazymiai.Length);
            Console.WriteLine("markes");
            Console.WriteLine("markes" + markes.Length);
            Console.WriteLine("kompiuteriai");
            Console.WriteLine("kompiuteriai" + kompiuteriai.Length);

            Console.WriteLine("pazymiu masyvo");
            Console.WriteLine("pirma reiksme:" + pazymiai.First());
            Console.WriteLine("paskutine reiksme" + pazymiai.Last());
            






        }
    }
}
