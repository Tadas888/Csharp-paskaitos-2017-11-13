using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Ieva");
            programa.Pasisveikinti("ieva, Jaksaitye");
            programa.Atsisveikinti();
            Statinismetodas();
            var sumosatsakymas = programa.Suma(4, 5);
            Console.WriteLine(sumosatsakymas);
            Console.WriteLine(programa.Suma(7, 5));
            var skirtumoats = programa.Skirtumas(7, 5);
            Console.WriteLine(skirtumoats);
            Console.WriteLine(programa.Skirtumas(8, 5));
            var dalmats = programa.dalmuo(9, 3);
            Console.WriteLine(dalmats);
            Console.WriteLine(programa.dalmuo(9, 3));
            var sanats = programa.sandauga(5, 2);
            Console.WriteLine(sanats);
            Console.WriteLine(programa.sandauga(5, 2));

            Console.WriteLine("iveskite du skaicius: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var dalmuo = programa.dalmuo(pirmas, antras);
            var sandauga = programa.sandauga(pirmas, antras);

            Console.WriteLine("{0} + {1} = {2}" , pirmas, antras, suma);
            Console.WriteLine("{0} - {1} = {2}" , pirmas, antras, skirtumas);
            Console.WriteLine("{0} / {1} = {2}" , pirmas, antras, dalmuo);
            Console.WriteLine("{0} * {1} = {2}" , pirmas, antras, sandauga);






        }

        public void Pasisveikinti()
        {
            Console.WriteLine("labas krabas");
        }
        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("labas" + vardas);
        }

        public void Pasisveikinti(string vardas, string pavarde)

        {
            Console.WriteLine("labas,  " + vardas + "  " + pavarde);
        }


        public void Atsisveikinti()
        {
            Console.WriteLine("Viso gero");

        }
       
       




        public static void Statinismetodas()
        {
            Console.WriteLine("Statinis metodas");
        }

        public int Suma(int a, int b)
        {
            return a + b; 
        }

        public int Skirtumas(int a, int b)
        {
            return a - b; 
        }

        public double dalmuo(int a, int b)
        {
            return (double) a / b;
        }

        public int sandauga(int a, int b)
        {
            return a * b; 
        }

        }
        }
    
    

