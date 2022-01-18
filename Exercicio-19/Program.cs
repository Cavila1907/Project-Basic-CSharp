using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            int num1, num2;

            Console.WriteLine(Triplo(2, 2));
            Console.WriteLine(Triplo(15, 2));
            Console.WriteLine(Triplo(-7, 2));











            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }

        public static int Triplo(int num1, int num2)
        {
            return num1 == num2 ? (num1 + num2) * 3 : num1 + num2;
        }

    }
}
