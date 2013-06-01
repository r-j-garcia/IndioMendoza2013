using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatosIndioMendoza2013;
using System.Configuration;
using IndioMendoza2013.Modelos;
using Facebook;

namespace IndioMendoza2013.Controllers
{
    public class ContactoController : Controller
    {
        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            ViewBag.MenuSeleccionado = "CONTACTO";
            var model = new modContacto();
            return View(model);
        }

        public void Enviar(modContacto model)
        {
            var servContacto = new ContactoService();
            model.Leido = false;
            servContacto.AddContacto(model);
        }

        public ActionResult Listado()
        {
            bool permiteAcceso = ObtenerPermisos();

            if (permiteAcceso)
            {
                var model = new FiltroContacto();
                model.Leido = false;
                return View(model);
            }
            return new EmptyResult();
        }

        private bool ObtenerPermisos()
        {
            bool permiteAcceso = false;
            Boolean debug = Boolean.Parse(ConfigurationManager.AppSettings["debug"]);

            permiteAcceso = debug;

            if (Session["AccessToken"] != null)
            {
                var accessToken = Session["AccessToken"].ToString();
                var client = new FacebookClient(accessToken);
                dynamic result = client.Get("me", new { fields = "id" });

                if (result.id == "100002979715059")
                {
                    permiteAcceso = true;
                }
            }
            return permiteAcceso;
        }

        public ActionResult ResultadoContacto(FiltroContacto filtro)
        {
            bool permiteAcceso = ObtenerPermisos();

            if (permiteAcceso)
            {
                var servContacto = new ContactoService();
                var list = servContacto.GetContactos(filtro);
                return PartialView(list);
            }

            return new EmptyResult();
        }

        public void MarcarComoLeidos(IEnumerable<int> lst)
        {
            var servContacto = new ContactoService();
            servContacto.MarcarComoLeidos(lst);
        }

    }
}
