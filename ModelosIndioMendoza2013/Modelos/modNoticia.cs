using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;
using System.ComponentModel.DataAnnotations;

namespace IndioMendoza2013.Modelos
{
    public class modNoticia
    {
        public Noticias noticiaDB { get; set; }

        public modNoticia()
        {
            this.noticiaDB = new Noticias();
        }

        public modNoticia(Noticias not)
        {
            this.noticiaDB = not;
        }

        public int ID
        {
            get { return this.noticiaDB.id; }
            set { this.noticiaDB.id = value; }
        }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Titulo
        {
            get { return this.noticiaDB.titulo; }
            set { this.noticiaDB.titulo = value; }
        }

        [Required()]
        public string Contenido
        {
            get { return this.noticiaDB.contenido; }
            set { this.noticiaDB.contenido = value; }
        }

        [Required()]
        public string Link
        {
            get { return this.noticiaDB.link; }
            set { this.noticiaDB.link = value; }
        }
    }
}
