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

namespace ENTITY_DATABASE_FIRST
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ENTITYEntities DbEntity = new ENTITYEntities();

        public static DataGrid ControlDatagrid;

        public MainWindow()
        {
            //Cargamos el Datagrid con los datos apuntando a la tabla profesores
            InitializeComponent();
            MyDG.ItemsSource =
            DbEntity.Profesores.ToList();
            ControlDatagrid = MyDG;

        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // El primer botón llama al cuadro Insertar
            VentanaInsertar Vinsertar = new VentanaInsertar();
            Vinsertar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // E l segundo botón llama al cuadro Modificar
            int id = (MyDG.SelectedItem as Profesores).Id;
            VentanaModificar Vcambiar = new VentanaModificar(id);
            Vcambiar.ShowDialog();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int id = (MyDG.SelectedItem as Profesores).Id;
            var deleteProfe = DbEntity.Profesores.Where(m =>
            m.Id == id).Single();
            DbEntity.Profesores.Remove(deleteProfe);
            DbEntity.SaveChanges();
            ControlDatagrid.ItemsSource =
            DbEntity.Profesores.ToList();
        }
    }
}
