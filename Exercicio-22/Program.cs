using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse projeto!!!");

            int num;

            Console.WriteLine("\nInsira um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(resul(num));





            Console.WriteLine("Aperte enter para finalizar. . .");
            Console.ReadLine();
        }
        public static bool resul (int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
                return false;
        }


    }
}
