using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas21
{
    class CustomClassName
    {
        static void Main(string[] args)
        {
            /* Ovo je moj prvi program
             * viselinijski komentar */
            Console.WriteLine("Zdravo svete.");

            int counter;
            counter = 21;
            counter = counter + 1;

            bool IsItTrue = false;

            Console.WriteLine(counter);

            double d = 5673.74;
            int i;

            // Cast double to int
            i = (int)d * 2;
            
            Console.WriteLine(i);
            d = i;
            
            string dec;
            
            dec = Convert.ToString(d);

            Console.WriteLine(dec + "-dodajem");

            // Ovo je jednolinijski komentar
            Console.ReadKey();
        }
    }
}
