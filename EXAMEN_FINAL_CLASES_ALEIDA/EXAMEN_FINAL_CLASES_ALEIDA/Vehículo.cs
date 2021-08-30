using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL_CLASES_ALEIDA
{
    class Vehículo
    {
        //creamos los atributos de la clase padre 
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreVehiculo;

        //creamos los constructores
        public Vehículo()
        {

        } 

        public Vehículo(double _precioVenta, double _costoFabrica, string _nombreVehiculo)
        {
            this.precioVenta = _precioVenta;
            this.costoFabrica = _costoFabrica;
            this.nombreVehiculo = _nombreVehiculo;
        }

        //cargamos las propiedades
        public double PprecioVenta
        {
            get { return PprecioVenta; }
            set { PprecioVenta = value; }
        }

        public double PcostoFabrica
        {
            get { return PcostoFabrica; }
            set { PcostoFabrica = value; }
        }

        public string Pnombre
        {
            get { return Pnombre; }
            set { Pnombre = value; }
        }
    }

   
}
