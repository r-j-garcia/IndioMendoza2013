using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.Modelos;

namespace IndioMendoza2013.Datos
{
    public class UbicacionesService : ServicioBase
    {
        public UbicacionesService(string strConexion)
            : base(strConexion)
        {
        }

        public IEnumerable<modProvincia> GetProvincias()
        {
            var busqueda = from pr in bd.Provincia
                           select new modProvincia() { provinciaDB = pr }
                           ;

            return busqueda;
        }

        public IEnumerable<modZona> GetZonas(int idProvincia)
        {
            var busqueda = from z in bd.Zona
                           where z.id_provincia == idProvincia
                           select new modZona() { zonaDB = z }
                           ;

            return busqueda;
        }
    }
}
