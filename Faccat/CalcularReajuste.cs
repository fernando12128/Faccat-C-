using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class CalcularReajuste
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salario  atual?");
            int salarioAtual = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Quantos porcentos vai ser o reajuste salarial?");
            int reajuste = Convert.ToInt16(Console.ReadLine());

            double calculo = salarioAtual * (reajuste / 100.0);
            double novoSalario = calculo + salarioAtual;
            
            Console.WriteLine("O Seu Salario atual é " + novoSalario);
        }
    }
}
