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

        public IEnumerable<modZona> GetZonas()
        {
            var busqueda = from z in bd.Zona
                           select new modZona() { zonaDB = z }
                           ;

            return busqueda;
        }

        public void AddProvincia(modProvincia model)
        {
            var id = (from z in bd.Provincia
                     orderby z.id descending
                     select z.id + 1).FirstOrDefault();

            model.ID = id;

            bd.AddToProvincia(model.provinciaDB);
            bd.SaveChanges();
        }

        public void AddZona(modZona model)
        {
            var id = (from z in bd.Zona
                      orderby z.id descending
                      select z.id + 1).FirstOrDefault();

            model.ID = id;
            bd.AddToZona(model.zonaDB);
            bd.SaveChanges();
        }
    }
}
