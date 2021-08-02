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
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
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

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Empleados myEmpleados = superBase.Empleados.Single(p =>
             p.id == Int32.Parse(txtID.Text));
            superBase.Empleados.DeleteOnSubmit(myEmpleados);
            superBase.SubmitChanges();
            cargarGrid();
        }
    }
}
