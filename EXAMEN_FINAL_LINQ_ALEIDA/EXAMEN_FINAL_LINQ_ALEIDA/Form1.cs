using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_FINAL_LINQ_ALEIDA
{
    public partial class Form1 : Form
    {
        //creamos un nuevo objeto con el dataclasses
        DataClasses1DataContext producto1 = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }
        //para que al inicializar se cargue el grid
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListarProductos();
        }
        //cargamos el grid con los productos
        void ListarProductos()
        {
            dataGridView1.DataSource = producto1.spListarProductos();
        }

        void ListarNombre()
        {
            comboBox1.DataSource= producto1.spListarPRODUCTONOMBRE();
        }



//voton para añadir un producto
        private void BTNANIADIR_Click(object sender, EventArgs e)
        {
            producto1.spAltaPRODUCTO(TXTNUEVO.Text, decimal.Parse(TXTPRECIO.Text), int.Parse(TXTUNI.Text));
            this.ListarProductos();
        }
        //boton para eliminar un producto
        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            producto1.spBajaProductoFinal(comboBox1.SelectedItem.ToString());
            this.ListarProductos();
        }
        //boton para buscar un producto
        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource = producto1.spBUSCARPRODUCTO(TXTBUSCAR.Text);
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            producto1.spModificarProductoFinal(TXTNUEVO.Text, decimal.Parse(TXTPRECIO.Text), int.Parse(TXTUNI.Text));
            this.ListarProductos();
            this.ListarNombre();
        }

        //boton para modificar un producto

    }
}
