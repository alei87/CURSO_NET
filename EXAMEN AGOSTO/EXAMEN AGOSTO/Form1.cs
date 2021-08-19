using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_AGOSTO
{
    public partial class Form1 : Form
    {   //AÑADIMOS EL CONTEXTO DE ENTIDADES
        RepasoAgostoEntities1 ClientesEntity = new RepasoAgostoEntities1();
    
        public Form1()
        {
            InitializeComponent();
            //INVOCAMOS EL EVENTO DE CARGAR GRID
            cargarGrid();
        }
        //DEFINIMOS UN EVENTO PARA CARGAR EL GRID
        public void cargarGrid()
        {
            dataGridView1.DataSource = ClientesEntity.CLIENTES.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          }

        private void btagregar_Click(object sender, EventArgs e)
        {
            try
            {


                //boton para agregar registro
                //creamos un nuevo cliente con los contenidos de los textbox
                CLIENTES Misclientes = new CLIENTES()
                {
                    DNI = txtDNI.Text,
                    NOMBRE = txtNombres.Text,
                    APELLIDOS = txtApellidos.Text,
                    ESTADO_CIVIL = cbEstadocivil.Text,
                    E_MAIL = txtEmail.Text,
                    TELEFONO = txtTelefono.Text,
                    FECHA_NACIMIENTO = dateTimePicker1.Value

                };

                //llamamos al contexto de entidades y añadimos el objeto cliente
                ClientesEntity.CLIENTES.Add(Misclientes);

                //guardar el nuevo registro en la base de datos
                ClientesEntity.SaveChanges();

                //refrescamos datagrid
                cargarGrid();
                MessageBox.Show("Datos introducidos correctamente");
            }
            catch
            {
                if (txtDNI.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || cbEstadocivil.Text == "" ||
                    txtEmail.Text == "" || txtTelefono.Text == "" || dateTimePicker1.Value.ToString() == "")
                {
                    MessageBox.Show("te falta algún dato por rellenar");
                } else
                {
                    MessageBox.Show("DNI duplicado");
                }
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {


                string TextoDNI = txtDNI.Text;
                var buscaCliente = ClientesEntity.CLIENTES.Where(c => c.DNI == TextoDNI).Single();
                txtNombres.Text = buscaCliente.NOMBRE;
                txtApellidos.Text = buscaCliente.APELLIDOS;
                cbEstadocivil.Text = buscaCliente.ESTADO_CIVIL;
                txtEmail.Text = buscaCliente.E_MAIL;
                txtTelefono.Text = buscaCliente.TELEFONO;
                dateTimePicker1.Text = buscaCliente.FECHA_NACIMIENTO.ToString();
            }
            catch
            {
                if (txtDNI.Text == "")
                {
                    MessageBox.Show("Necesita introducir un DNI para buscar al cliente");
                }
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {


                //definimos una variable que guarda el DNI
                string TextoDNI = txtDNI.Text;

                //metodo LAMBDA que consigue a un cliente por su DNI
                var deleteCliente = ClientesEntity.CLIENTES.Where(c =>
                c.DNI == TextoDNI).Single();

                //borramos al cliente buscado
                ClientesEntity.CLIENTES.Remove(deleteCliente);
                ClientesEntity.SaveChanges();
                cargarGrid();

                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch
            {
                if (txtDNI.Text == "")
                {
                    MessageBox.Show("Introduzca el DNI del Cliente");
                }
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            //definir una variable para el DNI ojo deberia estar controlado
            //to do:

            try
            {


                string TextoDNI = txtDNI.Text;

                //mediante LINQ obtenemos el cliente
                CLIENTES MyCliente = (from c in ClientesEntity.CLIENTES
                                      where c.DNI == txtDNI.Text
                                      select c).Single();
                //definimos los atributos del objeto myCliente
                MyCliente.NOMBRE = txtNombres.Text;
                // MyCliente.DNI = txtDNI.Text;
                MyCliente.APELLIDOS = txtApellidos.Text;
                MyCliente.ESTADO_CIVIL = cbEstadocivil.Text;
                MyCliente.E_MAIL = txtEmail.Text;
                MyCliente.TELEFONO = txtTelefono.Text;
                MyCliente.FECHA_NACIMIENTO = dateTimePicker1.Value;

                //permanencia en base de datos salvado
                ClientesEntity.SaveChanges();
                cargarGrid();
                MessageBox.Show("Datos modificados correctamente");
            }
            catch
            {
                if (txtDNI.Text == "")
                {
                    MessageBox.Show("Introduzca el DNI para modificar ");

                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buscaCliente = ClientesEntity.CLIENTES.First();
            txtDNI.Text = buscaCliente.DNI;
            txtNombres.Text = buscaCliente.NOMBRE;
            txtApellidos.Text = buscaCliente.APELLIDOS;
            cbEstadocivil.Text = buscaCliente.ESTADO_CIVIL;
            txtEmail.Text = buscaCliente.E_MAIL;
            txtTelefono.Text = buscaCliente.TELEFONO;
            dateTimePicker1.Text = buscaCliente.FECHA_NACIMIENTO.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var buscaCliente = ClientesEntity.CLIENTES.ToList().Last();
            txtDNI.Text = buscaCliente.DNI;
            txtNombres.Text = buscaCliente.NOMBRE;
            txtApellidos.Text = buscaCliente.APELLIDOS;
            cbEstadocivil.Text = buscaCliente.ESTADO_CIVIL;
            txtEmail.Text = buscaCliente.E_MAIL;
            txtTelefono.Text = buscaCliente.TELEFONO;
            dateTimePicker1.Text = buscaCliente.FECHA_NACIMIENTO.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                //declaramos una variable para indicar la fila anterior
                int anterior = dataGridView1.CurrentRow.Index - 1;

                //nos desplazamos a la fila anterior

                dataGridView1.CurrentCell = dataGridView1.Rows[anterior].Cells
                    [dataGridView1.CurrentCell.ColumnIndex];
                //aqui cargamos en el textbox el DNI
                txtDNI.Text = dataGridView1.Rows[anterior].Cells[0].Value.ToString();
                txtNombres.Text = dataGridView1.Rows[anterior].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView1.Rows[anterior].Cells[2].Value.ToString();
                cbEstadocivil.Text = dataGridView1.Rows[anterior].Cells[3].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[anterior].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[anterior].Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[anterior].Cells[6].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Estas en la primera fila");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                //declaramos una variable para indicar la fila siguiente
                int posterior = dataGridView1.CurrentRow.Index + 1;

                //nos desplazamos a la fila siguiente

                dataGridView1.CurrentCell = dataGridView1.Rows[posterior].Cells
                    [dataGridView1.CurrentCell.ColumnIndex];
                //aqui cargamos en el textbox el DNI
                txtDNI.Text = dataGridView1.Rows[posterior].Cells[0].Value.ToString();
                txtNombres.Text = dataGridView1.Rows[posterior].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView1.Rows[posterior].Cells[2].Value.ToString();
                cbEstadocivil.Text = dataGridView1.Rows[posterior].Cells[3].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[posterior].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[posterior].Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[posterior].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Está en la última fila");
            }
        }
    }
}
