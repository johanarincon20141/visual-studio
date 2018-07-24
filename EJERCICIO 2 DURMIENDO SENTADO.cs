using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese los minutos que desea consultar");
            String minutos = Console.ReadLine();
            float minutosParseado = float.Parse(minutos);

            Console.WriteLine("Selecione 1 acostado y 2 Durmiendo");
            String opcion = Console.ReadLine();
            int opcionParseado = int.Parse(opcion);

           
            if (opcionParseado==1)
            {
                float d= minutosParseado* 108;
                Console.WriteLine("los minutos durmiendo son¨: {0}",d);
            }

         
            else {
            float s= minutosParseado* 166;

                Console.WriteLine(" Los mintos acostado son: {0}", s);
            }
           

            Console.ReadKey();




        }
    }
}
