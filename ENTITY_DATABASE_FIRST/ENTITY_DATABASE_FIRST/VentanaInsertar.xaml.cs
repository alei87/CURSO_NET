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
using System.Windows.Shapes;

namespace ENTITY_DATABASE_FIRST
{
    /// <summary>
    /// Lógica de interacción para VentanaInsertar.xaml
    /// </summary>
    public partial class VentanaInsertar : Window
    { 
       ENTITYEntities DbEntity = new ENTITYEntities();

    
        public VentanaInsertar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // int id u l t i = MyDataGrid.Items.Count + 1;
            Profesores MyProfe = new Profesores()
            {
                Id = int.Parse(TxtID.Text),
                Nombre = TxtNombre.Text,
                Especialidad = cmbEspec.Text
            };
            DbEntity.Profesores.Add(MyProfe);
            DbEntity.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbEntity.Profesores.ToList();
            this.Hide();

        }
    }
}
