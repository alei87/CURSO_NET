using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Clases_Final
{
        public class Vehículo
    {
        //se declaran los atributos
        //una varible empieza con _es privada
        protected int ID;
        protected string marca;
        protected string modelo;
        protected int KM;
        protected double precio;

        //constructor por defecto para poder generar una clase por defecto y acceder a sus propiedades
        public Vehículo()
        {
           
        }

        //constructor sobrecargado para pasarle parametros
        public Vehículo(int ID, string marca, string modelo, int KM, double precio)
        {
            this.ID = ID;
            this.marca = marca;
            this.modelo = modelo;
            this.KM = KM;
            this.precio = precio;
        }

        public int PID
        {
            get { return ID; }
            set { ID = value; }

        }

        public string Pmarca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        public string Pmodelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int PKM
        {
            get { return KM; }
            set { KM = value; }
        }
        
        public double Pprecio
        {
            get { return precio; }
            set { precio = value; }
               
        }

        public void Imprimir()
        {
            Console.WriteLine();
        }
    }
}
