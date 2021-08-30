using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL_CLASES_ALEIDA2
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos un repartidor y llamamos a sus metodos y a sus propiedades
            //utilizamos un constructor
            repartidorGlovo rep1 = new repartidorGlovo();
            rep1.Pnombre = "Pepe";
            rep1.Pempresa = "McDonald's";
            rep1.Ppropinas = 200;
            rep1.Pdesplazamientos = 3;
            rep1.PprecioDesplazamiento = 20;
            rep1.imprimir();
            double sueldo = double.Parse(Console.ReadLine());
            rep1.ImprimeSueldo(sueldo);
 
            
            Console.ReadLine();
           
            Console.ReadLine();

        }
    }
}
