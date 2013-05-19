using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatosIndioMendoza2013;
using System.Configuration;

namespace IndioMendoza2013.Controllers
{
    public class NoticiasController : Controller
    {
        //
        // GET: /Noticias/

        public ActionResult Index()
        {
            var serv = new NoticiasService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            var lista = serv.GetNoticias();

            return View(lista);
        }

    }
}
