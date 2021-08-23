using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FiestaDeCumpleanos:Fiesta
    {
        protected int TamanoPastel;
        protected string TextoPastel;

    public FiestaDeCumpleanos() { }

        public int tamanoPastel
        {
            get { return TamanoPastel; }
            set { TamanoPastel = value; }
        }
        public string textoPastel
        {
            get { return TextoPastel; }
            set { TextoPastel = value; }
        }
        public FiestaDeCumpleanos(int NumeroDePersonas, double CostoDeDecoracion, double bonoExtra, double CostodeComidaPorPersona, bool Decora, double CostoPromedioPorPersona,int TamanoPastel,
            string TextoPastel): base(NumeroDePersonas, CostoDeDecoracion, bonoExtra, CostodeComidaPorPersona, Decora) { }
        public virtual void calcularCostoDeDecoracionCumple(double persona_decor)
        {
            if (Decora == true)
            {
                Console.WriteLine("Introduzca número de personas");
                double numeroDePersonas = double.Parse(Console.ReadLine());
                persona_decor = numeroDePersonas * 160;
                if (numeroDePersonas > 20)
                {
                    persona_decor = numeroDePersonas * 200;
                }

            }
            else
            {
                Console.WriteLine("La decoracion de la fiesta es gratuita");
            }
        }

        public virtual void CalcularCostoCumple()
        {

        }
    }
   


}

