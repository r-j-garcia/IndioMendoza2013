using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndioMendoza2013.Modelos;
using System.Globalization;
using IndioMendoza2013.Datos;
using System.Configuration;
using Facebook;

namespace IndioMendoza2013.Controllers
{
    public class MapaRicoteroController : Controller
    {
        //
        // GET: /MapaRicotero/

        public ActionResult Index()
        {
            ViewBag.MenuSeleccionado = "MAPA";
            return View("MapaCompleto");
        }


        public ActionResult AgregaTuPuntoDePartida()
        {
            var model = new modPosicionRicotera();

            if (Session["AccessToken"] != null)
            {
                var accessToken = Session["AccessToken"].ToString();
                var client = new FacebookClient(accessToken);
                dynamic result = client.Get("me", new { fields = "name" });
                model.Nombre = result.name;
            }

            return View(model);
        }

        public ActionResult Guardar(modPosicionRicotera model)
        {
            try
            {
                var serv = new PosicionesRicoterasService();

                model.Latitud = Double.Parse(Request.Params["Latitud"], CultureInfo.InvariantCulture);
                model.Longitud = Double.Parse(Request.Params["Longitud"], CultureInfo.InvariantCulture);

                model.IP = Request.ServerVariables["REMOTE_ADDR"];

                serv.Guardar(model);

                return new EmptyResult();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
