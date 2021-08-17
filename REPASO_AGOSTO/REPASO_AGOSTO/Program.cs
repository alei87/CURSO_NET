using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO_AGOSTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();

            Console.WriteLine("Introduce el nombre del cliente");
            cli.Pnombres = Console.ReadLine();
            Console.WriteLine("Introduce los apellidos del cliente");
            cli.Papellidos = Console.ReadLine();
            Console.WriteLine("Introduce el documento");
            cli.Pdocumento = Console.ReadLine();
            Console.WriteLine("Introduce el tipode contrato");
            cli.Ptipo = Console.ReadLine();
            cli.generarCodigo();
            Console.WriteLine("Elcodigo del cliente es: "+this.P);
          
        }
    }
}
