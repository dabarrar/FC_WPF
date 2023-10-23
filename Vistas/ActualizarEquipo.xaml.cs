using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FC_WPF.Vistas
{
    /// <summary>
    /// Lógica de interacción para ActualizarEquipo.xaml
    /// </summary>
    public partial class ActualizarEquipo : Window
    {
        Vistas.Clases.Equipo equipo = new Vistas.Clases.Equipo();
        public ActualizarEquipo(Clases.Equipo equipo)
        {
            InitializeComponent();
            this.equipo = equipo;
            CargarDatosFormulario();

        }
    private void botonActualizar(object sender, RoutedEventArgs e)
        {
            Vistas.Clases.Equipo equipoTemporal = new();
            equipoTemporal.NombreEquipo = txtNombreEquipo.Text;
            equipoTemporal.CantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
            equipoTemporal.NombreDT = TxtNombreDT.Text;
            equipoTemporal.TipoEquipo = TxtTipoEquipo.Text;
            equipoTemporal.CapitanEquipo = TxtCapitanEquipo.Text;
            equipoTemporal.TieneSub21 = (TxTSub21.IsChecked.Value) ? true : false;

            int index = Vistas.Clases.EquipoCollection.EquipoList.IndexOf(this.equipo);
            Vistas.Clases.EquipoCollection.EquipoList.RemoveAt(index);
            Vistas.Clases.EquipoCollection.EquipoList.Insert(index, equipoTemporal);
            this.Close();   
        }

    private void CargarDatosFormulario()
        {
            txtNombreEquipo.Text=this.equipo.NombreEquipo;
            txtCantidadJugadores.Text = this.equipo.CantidadJugadores.ToString();
            TxtNombreDT.Text = this.equipo.NombreDT;
            TxtTipoEquipo.Text = this.equipo.TipoEquipo;
            TxtCapitanEquipo.Text=this.equipo.CapitanEquipo;
            TxTSub21.IsChecked=(this.equipo.TieneSub21) ?true : false;



        }


        private static Regex s_regex = new Regex("[^0-9]+");
        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }

     }
}
