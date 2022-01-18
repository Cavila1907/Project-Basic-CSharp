using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou executando esse programa!!!");



            int multi1, multi2, multi3;
           

            Console.WriteLine("\nInsira o primeiro número: ");
            multi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o segundo número :");
            multi2= int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o terceiro número: ");
            multi3= int.Parse(Console.ReadLine());

            int result= multi1 * multi2 * multi3; //Colocar as equaçoes no FIM apos terem valor
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                        multi1, multi2, multi3, result);

            Console.WriteLine(result);









            Console.ReadLine();
        }
    }
}
