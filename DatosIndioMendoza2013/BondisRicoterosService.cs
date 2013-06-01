using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.Modelos;

namespace IndioMendoza2013.Datos
{
    public class BondisRicoterosService : ServicioBase
    {
        public BondisRicoterosService(string strConexion)
            : base(strConexion)
        {
        }

        public BondisRicoterosService()
            : base()
        {
        }

        public IEnumerable<modBondiRicotero> GetBondisRicoteros(FiltroBondisRicoteros fbr)
        {
            var busqueda = from br in bd.BondiRicotero
                           join zona in bd.Zona on br.id_zona equals zona.id
                           join provincia in bd.Provincia on zona.id_provincia equals provincia.id
                           select new {
                               entity = br,
                               zona = zona,
                               provincia = provincia
                           };

            if (!string.IsNullOrEmpty(fbr.Nombre))
            {
                busqueda = from br in busqueda
                           where br.entity.nombre.Contains(fbr.Nombre)
                           select br;
            }

            if (fbr.id_zona.HasValue)
            {
                busqueda = from br in busqueda
                           where br.entity.id_zona == fbr.id_zona.Value
                           select br;
            }
            else if (fbr.id_provincia.HasValue)
            {
                busqueda = from br in busqueda
                           where br.zona.id_provincia == fbr.id_provincia.Value
                           select br;
            }

            return busqueda.Select(x => new modBondiRicotero() { 
                bondiRicoteroDB = x.entity, 
                Des_Zona = x.zona.descripcion, 
                Id_Provincia = x.provincia.id, 
                Des_Provincia = x.provincia.descripcion 
            }) ;
        }


        public void AgregarBondi(modBondiRicotero bondi)
        {
            bd.AddToBondiRicotero(bondi.bondiRicoteroDB);
            bd.SaveChanges();
        }

        public modBondiRicotero GetBondiRicotero(int id)
        {
            modBondiRicotero bondi = null;

            var busqueda = (from br in bd.BondiRicotero
                           join zona in bd.Zona on br.id_zona equals zona.id
                           join provincia in bd.Provincia on zona.id_provincia equals provincia.id
                           where br.id == id
                           select new
                           {
                               entity = br,
                               zona = zona,
                               provincia = provincia
                           }).FirstOrDefault();

            if (busqueda != null)
            {
                bondi = new modBondiRicotero(busqueda.entity);
                bondi.Des_Provincia = busqueda.provincia.descripcion;
                bondi.Des_Zona = busqueda.zona.descripcion;
            }

            return bondi;
        }
    }
}
