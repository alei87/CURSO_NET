using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA_ZOO
{
   class Ave: Animal
    {
        protected string colorPlumaje;
        protected double alturaMaximaVuelo;

        public string ColorPlumaje
        {
            get { return colorPlumaje; }
            set { colorPlumaje = value; }
        }
        public double AlturaMaximaVuelo
        {
            get { return alturaMaximaVuelo; }
            set { alturaMaximaVuelo = value; }
        }
        public Ave() { }

        public Ave(string especie, string nombre, double peso, int numJaula, string colorPlumaje, double alturaMaximaVuelo): base(especie, nombre, peso, numJaula) { }

        public override void ClaseDeAnimalEres()
        {
            Console.WriteLine("Soy un " + especie);
            Console.WriteLine("Mi nombre es " + this.Nombre);
            Console.WriteLine("Mi peso es " + this.Peso);
            Console.WriteLine("Mi número de jaula es " + this.NumJaula);
            Console.WriteLine("Mi color de plumas es " + this.ColorPlumaje);
            Console.WriteLine("Mi altura de vuelo es " + this.AlturaMaximaVuelo);
        }
    }
    
}
