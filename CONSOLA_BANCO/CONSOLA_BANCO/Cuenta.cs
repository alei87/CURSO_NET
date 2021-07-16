using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA_BANCO
{
    public class Cuenta
    {
        private string nombreCliente;
        private int numCuenta;
        private double saldo;

        public Cuenta() //constructor sin parametros
        {
        }

        public Cuenta(string nombreCliente, int numCuenta, double saldo)
        {  
        }
        public string PNombre

        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public int PNumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

        public double PSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Consultar()
        {
            Console.WriteLine("El nombre del cliente es: " + this.nombreCliente + "el número de cuenta es: " + this.numCuenta + "y su saldo es: ");
        }

        public void Depositar()
        {
            int deposito = 0;

            PSaldo = PSaldo + deposito;
        }

        public void retirar()
        {
            int retiro = 0;

            if (retiro > saldo)
            {
                Console.WriteLine("No se puede retirar esta cantidad");
            }
            else
            {
                PSaldo = PSaldo - retiro;
            }

        }



    }
}
