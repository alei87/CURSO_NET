using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL_CLASES_ALEIDA2
{
    class Persona
    {
        //creamos los atributos protected para que los pueda utilizar la clase que herada
        protected string nombre;
        protected string empresa;

        //creamos un constructor por defecto
        public Persona()
        {
            nombre = "";
            empresa = "";
        }

        //sobrecargamos el constructor

        public Persona(string _nombre, string _empresa)
        {
            this.nombre = _nombre;
            this.empresa = _empresa;
        }

        public string Pnombre  //propiedades
        {
            get { return nombre; }//atributos
            set { nombre = value; }
        }

        public string Pempresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public  virtual void imprimir()
        {

        }

    }

}
