using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceXamarin.Models
{
    public class JugadorModel
    {
       
        public int IDJugador { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public Nullable<int> NumeroCamiseta { get; set; }
        public string Posicion { get; set; }
        public string EquipoJugador { get; set; }

    }
}