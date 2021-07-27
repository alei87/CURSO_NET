using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LISTADO_ALUMNO
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("Server=ASATA402\\SQLEXPRESSALEIDA; Initial Catalog=ALUMNOS_SQL; Persist Security Info=True;User=sa;Password=1234;");


        DataClasses1DataContext AlumnoLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarClientes();
        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlumnoLinq.spBusquedaCodigo_Alumnos(Int32.Parse(TxtCodigoBusqueda.Text));
            

        }

        void listarClientes()
        {
            dataGridView1.DataSource = AlumnoLinq.spCargarGrid_Alumnos();
        }

        private void BtnDNIBusqueda_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlumnoLinq.spBusqueda_DNI_Alumnos(TxtDNIBusqueda.Text);

        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtDNI.Text !="" && TxtNombre.Text != "")
                {
                    conexion.Open();
                    string docum = TxtDNI.Text;
                    string nomb = TxtNombre.Text;
                    string tur = CmbTurno.Text;
                    string sex = CmbSexo.Text;
                    string espe = CmbEspecialidad.Text;
                    string modu = CmbModulo.Text;
                    int rep1=0;
                    if (checkBox1.Checked == true)
                    {
                       rep1 = 1;
                    }
                    else
                    {
                       rep1 = 0;
                    }
                    string cadena = "insert into TABLA_ALUMNOS(DNI, Nombre, Turno, Sexo, Especialidad, Modulo, Repetidor)" +
                        "values ('" + docum + "','" + nomb + "','" + tur + "','" + sex + "','" + espe + "','" + modu + "'," + rep1 + ")";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han cargado corectamente");
                    TxtDNI.Text = "";
                    TxtNombre.Text = "";
                    CmbTurno.Text = "";
                    CmbSexo.Text = "";
                    CmbEspecialidad.Text = "";
                    CmbModulo.Text = "";
                    checkBox1.Text = "";

                    conexion.Close();
                    this.listarClientes();

                }
                else
                {
                    MessageBox.Show("Faltan datos");
                }
            }
            catch
            {
                MessageBox.Show("El registro ya está insertado");
            }

        }
    }
}
