using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese inversion");
            string inversion = Console.ReadLine();
            float inversionParseado = float.Parse(inversion);
            float i = 0;
            while (i <= 12)
            {
                Console.WriteLine(i);
                float pago = inversionParseado * 2 / 100;
                float pagos = pago * i;
                float pagoss = pagos + i;
                i ++;
                Console.WriteLine("la ganncia de 12 meses es  {0}", pagos);
            }
           
            
            Console.ReadKey();

        }
    }
}
