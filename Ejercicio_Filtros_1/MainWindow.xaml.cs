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

namespace Ejercicio_Filtros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //inicializamos la clase de contexto GLOBAL
        //siempre en la clase mainwindows si es WPF
       DatosJuevesContextoDataContext filtros = new DatosJuevesContextoDataContext();
        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();
            cargarGrid();

        }

        void cargarGrid()
        {
            //metodo con linq para alimentar el datagrid
            var listagrid = from f in filtros.DatosJueves select f;
            DGV1.ItemsSource = listagrid;
        }
        /// <summary>
        /// metodo para mostrar los registros de un curso determinado
        /// </summary>

        void cargarGridCurso()
        {
            //aqui  filtramos los registros del curso
            //seleccionado con el combo
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosJueves where f.Curso == curso select f;
            DGV1.ItemsSource = listagrid;

        }
        /// <summary>
        /// metodo con linq para filtrar por el nombre
        /// OJO contains es lo mismo que LIKE en SQL
        /// filtra en funcion del nombre y del curso
        /// </summary>
        /// <param name="cadena">la cadena seria el nombre a filtrar</param>

        void cargarGridNombre(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosJueves where f.Curso == curso && f.Nombre.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;

        }
        /// <summary>
        /// se filtra por curso y apellido
        /// </summary>
        /// <param name="cadena"></param>

        void cargarGridApellido(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosJueves where f.Curso == curso && f.Apellidos.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }

        /// <summary>
        /// filtra por curso, por apellido y por nombre
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="cadena2"></param>

        void cargarGridApellidoNombre(String cadena, string cadena2)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.DatosJueves where f.Curso == curso && f.Nombre.Contains(cadena) && f.Apellidos.Contains(cadena2) select f;
            DGV1.ItemsSource = listagrid;
        }


        /// <summary>
        /// Habilitar y deshabilitar Check
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = true;

        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = false;

        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = true;
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {

            DatePicker2.IsEnabled = false;
        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = true;
        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {

            DatePicker3.IsEnabled = false;
        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = true;
        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = false;

        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = true;
            CheckBox5.IsEnabled = true;
        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = false;
            CheckBox5.IsEnabled = false;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            
                cargarGridApellidoNombre(TextBox1.Text, TextBox2.Text);
                else if (TextBox1.Text != "" && TextBox2.Text == "")
                    cargarGridNombre(TextBox1.Text);
                else if (TextBox1.Text == "" && TextBox2.Text != "")
                    cargarGridApellido(TextBox2.Text);
                else cargarGridCurso();

            
        }

        void cargarGridFechas(DateTime  date, DateTime date2 )
        {
            string curso = ComboBox1.Text;
            var listagrid = from c in filtros.DatosJueves where c.Curso == curso && c.Fecha_Ins >= date &&c.Fecha_Cont<= date2 select c;
            DGV1.ItemsSource = listagrid;
        }
           

        private void btnFecha_Click(object sender, RoutedEventArgs e)
        {
            DateTime desde = DatePicker1.DisplayDate;
            DateTime hasta = DatePicker2.DisplayDate;
            cargarGridFechas(desde, hasta);
        }
    }
}
