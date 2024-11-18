using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class Retangulo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do retangulo");
            float baseRet = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo");
            float alturaRet = Convert.ToSingle(Console.ReadLine());

            float resultado = baseRet * alturaRet;
            Console.WriteLine("A area do retangulo é " + resultado);
        }
    }
}
