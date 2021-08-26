using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Clases_Final
{
    class Coche:Vehículo
    {
        protected bool airbag;
        protected string tieneairbag;

        public Coche() { }

        public Coche(int ID, string marca, string modelo, int KM, double precio, bool airbag):base(ID, marca, modelo, KM, precio)
        {
            this.airbag = airbag;
        } 

        public bool Airbag
        {
            get { return airbag; }
            set { airbag = value; }
        }
        public void TieneAirbag(bool bag)
        {
            this.airbag = bag;
            if (this.airbag == true)
            {
                this.precio = precio + 200;
                tieneairbag = "tiene airbag";
                
            }
            else
            {
                this.airbag =false;
                tieneairbag = "no tiene airbag";


            }
                    
        }

        public void ImprimirCoche()
        {
            Console.WriteLine("El ID es " + this.ID + "\n la marca es " + this.marca + "\n" + "su modelo es " + this.modelo + "\n" + "sus KM son " + this.KM +
                "\n su precio es " + this.precio + "\n "+ tieneairbag);
        }
    }
}
