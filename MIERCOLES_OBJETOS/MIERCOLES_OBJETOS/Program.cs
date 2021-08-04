using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIERCOLES_OBJETOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto PR1 = new Producto();
            

            string nom = "";
            double pre = 0;
            string cat = "";
            string opcion = "";

            do
            {
                Console.WriteLine("1-Crear el Producto");
                Console.WriteLine("2-Haz un Pedido");
                Console.WriteLine("3Muestra el Total + IVA");
                Console.WriteLine("4-Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Introduce el nombre");
                        PR1.Nombre = Console.ReadLine();
                        Console.WriteLine("Introduce el precio");
                        PR1.Precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la categoria");
                        PR1.Categoria = Console.ReadLine();
                        break;

                    case "2":

                }
            }

            
        }
    }
}
