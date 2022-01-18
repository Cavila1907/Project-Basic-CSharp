using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá estou executando esse programa!!!");

            int num1, num2;

            Console.WriteLine("\nInsira o valor do primeiro número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o valor do segundo número:");
            num2= int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1- num2);
            Console.WriteLine(num1 *num2);
            Console.WriteLine(num1 /num2);




            Console.ReadLine();
        }
    }
}
