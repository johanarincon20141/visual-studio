using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE HORAS TRBAJADAS");

            String hora = Console.ReadLine();
            int horaParseado = int.Parse(hora);
            if (horaParseado <= 40)
            {
                Console.WriteLine(" el pago es $ {0}", horaParseado * 16);

            }

           else
            {
                int extras = horaParseado - 40;
                int horaextra = extras * 20;
                int horatrabajada = (40 * 16) + horaextra;
                Console.WriteLine("el pago es $ {0}", horatrabajada);
            }
            Console.ReadKey();

        }
    }
}
