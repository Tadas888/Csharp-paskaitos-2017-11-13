using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> primilziai = new List<double>();
            var programa = new Program();

            programa.isvedimas(primilziai)
            Console.WriteLine(" jusu maziausias primilzis: " + programa.Maziausias(primilziai));
            Console.WriteLine(" jusu Didziausias primilzis: " + programa.Didziausias(primilziai));
            Console.WriteLine(" jusu vidutinsi primilzis: " + programa.vidutinis(primilziai));

            // kviesti metodus cia
        }
        public void ivedimas(List<double> primilziai)
        {
            Console.WriteLine("iveskite primmilzio kieki: ");
            var kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiek; i++)
            {
                Console.Write("iveskite: ");
                primilziai.Add(Convert.ToInt32(Console.ReadLine());
            }


        }
        public void isvedimas(List<double> primilziai)
        {
            foreach (var primilzis in primilziai)
            {
                Console.WriteLine(primilzis + "l");
            }
        }

        public double Maziausias(List<double> primilziai)
        {
            return primilziai.Min();
        }

        public double Didziausias(List<double> primilziai)
        {
            return primilziai.Max();
        }
        public double vidutinis(List<double> primilziai)
        {
            return primilziai.Average();
        }

    }
}
    // ivedimo metodas
    // isvedimo metodas
    //min, max, average metodai
    // rasti du didziausius


