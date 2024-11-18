using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class Eleitores
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero total de eleitores: ");
            int total = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos brancos: ");
            int vtBrancos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o numero de votos nulos: ");
            int vtNulos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o numero de eletirores VALIDOS: ");
            int validos = Convert.ToInt16(Console.ReadLine());

            int totalBrancos = ( total / vtBrancos) * 100;
            int totalNulos = total / vtNulos * 100;
            int totalValidos = total / validos * 100;

          
            Console.WriteLine("A porcentagem de votos brancos é "+ totalBrancos + " de " + vtBrancos);
        }
    }
}
