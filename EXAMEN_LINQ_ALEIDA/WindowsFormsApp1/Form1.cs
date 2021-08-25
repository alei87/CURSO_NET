using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //definimos la clase
        DataClasses1DataContext dbExamen = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombo();
        }
        //con linq hacemos una consulta para que cargue el grid
        void CargarGrid()
        {
            var cargaGrid = from p in dbExamen.PRODUCTOS select p;
            dataGridView1.DataSource = cargaGrid;
        }

        //con linq hacemos una consulta para cargar el combobox

        void CargarCombo()
        {
            var cargaCombo = from p in dbExamen.PRODUCTOS select p.NombreProducto;
            comboBox1.DataSource = cargaCombo;
        }

        //boton para buscar un registro
        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {

            try
            {
                //buscamos por el nombre del producto
                PRODUCTOS MyProducto = dbExamen.PRODUCTOS.Single(p =>
                 p.NombreProducto.Contains(TXTBUSCAR.Text));

                //con linq cargamos el grid con el contenido filtrado y se regresca el grid
                var buscanombre = from PRODUCTOS in dbExamen.PRODUCTOS
                                  where PRODUCTOS.NombreProducto.Contains(TXTBUSCAR.Text)
                                  select PRODUCTOS;

                //cargamos el grid con el nombre filtrado
                dataGridView1.DataSource = buscanombre;
                buscaProducto();


            }

            catch
            {
                if (TXTBUSCAR.Text == "") MessageBox.Show("Introduzca un nombre");
                
             
            }

            
        }

        //boton para añadir un registro
        private void BTNANIADIR_Click(object sender, EventArgs e)
        {
            //controlamos que esten todos lo datos añadidos
            try
            {
                //definimos un objeto tipo producto
                PRODUCTOS MyProducto = new PRODUCTOS();

                //guardamos todos los datos del producto
                MyProducto.NombreProducto = TXTNOMBRE.Text;
                MyProducto.PrecioUnidad = decimal.Parse(TXTPRECIO.Text);
                MyProducto.UnidadStock = int.Parse(TXTUNI.Text);

                //insertonsubmit para añadir el registro 
                dbExamen.PRODUCTOS.InsertOnSubmit(MyProducto);

                //submitchanges para la confirmación
                dbExamen.SubmitChanges();

                //cargamos el grid y el combo
                CargarGrid();
                CargarCombo();
            }
            catch
            {
               if(TXTNOMBRE.Text==""||TXTPRECIO.Text==""||TXTUNI.Text=="") MessageBox.Show("Faltan datos");
            }

        }

        //boton par modificar un registro
        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {
                //utilizamos lambda para sacar un registro seleccionado
                PRODUCTOS MyProducto = dbExamen.PRODUCTOS.Single(p =>
                  p.NombreProducto == comboBox1.SelectedItem.ToString());
                MyProducto.NombreProducto = TXTNOMBRE.Text;
                MyProducto.PrecioUnidad = decimal.Parse(TXTPRECIO.Text);
                MyProducto.UnidadStock = int.Parse(TXTUNI.Text);

                //cargamos los textbox par modificar los datos

                TXTNOMBRE.Text = MyProducto.NombreProducto;
                TXTPRECIO.Text = MyProducto.PrecioUnidad.ToString();
                TXTUNI.Text = MyProducto.UnidadStock.ToString();

                //actualizamos los datos
                dbExamen.SubmitChanges();
                //cargamos el grid y el combo
                CargarGrid();
                CargarCombo();
            }
            catch
            {
                if (comboBox1.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Seleccione algún producto");
                }
            }

        }

        //boton para eliminar un registro
        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                //creamos un objeto con lambda y obtenemos el registro de la base
                //de datos donde coincida el nombre
                PRODUCTOS MyProducto = dbExamen.PRODUCTOS.Single(p =>
                  p.NombreProducto ==comboBox1.SelectedItem.ToString());

                //delete on sobmit para eliminar el registro en la base de datos
                dbExamen.PRODUCTOS.DeleteOnSubmit(MyProducto);

                //actualizamos los datos
                dbExamen.SubmitChanges();

                //cargamos el grid y el combo
                CargarGrid();
                CargarCombo();
            }
            catch
            {
                if (comboBox1.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Seleccione un producto");
                }
            }
        }

        void buscaProducto()
        {
            var buscapro = (from p in dbExamen.PRODUCTOS
                            where p.NombreProducto == TXTBUSCAR.Text
                            select p.NombreProducto).ToList();
            MessageBox.Show("Producto en stock");

           
                         
        }
    }
}
