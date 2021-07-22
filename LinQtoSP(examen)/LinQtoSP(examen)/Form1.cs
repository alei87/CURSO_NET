using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQtoSP_examen_
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarClientes();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.Modificarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarClientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
            this.listarClientes();
        }

        void listarClientes()
        {
            GridDatos.DataSource = ClienteLinq.ListarClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarClientes();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridDatos.DataSource = ClienteLinq.buscarcliente(TxtBuscar.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtTelefono.Text = "";
            TxtBuscar.Text = "";
        }
    }
}
