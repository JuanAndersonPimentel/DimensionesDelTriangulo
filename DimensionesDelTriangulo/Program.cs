using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionesDelTriangulo
{
    public class Program
    {
        static void Main(string[] args)
        {
            const double arealimite = 50.0;
            int cantidadtriangulo = 0;
            int triangulosGrandes = 0;
            double area = 0;
            double basetriangulo = 0;
            double alturatriangulo = 0;

            try
            {
                Console.WriteLine("ingrese la cantidad de triangulos:");
                cantidadtriangulo = Convert.ToInt32(Console.ReadLine());

                triangulosGrandes = 0;

                for ( int i = 0; i < cantidadtriangulo; i++)
                {
                    Console.WriteLine($"ingrese la base del triangulo {i + 1}: ");
                    basetriangulo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"ingrese la altura del triangulo {i + 1}:");
                    alturatriangulo = Convert.ToInt32(Console.ReadLine());
                }
                area = (basetriangulo * alturatriangulo) / 2;

                if (area > arealimite)
                { 
                    triangulosGrandes++;
                }
                
                Console.WriteLine($"el area del triangulo {i + 1} es: {area}");

                Console.WriteLine($"la cantidad de triangulos con area mayor a {arealimite} es: {triangulosGrandes}");

            }
            catch (Exception)
            {

                Console.WriteLine("error: ingreso un valor no valido. por favor, ingrese numeros.");
            }

        }
    }
}
