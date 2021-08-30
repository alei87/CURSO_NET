using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL_CLASES_ALEIDA2
{
    class repartidorGlovo:Persona

    {
        protected double propinas;
        protected double desplazamientos;
        protected double precioDesplazamiento;
        protected double sueldo;

        public repartidorGlovo()
        {
            propinas = 0;
            desplazamientos = 0;
            precioDesplazamiento = 0;
            sueldo = 0;
        }

        public double Ppropinas
        {
            get { return propinas; }
            set { propinas = value; }
        }

        public double Pdesplazamientos
        {
            get { return desplazamientos; }
            set{ desplazamientos = value; }
        }

        public double PprecioDesplazamiento
        {
            get { return precioDesplazamiento; }
            set { precioDesplazamiento = value; }
        }

        public double Psueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public repartidorGlovo(double _propinas, double _desplazamientos, double _precioDesplazamientos,double _sueldo)
        {
            this.propinas = _propinas;
            this.desplazamientos = _desplazamientos;
            this.precioDesplazamiento = _precioDesplazamientos;
            this.sueldo = _sueldo;

        }

        public void ImprimeSueldo(double sueldo)
        {
            sueldo = this.desplazamientos * this.precioDesplazamiento + this.propinas;
        }

        public override void imprimir()
        {
            Console.WriteLine("este es un repartido de glovo su nombre es " + this.nombre + "\n"
                + "su empresa es " + this.empresa + "sus desplazamientos son " + this.desplazamientos + "\n" +
                "sus propinas son " + this.propinas + "su precio por desplazamiento es " + this.precioDesplazamiento+"\n"+ "su sueldo es "+this.sueldo);
               
        }
    }
}
