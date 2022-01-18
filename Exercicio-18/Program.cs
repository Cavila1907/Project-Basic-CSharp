using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            int num1, num2;

            Console.WriteLine("\nInsira o primeiro inteiro: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo inteiro: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));
            





            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }
    }
}
