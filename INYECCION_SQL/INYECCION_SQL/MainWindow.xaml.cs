using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace INYECCION_SQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion = new SqlConnection("Server=ASATA402\\SQLEXPRESSALEIDA; Initial Catalog=INYECCION_SQL; Persist Security Info=True;User=sa;Password=1234;");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtIDInsertar.Text != "" && TxtNombreInsertar.Text != "" && TxtEdadInsertar.Text != "")
                {

                    conexion.Open();
                    string iden = TxtIDInsertar.Text;
                    string nombre = TxtNombreInsertar.Text;
                    string edad = TxtEdadInsertar.Text;
                    string cadena = "insert into Personas (id, nombre, edad)" +
                        "values(" + iden + ",'" + nombre + "' ," + edad + ")";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente");
                    TxtIDInsertar.Text = "";
                    TxtNombreInsertar.Text = "";
                    TxtEdadInsertar.Text = "";


                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }




            }
            catch
            {
                MessageBox.Show("El registro ya está insertado");
            }
           

           
            
        }

        private void BtnConsulta_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = TxtIDEliminar.Text;
            string cadena = "select id, nombre, edad from Personas where id =" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro =  comando.ExecuteReader();
            if (registro.Read())
            {
                LabelNombre.Content = registro["nombre"].ToString();
                LabelEdad.Content = registro["edad"].ToString();
                BtnConsulta.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
            }
               
            conexion.Close();
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = TxtIDEliminar.Text;
            string cadena = " delete from Personas where id=" + iden;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                LabelNombre.Content = "";
                LabelEdad.Content = "";
                MessageBox.Show("Se borró el artículo");
            }
            else
            {
                MessageBox.Show("No existe el artículo con el código ingresado");
            }
                
            conexion.Close();
            BtnConsulta.IsEnabled = false;
        }

        private void BtnBusca_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string cod = TxtIDModificar.Text;
            string cadena = "select id, nombre, edad from Personas where id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombreModificar.Text = registro["nombre"].ToString();
                TxtEdadModificar.Text = registro["edad"].ToString();
                BtnInsertar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("No existe el artículo con el código ingresado");
            }
               
            conexion.Close();
        }

        private void BtnModifica_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = TxtIDModificar.Text;
            string nombre = TxtNombreModificar.Text;
            string edad = TxtEdadModificar.Text;
            string cadena = "update Personas set nombre='" + nombre + "', edad=" + edad + "where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se han modificado los datos del artículo");
                TxtIDModificar.Text = "";
                TxtNombreModificar.Text = "";
                TxtEdadModificar.Text = "";
            }
            else
            {
                MessageBox.Show("No existe el artículo con el códogo ingresado");
            }
                
            conexion.Close();
            BtnModifica.IsEnabled = false;
        }
    }
}
