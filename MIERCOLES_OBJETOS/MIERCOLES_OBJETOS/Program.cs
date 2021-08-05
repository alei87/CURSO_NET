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
            var almacen = new List<Producto>();
            Producto PR1 = new Producto();
            

            string nombre = "";
            double precio = 0;
            string categoria = "";
            double total = 0;
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
                        PR1.Nombre= Console.ReadLine();
                        Console.WriteLine("Introduce el precio");
                        PR1.Precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la categoria");
                        PR1.Categoria = Console.ReadLine();
                        Producto p3 = new Producto(nombre, precio, categoria);
                        almacen.Add(PR1);
                        PR1.Mostrar();
                        break;

                    case "2":
                        int num = 0;  //para recorrer el array almacen
                        foreach (var x in almacen)
                        {
                            x.Mostrar();
                            Console.WriteLine("¿Cuanta cantidad desea?");
                            num = int.Parse(Console.ReadLine());
                            total = (x.Precio * num) + total;
                            Console.WriteLine();
                        }
                        
                        break;
                    case "3":
                        Console.WriteLine("El total es: "+total.ToString());
                        Console.WriteLine("El IVA es: " + (total*0.21).ToString());
                        Console.WriteLine("El total con IVA es: " +( total*1.21).ToString());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Has introducido una opcion erronea");
                        Console.ReadLine();
                        break;


                }
            } while (opcion != "4");

            

            
        }
    }
}
