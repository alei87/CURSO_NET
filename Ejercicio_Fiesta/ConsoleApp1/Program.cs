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
            FiestaDeGala miFiesta = new FiestaDeGala();
            Console.WriteLine("Introduzca numero de personas");
            miFiesta.numeroDePersonas =int.Parse( Console.ReadLine());
            if (miFiesta.numeroDePersonas > 12)
            {
                Console.WriteLine("Intruduzca el bono extra");
                miFiesta.BonoExtra = double.Parse(Console.ReadLine());
            }

            miFiesta.calcularCostoDeDecoracionGala()
            Console.ReadLine();
            Console.WriteLine("Introduca coste comida por persona");
            miFiesta.costoDeComidaPorPersona = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Quiere la opcion extra?");
            
            if (miFiesta.Extra == true)
            {
                double extraTotal = double.Parse(Console.ReadLine());
                miFiesta.SetOpcionExtra(extraTotal);
                Console.ReadLine();
            }
            Console.WriteLine("El costo total de la gala es");
            double TotalGala = double.Parse(Console.ReadLine());
            miFiesta.CalcularCostoGala(TotalGala);
            Console.Clear();
                


            
        }
    }
}
