using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de numeros");
            string n = Console.ReadLine();
            int nParseado = int.Parse(n);

            for (int i = 0; i < nParseado; i++)
            {
                Console.WriteLine("INGRESE NUMERO");
                string nume = Console.ReadLine();
                int numeParseado = int.Parse(nume);
            
            if (numeParseado == 0) 

                    nParseado = numeParseado;
                
                else if (numeParseado < nParseado)
                {
                    nParseado = numeParseado;
                }

                Console.WriteLine("numero menor es {0}", n);
                Console.ReadKey();
            }

        }
    }
