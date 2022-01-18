using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            string str;
            int l = 0;

            Console.WriteLine("\nInsira uma string: ");
            str = Console.ReadLine();

            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);


            }




                Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }
    }
}
