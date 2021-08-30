using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL_CLASES_ALEIDA
{
    class Program
    {
        static void Main(string[] args)
        {
            double precioVenta;
            double costoFabrica;
            string nombreVehiculo;
            string opc;
            string clasico;
            bool clasic;
            double tone;

            Turismo tur = new Turismo();
            Camion cam = new Camion();

            //creamos el menu

            do
            {
                Console.WriteLine("1-crear turismo\n2crear camion\n3mostrar turismo\n4mostrar camion\n5salir");
                opc = Console.ReadLine();
                Console.Clear();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Introduce su precio de venta");
                        precioVenta = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce su precio de fabrica");
                        costoFabrica = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce su nombre");
                        nombreVehiculo = Console.ReadLine();
                        Console.WriteLine("¿Es un clasico?");
                        clasico = Console.ReadLine();
                        tur = new Turismo(precioVenta, costoFabrica, nombreVehiculo);
                        if (clasico == "s" || clasico == "S")
                        {
                            clasic = true;
                            tur.esunClasico(clasic);
                        }
                        else
                        {
                            if (clasico == "n" || clasico == "N")
                            {
                                clasic = false;
                                tur.esunClasico(clasic);
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Introduce su precio de venta");
                        precioVenta = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce su precio de fabrica");
                        costoFabrica = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce su nombre");
                        nombreVehiculo = Console.ReadLine();
                        Console.WriteLine("Introduzca las toneladas");
                        tone = double.Parse(Console.ReadLine());
                        cam = new Camion(precioVenta, costoFabrica, nombreVehiculo);
                        cam.enseniaToneladas(tone);
                        break;
                    case "3":
                        Console.Clear();
                        tur.imprimirTurismo();
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        cam.imprimirCamion();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Esta saliendo ");
                        Console.ReadKey();
                        break;


                }
            } while (opc != "5");
        }
    }
}
