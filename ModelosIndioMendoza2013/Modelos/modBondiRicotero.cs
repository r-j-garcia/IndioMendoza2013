using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using IndioMendoza2013.OrigenesDeDatos;

namespace IndioMendoza2013.Modelos
{
    public class modBondiRicotero
    {
        public BondiRicotero bondiRicoteroDB { get; set; }

        public modBondiRicotero()
        {
            this.bondiRicoteroDB = new BondiRicotero();
        }

        public modBondiRicotero(OrigenesDeDatos.BondiRicotero br)
        {
            this.bondiRicoteroDB = br;
        }

        public int ID
        {
            get { return this.bondiRicoteroDB.id; }
            set { this.bondiRicoteroDB.id = value; }
        }

        public string Nombre
        {
            get { return this.bondiRicoteroDB.nombre; }
            set { this.bondiRicoteroDB.nombre = value; }
        }

        public string Descripcion
        {
            get { return this.bondiRicoteroDB.descripcion; }
            set { this.bondiRicoteroDB.descripcion = value; }
        }

        [AllowHtml()]
        public string Detalle
        {
            get { return this.bondiRicoteroDB.detalle; }
            set { this.bondiRicoteroDB.detalle = value; }
        }

        public List<modZona> Zonas
        {
            get { return this.bondiRicoteroDB.Zona.Select(x => new modZona(x)).ToList(); }
            set
            {
                foreach (var item in value)
                {
                    this.bondiRicoteroDB.Zona.Add(item.zonaDB);
                }
            }
        }

        public String ZonasStr
        {
            get
            {
                var zonas = string.Empty;
                foreach (var item in Zonas)
                {
                    zonas += item.Descripcion + ", ";
                }
                return zonas.Substring(0, zonas.Length -2);
            }
        }

        public List<int> LstIdZonas { get; set; }
        public String LstIdZonasStr { get; set; }

    }
}
