using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faccat
{
    internal class mediaAluno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a primeira nota do aluno?");
            byte nota1 = Convert.ToByte(Console.ReadLine());
            int n1 = nota1 * 2;
            Console.WriteLine("Qual a primeira nota do aluno?");
            byte nota2 = Convert.ToByte(Console.ReadLine());
            int n2 = nota2 * 3;
            Console.WriteLine("Qual a primeira nota do aluno?");
            byte nota3 = Convert.ToByte(Console.ReadLine());
            int n3 = nota3 * 5;
            int mediaFinal = (n1 + n2 + n3) / 10;
            Console.WriteLine("A nota  total do Aluno é " + mediaFinal);

        }
    }
}
