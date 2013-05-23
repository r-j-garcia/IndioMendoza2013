using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;

namespace IndioMendoza2013.Modelos
{
    public class modContacto
    {
        public Contacto contactoDB {get; set;}

        public modContacto()
        {
            this.contactoDB = new Contacto();
        }

        public modContacto(Contacto ct)
        {
            this.contactoDB = ct;
        }

        public int ID
        {
            get { return this.contactoDB.id; }
            set { this.contactoDB.id = value; }
        }

        public string Nombre
        {
            get { return this.contactoDB.nombre; }
            set { this.contactoDB.nombre = value; }
        }

        public string Contacto
        {
            get { return this.contactoDB.contacto1; }
            set { this.contactoDB.contacto1 = value; }
        }

        public string Consulta
        {
            get { return this.contactoDB.consulta; }
            set { this.contactoDB.consulta = value; }
        }

        public Boolean Leido
        {
            get { return this.contactoDB.leido; }
            set { this.contactoDB.leido = value; }
        }

    }
}
