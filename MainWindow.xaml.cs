using FC_WPF.Vistas;
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

namespace FC_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarEquipo agregar = new AgregarEquipo();
            agregar.ShowDialog();
        }
        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            ListarEquipo listar = new ListarEquipo();
            listar.ShowDialog();
        }
        private void Acerca_DE_Click(object sender, RoutedEventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.ShowDialog();
        }

    }
}