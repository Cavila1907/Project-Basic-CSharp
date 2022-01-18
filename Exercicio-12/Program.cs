using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estou executando esse projeto!!!");

            int num;

            Console.WriteLine("\nInsira o número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();


            Console.Write(num);  //Apenas Write não pula uma linha
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.WriteLine();


            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine();

            Console.Write(num);  //Apenas Write não pula uma linha
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.WriteLine();

            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(); //Para que haja quebra de linha





            Console.WriteLine("Aperte enter para finalizar...");
            Console.ReadLine();
        }
    }
}
