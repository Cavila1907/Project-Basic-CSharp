using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse projeto!!!");

            double temp, kelvinT, fahrenheitT;

            Console.WriteLine("\nInsira a temperatura em Celsius: ");
            temp = Convert.ToDouble(Console.ReadLine());

            kelvinT = temp + 273;
            fahrenheitT = temp * 1.8 + 32;



            Console.WriteLine(kelvinT);
            Console.WriteLine(fahrenheitT);





            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }
    }
}
