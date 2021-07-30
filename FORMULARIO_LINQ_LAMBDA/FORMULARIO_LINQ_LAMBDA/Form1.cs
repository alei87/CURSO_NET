using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIO_LINQ_LAMBDA
{
    public partial class Form1 : Form
    {
        public Form1()

        {
           
            InitializeComponent();
            
        }
        DataClasses1DataContext baseDatos = new DataClasses1DataContext();

        private void Form1_Load (Object sender, EventArgs e)
        {
            
        }

        void cargarCombo()
        {
            var cargaCombo = from p in baseDatos.Products
                             select p.ProductName;
            comboBox1.DataSource = cargaCombo;
        }

        void cargarGrid()
        {
            var cargaGrid = from p in baseDatos.Products select p;
            GridDatos.DataSource = cargaGrid;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = TxtProd.Text;
            MyProduct.UnitPrice = int.Parse(TxtPrec.Text);
            MyProduct.UnitsInStock = short.Parse(TxtStock.Text);
            MyProduct.CategoryID = int.Parse(TxtCat.Text);
            baseDatos.Products.InsertOnSubmit(MyProduct);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            Products MyProducto = baseDatos.Products.Single(p =>
            p.ProductName == comboBox1.SelectedItem.ToString());
            MyProducto.ProductName = comboBox1.SelectedItem.ToString();
            MyProducto.UnitPrice = int.Parse(TxtPrec.Text);
            MyProducto.UnitsInStock = short.Parse(TxtStock.Text);
            MyProducto.CategoryID = int.Parse(TxtCat.Text);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Products MyProduct = baseDatos.Products.Single(p =>
            p.ProductName == comboBox1.SelectedItem.ToString());
            baseDatos.Products.DeleteOnSubmit(MyProduct);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }
    }
}
