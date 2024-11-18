using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class CalculoFabrica
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual o  custo de fabrica?");
            double custoFabrica = Convert.ToSingle(Console.ReadLine());

            double distribuidor = custoFabrica * (28 / 100.0);
            double imposto = custoFabrica * (45 / 100.0);
            double precoFinal = distribuidor + imposto + custoFabrica;

            Console.WriteLine("O Preço final do produto é "+ precoFinal);
        }
    }
}
