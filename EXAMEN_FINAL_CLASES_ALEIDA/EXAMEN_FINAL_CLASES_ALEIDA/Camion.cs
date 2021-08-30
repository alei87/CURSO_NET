using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL_CLASES_ALEIDA
{
    class Camion : Vehículo
    {
       protected double toneladas;
        protected double sontone;

        public Camion()
        {

        }

        public Camion(double _precioVenta, double _costoFabrica, string _nombre, double _toneladas) : base(_precioVenta, _costoFabrica, _nombre)
        {
            this.toneladas = _toneladas;
        }
        public Camion(double _precioVenta, double _costoFabrica, string _nombre) : base(_precioVenta, _costoFabrica, _nombre)
        {

        }

        public double Ptoneladas
        {
            get { return Ptoneladas; }
            set { Ptoneladas = value; }
        }

        public void enseniaToneladas(double sontone)
        {
            this.toneladas = sontone;
        }

        public void imprimirCamion()
        {
            Console.WriteLine("Es un camion, su precio es " + precioVenta + "\n" + "su nombre es " + nombreVehiculo +
                "\n" + sontone);
        }

    }
}
