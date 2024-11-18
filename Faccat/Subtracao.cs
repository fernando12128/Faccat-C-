using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Faccat
{
    internal class Subtracao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            int resultado = numero1 - numero2;

            Console.WriteLine("O Resultado da subtração é: " + resultado);
        }
    }
}
