using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek darbuotojas spes iskepti kepalu per Valanda?");
            var kepal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek darbuotoju turi kepykla?");
            var darb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vieno kepalo savikaina?");
            var savik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pardavimo kaina");
            var pardav = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek uzsakymu kepykla turi siandien?");
            var uzsak = Convert.ToInt32(Console.ReadLine());
           
            //Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
            var perdiena = 8 * darb * kepal;
            Console.WriteLine("Per diena darbuotojas spes iskepti  " + perdiena);

            //Apskaičiuoti visų kepalų savikainą, gautas pajamas pardavus ir iš to gauto pelno dalį.

            var savikaina = kepal * savik;
            var pajamos = savik * pardav;
            var pelnas = pardav - savik + perdiena;
            Console.WriteLine("pelnas " + pelnas);

            //Patikrinti ar kepykla spės iškepti visus tos dienos užsakymus. 
            //Jei ne, suskaičiuoti kiek kepalų nespės iškepti.

            if (kepal >= uzsak)
            {
                Console.Write("uzsakymai bus ivykdyti");
            }
            else 
                    {
                Console.WriteLine("uzsakymai nebus ivykdyti, trusksta " + (kepal - uzsak));
            }



        }
    }
}
