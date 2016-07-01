using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using WebServiceXamarin.Models;

namespace WebServiceXamarin.Controllers
{

    public class SeleccionController : ApiController
    {

        // GET: Seleccion
        public List<EquipoModel> GetListaJugadores()
        {
            var bd = new BDEventoXamarinEntities();
            var query =(from E in bd.Equipo.ToList()
                         select new EquipoModel
                         {
                             IDEquipo = E.equipo_id,
                             Nombre = E.equipo_nombre,
                             Copas = E.equipo_copas,
                             Entrenador = E.equipo_entrenador,
                             Estadio = E.equipo_estadio,
                             Fundacion = E.equipo_fundacion,
                             JugadorModel = (from J in bd.Jugador.ToList()
                              select new JugadorModel
                              {
                                  IDJugador = J.jugador_id,
                                  Nombre = J.jugador_nombre,
                                  Foto = J.jugador_foto,
                                  NumeroCamiseta = J.jugador_numero,
                                  Posicion = J.jugador_posicion,
                                  EquipoJugador = J.jugador_equipo
                                  
                                  
                              }).ToList()
                             

                         });
            return query.ToList();

        }
        public List<JugadorModel> GetJugador(int id)
        {
            var bd = new BDEventoXamarinEntities();
            var query = (from J in bd.Jugador.ToList()
                         where J.jugador_id == id
                         select new JugadorModel()
                         {
                             IDJugador = J.jugador_id,
                             Nombre = J.jugador_nombre,
                             Foto = J.jugador_foto,
                             NumeroCamiseta = J.jugador_numero,
                             Posicion = J.jugador_posicion,
                             EquipoJugador = J.jugador_equipo

                         });
            return query.ToList();
        }

    }
}