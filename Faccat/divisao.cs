using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class divisao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(numero2);

            int resultado = numero1 / numero2;
            Console.WriteLine("O Resultado é "+resultado);
        }
    }
}
