using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            Console.WriteLine(resul(13,40));
            Console.WriteLine(resul(50, 21));
            Console.WriteLine(resul(0, 23));










            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();

        }
        public static int resul(int a, int b)
        {
            if(a > b)
            {
                return (a - b) * 2;

            }
            return b - a;
        }
    }
}
