using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class RevendedoraCarros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salario fixo do mes?");
            double salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Quantos carros você vendeu esse mes?");
            byte carrosVendidos = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Qual o valor da comissão para cada carro vendido?");
            double comissao = Convert.ToDouble(Console.ReadLine());

            double vendasTotal = carrosVendidos *  comissao;
            double cinco = (5/100.0) * vendasTotal;

            double valorTotal = salario + vendasTotal + cinco;
            Console.WriteLine("Você vendeu " + carrosVendidos + " carros o total de carro vendido foi "+ vendasTotal+ " O seu salario final ficou "+valorTotal);
        }
    }
}
