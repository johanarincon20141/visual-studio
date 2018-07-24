using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese inversion 1");
            String inv1 = Console.ReadLine();
            int inv1Parseado = int.Parse(inv1);
            
            Console.WriteLine("Ingrese inversion 1");
            String inv2 = Console.ReadLine();
            int inv2Parseado = int.Parse(inv2);

            Console.WriteLine("Ingrese inversion 3");
            String inv3 = Console.ReadLine();
            float inv3Parseado = float.Parse(inv3);

            float total = inv1Parseado + inv2Parseado + inv3Parseado;
            float in1 = inv1Parseado*100/total;
            float in2= inv2Parseado * 100 / total;
            float in3= inv3Parseado * 100 / total;
            Console.WriteLine("el valor del inversionista 1 corresponde % {0}", in1 );
            Console.WriteLine("el valor del inversionista 2 corresponde % {0}", in2 );
            Console.WriteLine("el valor del inversionista 3 corresponde % {0}", in3);
            Console.ReadKey();

        }
    }
}
