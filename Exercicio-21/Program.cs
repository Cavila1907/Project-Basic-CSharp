using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse projeto!!!");


            int x, y;
            int result;


            Console.WriteLine("\nInsira o primeiro número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo número: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));







            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }
    }
}
