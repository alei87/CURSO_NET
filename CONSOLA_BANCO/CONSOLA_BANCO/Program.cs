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
                Console.WriteLine("Retirar una cantidad");
                Console.WriteLine("4-Consultar Saldo");
                Console.WriteLine("5-Salir de la App");
                opcion = Console.ReadLine();
            }
            
        }
    }
}
