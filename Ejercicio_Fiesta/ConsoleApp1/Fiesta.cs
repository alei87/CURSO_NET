using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fiesta
    {
        //protected para heredar 
        //dato introducido
        protected int NumeroDePersonas;
        //calculado
        protected double CostoDeDecoracion;
        //introducido
        protected double bonoExtra;
        protected double CostodeComidaPorPersona;
        protected bool Decora;

        //atributos que la componen
        public int numeroDePersonas
        {
            get { return NumeroDePersonas; }
            set { NumeroDePersonas = value; }
        }

        public double costoDeDecoracion
        {
            get { return CostoDeDecoracion; }
            set { CostoDeDecoracion = value; }
        }

        public double BonoExtra
        {
            get { return bonoExtra; }
            set { bonoExtra = value; }
        }

        public double costoDeComidaPorPersona
        {
            get { return costoDeComidaPorPersona; }
            set { costoDeComidaPorPersona = value; }
        }

        public bool decora
        {
            get { return Decora; }
            set { Decora = value; }
        }

       // public Fiesta() { }

       // public Fiesta(int p_numeroPer, double p_costo_decor, double p_bono, double p_costo_comida, bool p_decora)
       // {
           // NumeroDePersonas = p_numeroPer;
            //CostoDeDecoracion = p_costo_decor;
            //bonoExtra = p_bono;
           // CostodeComidaPorPersona = p_costo_comida;
            //Decora = p_decora;

        //}

        //public void imprimir()
       
    }
}
