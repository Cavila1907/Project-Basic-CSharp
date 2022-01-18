using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            int num;

            Console.WriteLine("\nDigite um número: ");
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);












            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }
    }
}
