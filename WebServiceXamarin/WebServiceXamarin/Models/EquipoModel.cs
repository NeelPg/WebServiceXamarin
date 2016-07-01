using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceXamarin.Models
{
    public class EquipoModel
    {
        
        public int IDEquipo { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Fundacion { get; set; }
        public string Entrenador { get; set; }
        public string Estadio { get; set; }
        public int Copas { get; set; }

          public virtual ICollection<JugadorModel> JugadorModel { get; set; }
    }
}