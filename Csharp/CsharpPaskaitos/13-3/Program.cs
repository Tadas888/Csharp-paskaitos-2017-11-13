using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> atlyginimai = new List<double>();
            var programa = new Program();
            programa.Ivedimas(atlyginimai);
            programa.Isvedimas(atlyginimai);


            Console.WriteLine("Maziausia alga: " + programa.MaziausiaAlga(atlyginimai));
            Console.WriteLine("Didziausia alga: " + programa.DidziausiaAlga(atlyginimai));
            Console.WriteLine("Vidutine alga: " + programa.VidutineAlga(atlyginimai));
            Console.WriteLine("daugiau uz vidurki " + programa.daugiauuzvidurki(atlyginimai));
            


        }

        public void Ivedimas(List<double> atlyginimai)
        {

            Console.WriteLine("kiek darbuotoju turite? ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("iveskite {0} - atlyginima: ", i + 1);
                atlyginimai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }
        public void Isvedimas(List<double> atlyginimai)
        {
            foreach (var atl in atlyginimai)
            {
                Console.Write("[{0}] ", atl);
            }

            Console.WriteLine();
        }

        public double MaziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Min();
        }
        public double DidziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Max();
        }

        public double VidutineAlga(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }

        public int daugiauuzvidurki(List<double> atlyginimai)
        {
            foreach (var atlyginimas in atlyginimai)
            {
                var vidurkis = VidutineAlga(atlyginimai);
                var kiekis = 0;
                foreach (var atlyginimas in atlyginimai)
                {

                }
                if (atlyginimas > vidurkis)
                {
                    kiekis++;
                }
                return kiekis;
            }


            public int KiekdaugiauuzX(List<double> atlyginimai, double daugiauuz)
            {
                var kiekis = 0;
                foreach (var atlyg in atlyginimai)
                {
                    if (atlyg > daugiauuz) ;
                    {
                        daugiauuz++;
                    }

                    // 15.1 uzduotis.
                }
            }
        }
    }
}
            
            
        
    

