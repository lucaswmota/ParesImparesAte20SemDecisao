using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImparesAte20
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite 1 para numeros impares ou 2 para numeros pares.");
            int numero = int.Parse(Console.ReadLine());

            int cont = numero;

            while (cont <=20)
            {
                Console.WriteLine(numero);
                numero += 2;
                cont += 2;
            }

            Console.ReadKey();
        }
    }
}
