using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_WPF.Vistas.Clases
{ 
     public class Equipo
{
    public string NombreEquipo { get; set; }
    public int CantidadJugadores { get; set; }
    public string NombreDT { get; set; }
    public string TipoEquipo { get; set; }
    public string CapitanEquipo { get; set; }
    public bool TieneSub21 { get; set; }

    // Constructor con todas las propiedades
    public Equipo(string nombreEquipo, int cantidadJugadores, string nombreDT, string tipoEquipo, string capitanEquipo, bool tieneSub21)
    {
        NombreEquipo = nombreEquipo;
        CantidadJugadores = cantidadJugadores;
        NombreDT = nombreDT;
        TipoEquipo = tipoEquipo;
        CapitanEquipo = capitanEquipo;
        TieneSub21 = tieneSub21;
    }

    // Constructor vacío
    public Equipo()
    {
    }
}

}