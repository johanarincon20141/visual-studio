using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese numero");
            String a=Console.ReadLine();
            int aParseado = int.Parse(a);

            Console.WriteLine("ingrese numero");
           string b=Console.ReadLine();
            int bParseado = int.Parse(b);

            Console.WriteLine("ingrese numero");
            string c = Console.ReadLine();
            int cParseado = int.Parse(c);

            if ((aParseado >bParseado && aParseado<cParseado) && (aParseado < bParseado && aParseado > cParseado))
            {
                Console.WriteLine("el numero menor es {0}", a);
            }
            else if ((bParseado > aParseado && bParseado < cParseado) || (bParseado < aParseado && bParseado > cParseado))
            {
                Console.WriteLine("el numero menor es {0}", b);
            }
            else if (cParseado > aParseado && cParseado < bParseado || cParseado <aParseado && cParseado > bParseado)
            {
                Console.WriteLine("el numero menor es {0}", c);
            }

            Console.ReadKey();


        }
    }
}
