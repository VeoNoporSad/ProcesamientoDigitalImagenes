using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINBONACCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int limite = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;
            int var = 0;

            while (true)
            {
                
                if (var <= limite)
                {
                    if (c != 0)
                    {
                        Console.Write(c + "\n");
                    }
                }
                else
                {
                    break;
                }

                c = a + b;
                a = b;
                b = c;
                var++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
