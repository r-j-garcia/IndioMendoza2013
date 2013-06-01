using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.Datos;
using IndioMendoza2013.Modelos;

namespace DatosIndioMendoza2013
{
    public class ContactoService : ServicioBase
    {
        public ContactoService(string strConexion)
            : base(strConexion)
        {
        }

        public ContactoService()
            : base()
        {
        }

        public void AddContacto(modContacto model)
        {
            var id = (from z in bd.Contacto
                      orderby z.id descending
                      select z.id + 1).FirstOrDefault();

            model.ID = id;

            bd.AddToContacto(model.contactoDB);

            bd.SaveChanges();
        }

        public IEnumerable<modContacto> GetContactos()
        {
            var busqueda = from c in bd.Contacto
                           select new modContacto() { contactoDB= c };

            return busqueda;
        }

        public IEnumerable<modContacto> GetContactos(FiltroContacto filtro)
        {
            var busqueda = from c in bd.Contacto
                           select c;

            if (!string.IsNullOrEmpty(filtro.Nombre))
            {
                busqueda = from c in busqueda
                           where c.nombre.Contains(filtro.Nombre)
                           select c;
            }

            if (!string.IsNullOrEmpty(filtro.Contacto))
            {
                busqueda = from c in busqueda
                           where c.contacto1.Contains(filtro.Contacto)
                           select c;
            }

            if (filtro.Leido.HasValue)
            {
                busqueda = from c in busqueda
                           where c.leido == filtro.Leido.Value
                           select c;
            }

            return busqueda.Select(x => new modContacto() { contactoDB = x });
        }

        public void MarcarComoLeidos(IEnumerable<int> lst)
        {
            var search = from c in bd.Contacto
                         where lst.Contains(c.id)
                         select c;

            foreach (var col in search)
            {
                col.leido = true;
            }

            bd.SaveChanges();
        }
    }
}
