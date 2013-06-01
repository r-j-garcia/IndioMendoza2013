using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.Modelos;
using IndioMendoza2013.OrigenesDeDatos;
using System.Configuration;

namespace IndioMendoza2013.Datos
{

    public class PosicionesRicoterasService : ServicioBase
    {
        public PosicionesRicoterasService(string strConexion) : base (strConexion)
        {
        }

        public PosicionesRicoterasService()
            : base()
        {
        }

        public IEnumerable<modPosicionRicotera> GetPosicionesRicoteras()
        {
            var busqueda = from pr in bd.PosicionRicotera
                           select new modPosicionRicotera() { posicionRicoteraDB = pr}
                           ;

            return busqueda;
        }

        public void Guardar(modPosicionRicotera posicion)
        {
            if (this.ValidarIP(posicion))
            {
                bd.AddToPosicionRicotera(posicion.posicionRicoteraDB);

                bd.SaveChanges();
            }
            else
            {
                throw new ApplicationException("Solo se pueden cargar hasta 5 puntos de partida por IP");
            }
        }

        private bool ValidarIP(modPosicionRicotera posicion)
        {
            Boolean debug = Boolean.Parse(ConfigurationManager.AppSettings["debug"]);
            var posiciones = (from PR in bd.PosicionRicotera where PR.ip == posicion.IP select PR).Count();
            return debug || posiciones <= 5;
        }

    }
}
