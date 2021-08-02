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
            try
            {

                Empleados MyEmpleados = new Empleados();
                MyEmpleados.id = int.Parse(txtID.Text);
                MyEmpleados.Nombre = txtNombre.Text;
                MyEmpleados.Apellidos = txtApellido.Text;
                MyEmpleados.Edad = int.Parse(txtEdad.Text);
                MyEmpleados.Casado = checkBox1.Checked;
                superBase.Empleados.InsertOnSubmit(MyEmpleados);
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
            try
            {


                Empleados myEmpleados = superBase.Empleados.Single(p =>
                 p.id == Int32.Parse(txtID.Text));
                superBase.Empleados.DeleteOnSubmit(myEmpleados);
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
            try
            {


                Empleados myEmpleados = superBase.Empleados.Single(p =>
                 p.id == Int32.Parse(txtID.Text));
                myEmpleados.Nombre = txtNombre.Text;
                myEmpleados.Apellidos = (txtApellido.Text);
                myEmpleados.Edad = Int32.Parse(txtEdad.Text);
                myEmpleados.Casado = checkBox1.Checked;
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
            string nom = txtBuscar.Text;
            var busq = from Empleados in superBase.Empleados
                       where Empleados.Nombre.Contains(nom)
            
                                       select Empleados;
            dataGridView1.DataSource = busq;

        }

        private void labelContar_Click(object sender, EventArgs e)
        {
           


        }
    }
}
