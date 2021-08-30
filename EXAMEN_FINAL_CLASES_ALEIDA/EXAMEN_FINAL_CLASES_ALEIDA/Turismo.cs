using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL_CLASES_ALEIDA
{
    class Turismo:Vehículo
    {
        //su atributo propio
        bool clasico;
        string marcado;

        //creamos los contructores
        public Turismo()
        {

        }

        public Turismo( double _precioVenta, double _costoFabrica, string _nombreVehiculo, bool _clasico):base(_precioVenta, _costoFabrica, _nombreVehiculo)
        {
            this.clasico = _clasico;
        }

        public Turismo(double _precioVenta, double _costoFabrica, string _nombreVehiculo) : base(_precioVenta, _costoFabrica, _nombreVehiculo)
        {
            
        }

        public bool Pclasico
        {
            get { return Pclasico; }
            set { Pclasico = value; }
        }

        public void esunClasico(bool esclasico)
        {
            this.clasico = esclasico;
            if (this.clasico == true)
            {
                marcado = "es clasico";
            }
            else
            {
                if (this.clasico == false)
                {
                    marcado = "no es un clasico";
                }
            }
        }

        public void imprimirTurismo()
        {
            Console.WriteLine("Es un turismo, su precio es " + precioVenta + "\n" + "su nombre es " + nombreVehiculo +
                "\n" + marcado);
        }
    }
}
