using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUCANET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext baseHospital = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        void cargarGid()
        {
            var cargaGrid = from p in baseHospital.Pacientes select p;
            dataGridDatos.DataSource = cargaGrid;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {


                Pacientes MyPaciente = new Pacientes();
                MyPaciente.Inscripcion = TxtInscripcion.Text;
                MyPaciente.Nombre_Apellidos = TxtNombre.Text;
                if (rdbMale.Checked == true)
                {
                    MyPaciente.Sexo = "h";
                }
                else
                {
                    if (rbtFemale.Checked == true)
                    {
                        MyPaciente.Sexo = "m";
                    }
                }
                MyPaciente.Fecha = dateTimePicker1.Value;
                MyPaciente.Direccion = txtDireccion.Text;
                MyPaciente.Numero_SS = TxtNumero.Text;
                baseHospital.Pacientes.InsertOnSubmit(MyPaciente);
                baseHospital.SubmitChanges();
                cargarGid();
                txtDatos.Text = "Datos introducidos correctamente";
            }
            catch
            {
                if(TxtInscripcion.Text=="" || TxtNombre.Text=="" || rbtFemale.Checked==false ||
                    rdbMale.Checked==false ||dateTimePicker1.Text==""|| txtDireccion.Text==""||TxtNumero.Text == "")
                {
                    txtDatos.Text = "Falta algún campo que introducir";
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargarGid();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Pacientes myPaciente=baseHospital.Pacientes.Single(p=>
                p.Inscripcion==TxtInscripcion.Text));
                baseHospital.Pacientes.DeleteOnSubmit(myPaciente);
                baseHospital.SubmitChanges();
                cargarGid();
                txtDatos.Text = "Registro eliminado correctamente";
            }
            catch
            {
                if (TxtInscripcion.Text == "")
                {
                    txtDatos.Text = "Falta la inscripcion del paciente";
                }
            }
        }
    }
}
