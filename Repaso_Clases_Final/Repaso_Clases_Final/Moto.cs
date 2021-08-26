using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Clases_Final
{
    class Moto:Vehículo
    {
        protected bool sidecar;
        protected string tienesidecar;

        public Moto() { }

        public Moto(int ID, string marca, string modelo, int KM, double precio, bool sidecar) : base(ID, marca, modelo, KM, precio)
        {
            this.sidecar = sidecar;
        }

        public bool Sidecar
        {
            get { return sidecar; }
            set { sidecar=value; }
        }

        public void TieneSidecar(bool side)
        {
            if (side== true)
            {
                this.precio = precio + 50;
                tienesidecar = "tiene sidecar";
            }
            else
            {
                this.sidecar = false;
                tienesidecar = "no tiene sidecar";
            }
        }

        public void ImprimirMoto()
        {
            Console.WriteLine("El ID es " + this.ID + "\n la marca es " + this.marca + "\n" + "su modelo es " + this.modelo + "\n" + "sus KM son " + this.KM +
                "\n su precio es " + this.precio + "\n"  + tienesidecar);
        }
    }
}
