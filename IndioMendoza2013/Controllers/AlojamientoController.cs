using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Facebook;
using DatosIndioMendoza2013;
using IndioMendoza2013.Modelos;
using System.Globalization;

namespace IndioMendoza2013.Controllers
{
    public class AlojamientoController : Controller
    {
        //
        // GET: /Alojamiento/

        public ActionResult Index()
        {
            ViewBag.MenuSeleccionado = "ALOJAMIENTO";
            
            var servAlojamientos = new AlojamientoService();

            var ListTipos = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };
            //ListTipos.Add(new ParDeValores() { id = -1, descripcion = "Seleccione uno" });
            ListTipos.AddRange(servAlojamientos.GetTiposAlojamiento().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

            ViewBag.ListTipos = ListTipos;

            return View(new FiltroAlojamiento());
        }

        public ActionResult Buscar(FiltroAlojamiento filtro)
        {
            var serv = new AlojamientoService();
            var resultOrd = serv.GetAlojamientos(filtro).OrderBy(x => x.Nombre);

            var longPag = Int32.Parse(System.Configuration.ConfigurationManager.AppSettings["AlojamientosPorPagina"]);

            Double cantPag = ((Double)resultOrd.Count()) / longPag;
            var result = resultOrd.Skip((filtro.Pagina - 1) * longPag).Take(longPag);

            var cantPagReal = Math.Truncate(cantPag);

            if ((cantPag - cantPagReal) > 0)
                cantPagReal += 1;

            ViewBag.CantPaginas = (int)cantPagReal;
            ViewBag.Pagina = filtro.Pagina;

            return PartialView("ResultadosAlojamientos", result);
        }

        public ActionResult Agregar()
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

            if (permiteAcceso)
            {
                var servAlojamientos = new AlojamientoService();

                var ListTipos = new List<ParDeValores>();
                //ListTipos.Add(new ParDeValores() { id = -1, descripcion = "Seleccione uno" });
                ListTipos.AddRange(servAlojamientos.GetTiposAlojamiento().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

                ViewBag.ListTipos = ListTipos;

                return View();
            }
            return new EmptyResult();
        }

        public void AgregarAlojamiento(modAlojamiento alojamiento)
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

            if (permiteAcceso)
            {
                alojamiento.Latitud = Double.Parse(Request.Params["Latitud"], CultureInfo.InvariantCulture);
                alojamiento.Longitud = Double.Parse(Request.Params["Longitud"], CultureInfo.InvariantCulture);

                alojamiento.CenterLat = Double.Parse(Request.Params["CenterLat"], CultureInfo.InvariantCulture);
                alojamiento.CenterLong = Double.Parse(Request.Params["CenterLong"], CultureInfo.InvariantCulture);

                var serv = new AlojamientoService();
                serv.AgregarAlojamiento(alojamiento);
           }

        }

        public ActionResult AgregarTipoAlojamiento()
        {
            return PartialView();
        }


        public void GuardarTipoAlojamiento(modTipoAlojamiento model)
        {
            var servUbicaciones = new AlojamientoService();
            servUbicaciones.AddTipoAlojamiento(model);
        }

        public ActionResult UbicacionAlojamiento(int id)
        {
            var serv = new AlojamientoService();

            var alojamiento = serv.GetAlojamiento(id);
            return PartialView(alojamiento);
        }
    }
}
