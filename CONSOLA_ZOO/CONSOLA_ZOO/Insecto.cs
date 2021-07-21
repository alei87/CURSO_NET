using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA_ZOO
{
    class Insecto: Animal
    {
        protected bool vuela;

        public Insecto() { }

        public bool Vuela
        {
            get { return vuela; }
            set { vuela = value; }
        }

        public Insecto(string especie, string nombre, double peso, int numJaula, bool vuela) : base(especie, nombre, peso, numJaula) { }

        public override void ClaseDeAnimalEres()
        {
            if (vuela == true)
            {
                Console.WriteLine("Soy un insecto volador");
            }
            else
            {
                Console.WriteLine("Soy un insecto que no vuela");
            }

            Console.WriteLine("Soy un " + this.Especie);
            Console.WriteLine("Mi nombre es " + this.Nombre);
            Console.WriteLine("Mi peso es " + this.Peso);
            Console.WriteLine("Mi número de jaula es " + this.NumJaula);
            
        }
    }
}
