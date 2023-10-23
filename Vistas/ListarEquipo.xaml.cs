using System;
using System.Windows;
using System.Windows.Controls;
using FC_WPF.Vistas.Clases;

namespace FC_WPF.Vistas
{
    public partial class ListarEquipo : Window
    {
        public ListarEquipo()
        {
            InitializeComponent();
            TodosEquipo.ItemsSource = EquipoCollection.EquipoList;
            TodosEquipo.CanUserAddRows = false;
        }


        private void btnActualizar(object sender, RoutedEventArgs e)
        {
 
            var equipoSeleccionado = (Equipo)TodosEquipo.SelectedItem;
            ActualizarEquipo actualizar = new ActualizarEquipo(equipoSeleccionado);
            actualizar.ShowDialog();
        }


        private void btnEliminar(object sender, RoutedEventArgs e)
        {
            int index = TodosEquipo.SelectedIndex;
            EquipoCollection.EquipoList.RemoveAt(index);
            TodosEquipo.Items.Refresh();
        }

   
        private void Window_Activated(object sender, EventArgs e)
        {
            TodosEquipo.Items.Refresh();
        }

        private void TodosEquipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
