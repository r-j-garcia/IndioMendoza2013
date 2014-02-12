using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;

namespace IndioMendoza2013.Modelos
{
    public class modTipoAlojamiento
    {
        public Tipo_Alojamiento tipoAlojamientoDB {get; set;}

        public modTipoAlojamiento()
        {
            this.tipoAlojamientoDB = new Tipo_Alojamiento();
        }

        public modTipoAlojamiento(Tipo_Alojamiento ta)
        {
            this.tipoAlojamientoDB = ta;
        }

        public int ID
        {
            get { return this.tipoAlojamientoDB.id; }
            set { this.tipoAlojamientoDB.id = value; }
        }

        public string Descripcion
        {
            get { return this.tipoAlojamientoDB.descripcion; }
            set { this.tipoAlojamientoDB.descripcion = value; }
        }
    }
}
