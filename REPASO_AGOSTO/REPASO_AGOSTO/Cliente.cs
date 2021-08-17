using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO_AGOSTO
{
    public class Cliente : Persona
    {
        protected string categoria;
        protected string codigo;

        public Cliente()
        {
            categoria = "";
            codigo = "";
        }

        public string Pcategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Pcodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public void generarCodigo(string generaCodigo)
        {
            this.Pcodigo = "C" + this.Pnombres.Substring(0, 3) + this.Pdocumento.Substring(0, 2);
        }

        
    }
}
