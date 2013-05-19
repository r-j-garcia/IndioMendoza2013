using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.Datos;
using IndioMendoza2013.Modelos;

namespace DatosIndioMendoza2013
{
    public class NoticiasService : ServicioBase
    {
        public NoticiasService(string strConexion)
            : base(strConexion)
        {
        }

        public IEnumerable<modNoticia> GetNoticias()
        {
            var busqueda = from n in bd.Noticias
                           select new modNoticia() { noticiaDB = n }
                           ;

            return busqueda;
        }

    }
}
