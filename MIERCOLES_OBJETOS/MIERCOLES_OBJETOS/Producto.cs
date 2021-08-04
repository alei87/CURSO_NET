using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIERCOLES_OBJETOS
{
     public class Producto
    {
       private string nombre;
       private double precio;
       private string categoria;

        public Producto()
        {

        }
        public Producto(string nombre, double precio, string categoria)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;

        }
        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        
        public void Pedir()
        {
            Console.WriteLine("")
           for(int cant) 
        }
        

    }
}
