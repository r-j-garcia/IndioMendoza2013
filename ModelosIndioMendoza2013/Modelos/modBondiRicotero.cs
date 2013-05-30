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
        public BondiRicotero bondiRicoteroDB {get; set;}

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

        public int Id_Zona
        {
            get { return this.bondiRicoteroDB.id_zona; }
            set { this.bondiRicoteroDB.id_zona = value; }
        }

        public string Des_Zona { get; set; }
        public int Id_Provincia { get; set; }
        public string Des_Provincia { get; set; }
    }
}
