using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3_side16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input "decimaltal"
            Console.WriteLine("Indtast decimaltal");
            decimal decimaltal = decimal.Parse(Console.ReadLine());

            //Input bliver rundet op til de nærmeste hundreder via "Math.Ceiling"
            decimaltal = Math.Round(decimaltal / 100) * 100;

            //Udskrivning af "decimaltal" + tekst
            Console.WriteLine(decimaltal + " Tallet bliver rundet op til de nærmeste hundreder");

            //Slut
            Console.ReadKey();
        }
    }
}
