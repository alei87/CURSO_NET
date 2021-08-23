using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class FiestaDeGala:Fiesta
    {
        protected double CostoPromedioporPersona;
        protected bool extra;

        public FiestaDeGala() { }

        public double costoPromedioporPersona
        {
            get { return CostoPromedioporPersona; }
            set { CostoPromedioporPersona = value; }
        }

        public bool Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public FiestaDeGala(int NumeroDePersonas, double CostoDeDecoracion, double bonoExtra, double CostodeComidaPorPersona, bool Decora, double CostoPromedioPorPersona, bool extra) :
            base(NumeroDePersonas, CostoDeDecoracion, bonoExtra, CostodeComidaPorPersona, Decora)
        { }


        public void SetOpcionExtra(double extraTotal)
        {
            Console.WriteLine("¿Quiere la opción Extra?");
            bool extra = bool.Parse(Console.ReadLine());
            if (extra == true)
            {
                extraTotal = NumeroDePersonas * 40;
            }
            else
            {
                Console.WriteLine("No ha añadido la opcion extra");
            }

            Console.WriteLine("el extra es " + this.bonoExtra);

           
        }

        public virtual  void calcularCostoDeDecoracionGala(double persona_decor)
        {
            if (Decora == true)
            {
                Console.WriteLine("Introduzca número de personas");
                double numeroDePersonas = double.Parse(Console.ReadLine());
                
                if (numeroDePersonas > 20)
                {
                    persona_decor = numeroDePersonas * 200;
                }

            }
            else
            {
                persona_decor = numeroDePersonas * 160;
            }
            persona_decor = this.costoDeDecoracion;
        }

        public virtual void CalcularCostoGala(double TotalGala=0)
        {
            TotalGala = this.costoDeDecoracion + this.bonoExtra + this.costoDeComidaPorPersona;
            Console.ReadLine();




        }

    }
}
