using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EJERCICIO_LINQ_2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext superBase = new DataClasses1DataContext();

        void cargarGrid()
        {
            //con linq hacemos una consulta para que cargue el grid
            var cargaGrid = from p in superBase.Empleados select p; //llamo a la tabla que hago referencia
                            
           dataGridView1.DataSource = cargaGrid;
            var contar = from Empleados in superBase.Empleados
                         select Empleados;
            int num = contar.Count();
            labelContar.Text = num.ToString();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //boton para dar de alta un registro nuevo
            try
            {
                //definimos un objeto tipo usuario
                Empleados MyEmpleados = new Empleados();

                //guardamos los datos del usuario
                MyEmpleados.id = int.Parse(txtID.Text);
                MyEmpleados.Nombre = txtNombre.Text;
                MyEmpleados.Apellidos = txtApellido.Text;
                MyEmpleados.Edad = int.Parse(txtEdad.Text);
                MyEmpleados.Casado = checkBox1.Checked;
                //insertonsubmit añade el registro en la database
                superBase.Empleados.InsertOnSubmit(MyEmpleados);

                //con submitchanges hace la confirmacion de los datos
                superBase.SubmitChanges();
                cargarGrid();
            }
            catch
            {
                if(txtID.Text=="" && txtNombre.Text=="" && txtApellido.Text=="" && txtEdad.Text=="")
                {
                    MessageBox.Show("Falta algún campo por rellenar");
                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            //boton para dar de baja
            try
            {

                //dentro del try creamos un objeto de tipo usuario
                //con lambda y lo obtenemos de la base de datos donde coincida el id
                Empleados myEmpleados = superBase.Empleados.Single(p =>
                 p.id == Int32.Parse(txtID.Text));

                //un deleteonsubmit para borrar los registros
                superBase.Empleados.DeleteOnSubmit(myEmpleados);

                //confirmar el borrado
                superBase.SubmitChanges();
                cargarGrid();
            }
            catch
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Introduzaca ID del empleado");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton para modificar un registro
            try
            {
                //try pra probar que todos los campos estan rellenados
                //y el id existe
                Empleados myEmpleados = superBase.Empleados.Single(p =>
                 p.id == Int32.Parse(txtID.Text));
                myEmpleados.Nombre = txtNombre.Text;
                myEmpleados.Apellidos = (txtApellido.Text);
                myEmpleados.Edad = Int32.Parse(txtEdad.Text);
                myEmpleados.Casado = checkBox1.Checked;

                //actualiza los datos
                superBase.SubmitChanges();
                cargarGrid();
            }
            catch
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Introduzca Id para modificar el empleado");
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //comprueba que el cuadro de busqueda no esta en blanco
                if (txtBuscar.Text != "")
                {
                        //fata para que nos ponga los datos en cada textbox
                    string nom = txtBuscar.Text;
                    var busq = from Empleados in superBase.Empleados
                               where Empleados.Nombre.Contains(nom)

                    //cargamos el grid con el nombre filtrado
                               select Empleados;
                    dataGridView1.DataSource = busq;
                }
            }
            catch
            {
                MessageBox.Show("No existe");
            }
        }

        private void labelContar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
