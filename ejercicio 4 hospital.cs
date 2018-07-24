using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de inversion para el hospital");
            string valor= Console.ReadLine();
            float valorParseado = float.Parse(valor);

            float g=valorParseado*40/100;
            float t=valorParseado*30/100;
            float p=valorParseado*30/100;

            Console.WriteLine(" el valor que le corresponde al Ginecologia  es $ {0}", g);
            Console.WriteLine(" el valor que le corresponde al Traumatologia  es ${0}", t);
            Console.WriteLine(" el valor que le corresponde al Pediatria  es $ {0}", p);
            Console.ReadKey();










        }
    }
}
