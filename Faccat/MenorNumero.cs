using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class MenorNumero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            int resultado = numero1 - 1;
            Console.WriteLine("O numero antecessor é " + resultado);
        }
    }
}
