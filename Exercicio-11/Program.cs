using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            int idade;
            

            Console.WriteLine("\nDigite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());


            if (idade <= 30)
            {
                Console.WriteLine("Você parece ter mais de " + idade + " anos!!!");

            }
            else
            {
                Console.WriteLine("Você parece ter menos de " + idade + " anos!!!");
            }


            











            Console.WriteLine("Aperte enter para finalizar...");
            Console.ReadLine();
        }
    }
}
