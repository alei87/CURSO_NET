using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO_AGOSTO
{
    public class Persona
    {
       protected string nombres;
       protected string apellidos;
       protected string documento;
       protected string tipo;

        public Persona()
        {
            nombres = "";
            apellidos = "";
            documento = "";
            tipo = "";
        }


        public string Pnombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Papellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Pdocumento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string Ptipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
