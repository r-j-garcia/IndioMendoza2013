using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.Datos;
using IndioMendoza2013.Modelos;

namespace DatosIndioMendoza2013
{
    public class AlojamientoService : ServicioBase
    {
        public AlojamientoService(string strConexion)
            : base(strConexion)
        {
        }

        public AlojamientoService()
            : base()
        {
        }

        public IEnumerable<modAlojamiento> GetAlojamientos(FiltroAlojamiento fa)
        {
            var busqueda = from a in bd.Alojamiento
                           join ta in bd.Tipo_Alojamiento on a.id_tipo equals ta.id
                           select new { entity = a, tipo = ta };

            if (fa != null)
            {
                if (!string.IsNullOrEmpty(fa.Nombre))
                {
                    busqueda = from a in busqueda
                               where a.entity.nombre.Contains(fa.Nombre) || fa.Nombre.Contains(a.entity.nombre)
                               || a.entity.descripcion.Contains(fa.Nombre)
                               select a;
                }

                if (fa.IdTipo.HasValue)
                {
                    busqueda = from a in busqueda
                               where a.entity.id_tipo == fa.IdTipo.Value
                               select a;
                }
            }

            return busqueda.Select(x => new modAlojamiento()
            { 
                alojamientoDB = x.entity,
                DesTipo = x.tipo.descripcion
            }) ;
        }


        public void AgregarAlojamiento(modAlojamiento alojamiento)
        {
            bd.AddToAlojamiento(alojamiento.alojamientoDB);
            bd.SaveChanges();
        }

        public modAlojamiento GetAlojamiento(int id)
        {
            modAlojamiento alojamiento = null;

            var busqueda = (from a in bd.Alojamiento
                            join ta in bd.Tipo_Alojamiento on a.id_tipo equals ta.id
                            where a.id == id
                            select new { entity = a, tipo = ta }).FirstOrDefault();

            if (busqueda != null)
            {
                alojamiento = new modAlojamiento(busqueda.entity);
                alojamiento.DesTipo = busqueda.tipo.descripcion;
            }

            return alojamiento;
        }

        public IEnumerable<modTipoAlojamiento> GetTiposAlojamiento()
        {
            var busqueda = from pr in bd.Tipo_Alojamiento
                           select new modTipoAlojamiento() { tipoAlojamientoDB = pr }
                           ;

            return busqueda;
        }

        public void AddTipoAlojamiento(modTipoAlojamiento model)
        {
            bd.AddToTipo_Alojamiento(model.tipoAlojamientoDB);
            bd.SaveChanges();
        }
    }
}
