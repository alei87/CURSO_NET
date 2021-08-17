using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO_AGOSTO
{
    public class Empleado:Persona
    {
        protected string tipoContrato;
        protected double sueldo;

        public Empleado()
        {
            tipoContrato = "";
            sueldo = 0;
        }

        public string ptipoContrato
        {
            get { return tipoContrato; }
            set { tipoContrato = value; }
        }

        public double Psueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public void calcularSueldo(int sueldoTotal)
        {
            if (ptipoContrato == "F")
            {
                Psueldo = Psueldo + 300;
            }
            else if (ptipoContrato == "T")
            {
                Psueldo = Psueldo + 250;
            }
            
        }
    }
}
