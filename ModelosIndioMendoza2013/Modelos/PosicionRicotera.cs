using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;
using System.ComponentModel.DataAnnotations;

namespace IndioMendoza2013.Modelos
{
    public class modPosicionRicotera
    {
        public PosicionRicotera posicionRicoteraDB {get; set;}

        public modPosicionRicotera()
        {
            this.posicionRicoteraDB = new PosicionRicotera();
        }

        public modPosicionRicotera(OrigenesDeDatos.PosicionRicotera pr)
        {
            this.posicionRicoteraDB = pr;
        }

        public int ID
        {
            get { return this.posicionRicoteraDB.id; }
            set { this.posicionRicoteraDB.id = value; }
        }

        [Required(ErrorMessage="El nombre es obligatorio")]
        public string Nombre
        {
            get { return this.posicionRicoteraDB.nombre; }
            set { this.posicionRicoteraDB.nombre = value; }
        }

        [Required()]
        public double Latitud
        {
            get { return this.posicionRicoteraDB.latitude; }
            set { this.posicionRicoteraDB.latitude = value; }
        }

        [Required()]
        public double Longitud
        {
            get { return this.posicionRicoteraDB.longitude; }
            set { this.posicionRicoteraDB.longitude = value; }
        }

        public string Comentarios
        {
            get { return this.posicionRicoteraDB.comentarios; }
            set { this.posicionRicoteraDB.comentarios = value; }
        }

        public string IP
        {
            get { return this.posicionRicoteraDB.ip; }
            set { this.posicionRicoteraDB.ip = value; }
        }
    }
}
