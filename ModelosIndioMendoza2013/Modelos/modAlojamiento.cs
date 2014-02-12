using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;
using System.ComponentModel.DataAnnotations;

namespace IndioMendoza2013.Modelos
{
    public class modAlojamiento
    {
        public Alojamiento alojamientoDB {get; set;}

        public modAlojamiento()
        {
            this.alojamientoDB = new Alojamiento();
        }

        public modAlojamiento(Alojamiento pr)
        {
            this.alojamientoDB = pr;
        }

        public int ID
        {
            get { return this.alojamientoDB.id; }
            set { this.alojamientoDB.id = value; }
        }

        [Required(ErrorMessage="El nombre es obligatorio")]
        public string Nombre
        {
            get { return this.alojamientoDB.nombre; }
            set { this.alojamientoDB.nombre = value; }
        }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion
        {
            get { return this.alojamientoDB.descripcion; }
            set { this.alojamientoDB.descripcion = value; }
        }

        [Required()]
        public int Zoom
        {
            get { return this.alojamientoDB.zoom; }
            set { this.alojamientoDB.zoom = value; }
        }

        [Required()]
        public double Latitud
        {
            get { return this.alojamientoDB.latitud; }
            set { this.alojamientoDB.latitud = value; }
        }

        [Required()]
        public double Longitud
        {
            get { return this.alojamientoDB.longitud; }
            set { this.alojamientoDB.longitud = value; }
        }

        public string Pagina
        {
            get { return this.alojamientoDB.pagina; }
            set { this.alojamientoDB.pagina = value; }
        }

        public string Mail
        {
            get { return this.alojamientoDB.mail; }
            set { this.alojamientoDB.mail = value; }
        }

        public string Telefono
        {
            get { return this.alojamientoDB.telefono; }
            set { this.alojamientoDB.telefono = value; }
        }

        [Required()]
        public int IdTipo
        {
            get { return this.alojamientoDB.id_tipo; }
            set { this.alojamientoDB.id_tipo = value; }
        }

        [Required()]
        public double CenterLat
        {
            get { return this.alojamientoDB.center_lat; }
            set { this.alojamientoDB.center_lat = value; }
        }

        [Required()]
        public double CenterLong
        {
            get { return this.alojamientoDB.center_long; }
            set { this.alojamientoDB.center_long = value; }
        }

        public String DesTipo { get; set; }
    }
}
