using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresar10Numero
{ 

    public class Program
    {
       

        static void Main(string[] args)
        {
            decimal  numero ;
            int i = 1;
            decimal suma = 0;
          
            
            Console.WriteLine($"ingrese el numero {i}");
            numero = Convert.ToDecimal (Console.ReadLine());

            for (  i = 2; i <=10; i++)
            {
              Console.WriteLine($"ingrese el numero: {i} ");
                numero = Convert.ToDecimal(Console.ReadLine());
                if (i > 5)
                {
                    suma += numero;
                }

            }

           Console.WriteLine($" esta es la suma de los 5 ultimo numero: {suma}");
           
            
        }
    }
}
