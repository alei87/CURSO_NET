using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA_ZOO
{
      class Mamifero: Animal
    {
        public Mamifero() { }

        public Mamifero(string especie,string nombre, double peso, int numJaula ): base(especie,nombre, peso, numJaula) { }

        public override void ClaseDeAnimalEres()
        {
            Console.WriteLine("Soy un " + this.Especie);
            Console.WriteLine("Mi nombre es " + this.Nombre);
            Console.WriteLine("Mi peso es " + this.Peso);
            Console.WriteLine("Mi número de jaula es " + this.NumJaula);
        }
    }
}
