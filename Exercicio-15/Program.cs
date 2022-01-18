using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");

            Console.WriteLine(remove_caracter("w3resource", 1));
            Console.WriteLine(remove_caracter("w3resource", 9));
            Console.WriteLine(remove_caracter("w3resource", 0));

            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }




        public static string remove_caracter(string str, int n)
        {
                return str.Remove(n, 1);
        }


            

        
    }
}
