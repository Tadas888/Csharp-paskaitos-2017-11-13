using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 3, 9, 8, 7, 10 };
            var geriausias = pazymiai[0];
            var desimt = 0;
            var neigiamas = 0;
            

            foreach (var pazymys in pazymiai)
            {
                if (geriausias > pazymys)
                {
                    geriausias = pazymys;
                }
                if (10 == pazymys )
                {
                    desimt++;
                }
                if (4 > pazymys )
                {
                    neigiamas++;
                }

                double suma = 0.0;
            }

                    

        }
    }
}
