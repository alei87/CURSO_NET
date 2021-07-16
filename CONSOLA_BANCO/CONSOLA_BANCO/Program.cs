using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA_BANCO
{
    //Ejercicio para gestionar las cuentas de un banco
    //Se pide crear una clase tipo Cuenta para gestionar ingresos y gastos
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cnt = new Cuenta();
            string opcion = "";

            do
            {
                Console.WriteLine("1-Crear cuenta");
                Console.WriteLine("2-Depositar una cantidad");
                Console.WriteLine("3-Retirar una cantidad");
                Console.WriteLine("4-Consultar Saldo");
                Console.WriteLine("5-Salir de la App");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Introduce el nombre del usuario");
                        cnt.PNombre = Console.ReadLine();
                        Console.WriteLine("Introduce el Número de Cuenta");
                        cnt.PNumCuenta = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el saldo");
                        cnt.PSaldo = int.Parse(Console.ReadLine());
                        break;

                    case "2":
                        Console.WriteLine("¿Que cantidad quieres ingresar");
                        int deposito = int.Parse(Console.ReadLine());
                        cnt.Depositar(deposito);
                        Console.ReadLine();
                        Console.WriteLine("Tu saldo es:" + cnt.PSaldo);
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("¿Que cantidad quieres retirar?");
                        int retiro = int.Parse(Console.ReadLine());
                        cnt.retirar(retiro);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        cnt.Consultar();
                        Console.ReadLine();
                        Console.Clear();
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
            } while (opcion != "5");
            
        }
    }
}
