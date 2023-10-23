using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string NombreEquipo = txtNombreEquipo.Text;
            int Cantidad = Convert.ToInt32(txtCantidadJugadores.Text);
            string NombreDT = TxtNombreDT.Text;
            string TipoEquipo = TxtTipoEquipo.Text;
            string CapitanEquipo = TxtCapitanEquipo.Text;
            bool Sub21 = (TxTSub21.IsChecked.Value) ? true : false;

            Vistas.Clases.Equipo equipo = new Clases.Equipo(NombreEquipo, Cantidad, NombreDT, TipoEquipo, CapitanEquipo, Sub21);
            Vistas.Clases.EquipoCollection.EquipoList.Add(equipo);


            this.Close();

        }

        private static Regex s_regex = new Regex("[^0-9]+");
        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }


    }
}