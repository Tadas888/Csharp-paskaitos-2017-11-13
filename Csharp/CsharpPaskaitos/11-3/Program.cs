using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { 14.5, 18.5, 20.4, -30 };

            var zemiausia = temperaturos[0];
            var auksciausia = temperaturos[0];
            var zemiauzvidurki = temperaturos[0];
            var auksciauuzvidurki = temperaturos[0];



            foreach (var temperatura in temperaturos)
            {

                if (temperatura < zemiausia)
                {
                    zemiausia = temperatura;
                }

                if (temperatura > auksciausia)
                {
                    auksciausia = temperatura;
                }


            }
            Console.WriteLine("zemiausia temperatura" + zemiausia);
            Console.WriteLine("auksciausia temperatura" + auksciausia);
            Console.ReadLine();

            double suma = 0.0;
            var vidurkis = suma / temperaturos.Length;

            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;
            }
            Console.WriteLine("vidutine temperatura" + temperaturos);
            Console.ReadLine();

            var zemesniu_uz_vidurki_kiekis = 0;

            foreach (var temp in temperaturos)
            {
                if (temp < vidurkis)
                    zemesniu_uz_vidurki_kiekis++;
            }

            Console.WriteLine("zemesniu uz vidurki kiekis: " + zemesniu_uz_vidurki_kiekis);
            Console.ReadLine();

            var aukstesniu_uz_vidurki_kiekis = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > vidurkis)
                    aukstesniu_uz_vidurki_kiekis++;
            }

            Console.WriteLine("aukstesniu uz vidurki kiekis: " + aukstesniu_uz_vidurki_kiekis);
            Console.ReadLine();


        }
    }
}
