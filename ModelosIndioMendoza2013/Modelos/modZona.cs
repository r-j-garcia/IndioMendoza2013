using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;

namespace IndioMendoza2013.Modelos
{
    public class modZona
    {
        public Zona zonaDB { get; set; }

        public modZona()
        {
            this.zonaDB = new Zona();
        }

        public modZona(OrigenesDeDatos.Zona z)
        {
            this.zonaDB = z;
        }

        public int ID
        {
            get { return this.zonaDB.id; }
            set { this.zonaDB.id = value; }
        }

        public int Id_Provincia
        {
            get { return this.zonaDB.id_provincia; }
            set { this.zonaDB.id_provincia = value; }
        }

        public string Descripcion
        {
            get { return this.zonaDB.descripcion; }
            set { this.zonaDB.descripcion = value; }
        }


    }
}
