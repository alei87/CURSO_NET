using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Clases_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = "";
            string air = "";
            string sid = "";
            bool aire;
            bool carro;

            Coche Coc = new Coche( );
            Moto Mot = new Moto();


            do
            {
                Console.WriteLine("1-Crear un coche");
                Console.WriteLine("2-Crear una moto");
                Console.WriteLine("3-Listar datos coche");
                Console.WriteLine("4-Listar datos moto");
                Console.WriteLine("5-Salir");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Intrtoduce el Id del coche");
                        Coc.PID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la marca");
                        Coc.Pmarca = Console.ReadLine();
                        Console.WriteLine("Introduce el modelo");
                        Coc.Pmodelo = Console.ReadLine();
                        Console.WriteLine("Introduce los KM");
                        Coc.PKM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el precio");
                        Coc.Pprecio = double.Parse(Console.ReadLine());
                        Console.WriteLine("¿Tiene airbag?");
                        air = (Console.ReadLine());
                        if (air == "s")
                        {
                            aire = true;
                            Coc.TieneAirbag(aire);
                        }
                        else
                        {
                            if (air == "n")
                            {
                                aire = false;
                                Coc.TieneAirbag(aire);
                            }
                        }
                            
                        Coc.ImprimirCoche();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Intrtoduce el Id de la moto");
                        Mot.PID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la marca");
                        Mot.Pmarca = Console.ReadLine();
                        Console.WriteLine("Introduce el modelo");
                        Mot.Pmodelo = Console.ReadLine();
                        Console.WriteLine("Introduce los KM");
                        Mot.PKM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el precio");
                        Mot.Pprecio = double.Parse(Console.ReadLine());
                        Console.WriteLine("¿Tiene sidecar?");
                        sid = (Console.ReadLine());
                        if (sid == "s") 
                        {
                            carro = true;
                            Mot.TieneSidecar(carro);
                        }
                        else
                        {
                            if (sid == "n")
                            {
                                carro = false;
                                Mot.TieneSidecar(carro);
                            }
                        }
                           
                        Mot.ImprimirMoto();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Coc.ImprimirCoche();
                        Console.ReadKey();

                        break;
                    case "4":
                        Console.Clear();
                        Mot.ImprimirMoto();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("saliendo");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Has introducido una opcion erronea");
                        Console.ReadLine();
                        break;

                }
            } while (opc != "5");


        }
    }
}
