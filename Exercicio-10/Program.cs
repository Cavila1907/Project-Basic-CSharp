using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, eu estou executando o programa Exercicio 10!!!");

            int num1, num2, num3;

            Console.WriteLine("\nInsira o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira o terceiro número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((num1 + num2) * num3);
            Console.WriteLine(num1*num2+num2*num3);








            Console.WriteLine("Aperte ente para finalizar...");
            Console.ReadLine();
        }
    }
}
