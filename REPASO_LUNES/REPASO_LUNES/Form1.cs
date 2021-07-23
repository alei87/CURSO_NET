using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASO_LUNES
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext clases = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        void mostrarCliente()
        {
            DataGridDatos.DataSource = clases.spListarClientes();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            clases.spañadirClienteS(TxtIDcliente.Text,TxtApellidos.Text, TxtNombre.Text);
            this.mostrarCliente();
 
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            clases.spEliminarCliente(TxtIDcliente.Text);
            this.mostrarCliente();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            clases.spModificarCliente(TxtIDcliente.Text, TxtNombre.Text, TxtApellidos.Text);
            this.mostrarCliente();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            clases.spBuscarCliente(TxtBuscar.Text);

            if (comboBox1.Text == "IDCLIENTE")
            {
                DataGridDatos.DataSource = clases.spBuscarCliente(TxtBuscar.Text);

            }
            else
            {
                if (comboBox1.Text == "NOMBRES")
                {
                    DataGridDatos.DataSource = clases.spBuscarNombreCliente(TxtBuscar.Text);
                }
                else
                {
                    DataGridDatos.DataSource = clases.spBuscarApellidoCliente(TxtBuscar.Text);
                        
                }


            }   
            

                
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mostrarCliente();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            this.mostrarCliente();
            TxtBuscar.Text = "";
            TxtIDcliente.Text = "";
            TxtNombre.Text = "";
            TxtApellidos.Text = "";

        }
    }
}
