using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.Modelos;
using IndioMendoza2013.OrigenesDeDatos;

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
                           select br;

            if (!string.IsNullOrEmpty(fbr.Nombre))
            {
                busqueda = from br in busqueda
                           where br.nombre.Contains(fbr.Nombre)
                           select br;
            }

            if (fbr.id_zona.HasValue)
            {
                busqueda = from br in busqueda
                           from zo in br.Zona
                           where zo.id == fbr.id_zona.Value
                           select br;
            }
            else if (fbr.id_provincia.HasValue)
            {
                busqueda = from br in busqueda
                           from zo in br.Zona
                           join pr in bd.Provincia on zo.id_provincia equals pr.id
                           where pr.id == fbr.id_provincia.Value
                           select br;
            }

            return busqueda.ToList().Distinct(new BondiComparer()).Select(x => new modBondiRicotero()
            {
                bondiRicoteroDB = x
            });
        }


        public void AgregarBondi(modBondiRicotero bondi)
        {
            foreach (var item in (from zo in bd.Zona where bondi.LstIdZonas.Contains(zo.id) select zo))
            {
                bondi.bondiRicoteroDB.Zona.Add(item);
            }
            bd.AddToBondiRicotero(bondi.bondiRicoteroDB);
            bd.SaveChanges();
        }

        public modBondiRicotero GetBondiRicotero(int id)
        {
            modBondiRicotero bondi = null;

            var busqueda = (from br in bd.BondiRicotero
                            where br.id == id
                            select br).FirstOrDefault();

            if (busqueda != null)
            {
                bondi = new modBondiRicotero(busqueda);
            }

            return bondi;
        }


    }

    public class BondiComparer : IEqualityComparer<BondiRicotero>
    {
        public bool Equals(BondiRicotero x, BondiRicotero y)
        {
            return (x.id == y.id);
        }

        public int GetHashCode(BondiRicotero x)
        {
            return x.id;
        }

    }
}
