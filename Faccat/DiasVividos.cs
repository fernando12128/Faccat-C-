using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class DiasVividos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade? ");
            byte idade = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Quantos meses do seu ultimo aniversario? ");
            byte mes = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Digite qual foi o seu ultimo mesversario? ");
            byte diaVersario = Convert.ToByte(Console.ReadLine());

            int totalDias = (idade * 365) + (mes * 30) + diaVersario ;

            Console.WriteLine("A Quantidade de Dias vividas é: " + totalDias);
        }
    }
}
