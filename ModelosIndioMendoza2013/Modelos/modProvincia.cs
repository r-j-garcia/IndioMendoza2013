using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;

namespace IndioMendoza2013.Modelos
{
    public class modProvincia
    {
        public Provincia provinciaDB {get; set;}

        public modProvincia()
        {
            this.provinciaDB = new Provincia();
        }

        public modProvincia(OrigenesDeDatos.Provincia pr)
        {
            this.provinciaDB = pr;
        }

        public int ID
        {
            get { return this.provinciaDB.id; }
            set { this.provinciaDB.id = value; }
        }

        public string Descripcion
        {
            get { return this.provinciaDB.descripcion; }
            set { this.provinciaDB.descripcion = value; }
        }
    }
}
