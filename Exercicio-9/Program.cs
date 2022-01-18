using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse projeto");


            int num1, num2, num3, num4;
            

            Console.WriteLine("Insira o primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo número:");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número:");
            num3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o quarto número:");
            num4= Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2 + num3 + num4;
            double result = (double)soma / 4; //casting


            Console.WriteLine(result);



            Console.ReadLine();

        }
    }
}
