using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            int number1, number2, temp;  //temp temporaria
            Console.WriteLine("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("\nFirst Number : " + number1);
            Console.WriteLine("\nSecond Number : " + number2);










            int num1, num2, tempoH;

            Console.WriteLine("\nColoque o primeiro número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nColoque o segundo número");
            num2 = int.Parse(Console.ReadLine());
            tempoH = num1;
            num1 = num2;
            num2 = tempoH;

            Console.WriteLine("Após o programa mudar a ordem: ");
            Console.WriteLine("Novo número 1 é: " + num1);
            Console.WriteLine("Novo número 2 é: " + num2);



            // Exercicios com mudança de ordem precisam de um auxiliador




            Console.ReadLine();
        }
    }
}
