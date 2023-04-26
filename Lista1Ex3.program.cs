using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis:
            double d, h, a;

            //Entrada dos dados:
            Console.Write("Digite o valor da diagonal do quadrado: ");
            d=double.Parse(Console.ReadLine());
            
            //Calculos referentes:
            a = (d / Math.Sqrt(2));
            h = a * a;
            Console.WriteLine("A área do quadrado de diagonal {0} é {1}", d, h);
        }
    }
}
