using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA_ZOO
{
    abstract class Animal
    {
        protected string especie;
        protected string nombre;
        protected double peso;
        protected int numJaula;

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        
        public int NumJaula
        {
            get { return numJaula; }
            set { numJaula = value; }
        }

        public Animal() { }
        public Animal(string p_especie, string p_nombre, double p_peso, int p_numJaula)
        {
             especie= p_especie;
             nombre= p_nombre;
            peso=p_peso;
              numJaula= p_numJaula;
        }

        public virtual void ClaseDeAnimalEres()
        {
            
        }
    }
}
