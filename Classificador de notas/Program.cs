using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificador_de_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] notas = new double[3];
            
            Console.WriteLine("Classificador de notas");

            Console.WriteLine("Digite as as ultimas 3 notas do aluno ");
            
            
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1}");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double media =Math.Round( notas.Average(),2);
            //double media = ((notas.Sum()) / notas.Length);
            //double media = (notas[0] + notas[1] + notas[2]) / 3;

            Console.WriteLine($"A media do alunno e {media}");

            if (media > 5 || media>6 )
            {
                Console.WriteLine("O aluno foi aprovado\nMas precisa de melhorar");//Falta organizar em sequencia para o codigo ir vendo por etapas e nao pular etapas

            }
            else if (media>6)
            {
                Console.WriteLine("O aluno foi Aprovado muito bem");
            }
            else if (media > 8)
            {
                Console.WriteLine("Execlente Aluno muito bem");
            }

            else
            {
                Console.WriteLine("O aluno foi reprovado");
            }
        }
    }
}
