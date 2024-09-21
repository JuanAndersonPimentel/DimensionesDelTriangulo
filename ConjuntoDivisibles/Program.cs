using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntoDivisibles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int contadorDivisibles = 0;
            int numero = 0;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"ingrese el numero {i + 1}:");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                if (numero % 3 == 0 || numero % 5 == 0)
                {
                    contadorDivisibles++;
                }
                Console.WriteLine($"la cantidad de numeros divisibles por 3 o por 5 es: {contadorDivisibles}");

            }
            catch (Exception)
            {
                Console.WriteLine("error: ingreso un valor no valido. por favor, ingrese numeros enteros: ");
               
            }
            
        }
    }
}
