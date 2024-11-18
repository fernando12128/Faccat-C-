using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class FahrenheitParaCelcius
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quanto Fahrenheit está fazendo?");
            int fahrenheit = Convert.ToInt16(Console.ReadLine());

            double celcius = (fahrenheit - 32) * (5.0 / 9.0);
            Console.WriteLine("Esta fazendo " + celcius + "C");
        }
    }
}
