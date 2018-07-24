using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la tabla");
            string num = Console.ReadLine();
            int numParseado = int.Parse(num);
            
            for (int i=0; i<=10; i++)
            {
                int res=numParseado * i;
                Console.WriteLine(numParseado + "*" + i + "=" +res);
            }
            
            Console.ReadKey();

        }
    }
}
