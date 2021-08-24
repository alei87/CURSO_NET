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
            //controlar entrada de try
            try
            {
                //con el if controlamos los textbox que no este vacio con or
                if (TxtIDInsertar.Text != "" && TxtNombreInsertar.Text != "" && TxtEdadInsertar.Text != "")
                {
                    //abrir conexion
                    conexion.Open();

                    string iden = TxtIDInsertar.Text;
                    string nombre = TxtNombreInsertar.Text;
                    string edad = TxtEdadInsertar.Text;

                    //definimos la cadena sql y la lanzamos
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
            //poner los if aqui abajo
            {
                MessageBox.Show("El registro ya está insertado");
            }
           

           
            
        }

        private void BtnConsulta_Click(object sender, RoutedEventArgs e)
        {
            if (TxtIDEliminar.Text != "")
            {


                //abrir cadena
                conexion.Open();
                string id = TxtIDEliminar.Text;

                //definir cadena y la lanzamos
                string cadena = "select id, nombre, edad from Personas where id =" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //de sefine un sql reader para leer el registro buscado
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    //one el nobre y edad en los label
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
            else
            {
                MessageBox.Show("faltan datos");
            }
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            //mejor con try catch
            //boton para eliminar si busco anteriormente
            if(TxtIDEliminar.Text != "") //con el try el if abajo
                {

                //abrir cadena
                conexion.Open();
                string iden = TxtIDEliminar.Text;
                //definir cadena sql para borrar y ejecutarla
                string cadena = " delete from Personas where id=" + iden;
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //comprueba si elimino
                int cant;//en cant guardamos el numero de registros eliminados
                cant = comando.ExecuteNonQuery(); 
                if (cant == 1)
                {
                    LabelNombre.Content = "";
                    LabelEdad.Content = "";
                    TxtIDEliminar.Text = "";
                    MessageBox.Show("Se borró el artículo");
                }
                else
                {
                    MessageBox.Show("No existe el artículo con el código ingresado");
                    BtnBorrar.IsEnabled = true;

                }

                conexion.Close();
                //aqui iria el catch con los if
            }
            
        }

        private void BtnBusca_Click(object sender, RoutedEventArgs e)
        {
            if (TxtIDModificar.Text != "")
            { 
                //abrimos conexion 
            conexion.Open();
            string cod = TxtIDModificar.Text;

                //definimos la cadena y la ejecutamos
            string cadena = "select id, nombre, edad from Personas where id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
                //si la encuentravuelca el registro en el datareader y pone nombre y edad en los textbox
                //hablita el boton de modificar
            if (registro.Read())
            {
                TxtNombreModificar.Text = registro["nombre"].ToString();
                TxtEdadModificar.Text = registro["edad"].ToString();
                BtnModifica.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("No existe el artículo con el código ingresado");
            }
            //cerramos la conexion
            conexion.Close();
        }
            else
            {
                MessageBox.Show("faltan datos");
            }
        }

        private void BtnModifica_Click(object sender, RoutedEventArgs e)
        {
            
            //el try lo primero antes de la conexion
            //abrimos la conexion
            //if con &&!!!!
            //faltaria el try o el if y con las ||con != y con los&& el if con == abajo donde el catch
            //los if pueden ser con== o!= 
            conexion.Open();
            string id = TxtIDModificar.Text;
            string nombre = TxtNombreModificar.Text;
            string edad = TxtEdadModificar.Text;

            //definimos la cadena sql y lanzamos
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
                MessageBox.Show("No existe el artículo con el código ingresado");
            }
                
            conexion.Close(); //se cierra la conexion antes del catch

            //aqui iria el faltan datos
            BtnModifica.IsEnabled = false;
        }
    }
}
