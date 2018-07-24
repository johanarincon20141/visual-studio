using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de carro y el terreno el mismo");
            string valor= Console.ReadLine();
            float valorParseado = float.Parse(valor);

            float carro = valorParseado*10/100;
            float terreno = valorParseado*30/100;
            Console.WriteLine("el valor del carro es {0} $", carro * 3);
            Console.WriteLine("el valor del carro es {0}$", terreno * 3);
            Console.WriteLine("se recomida adquirir el vehiculo ");
            Console.ReadKey();



        }
    }
}
