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

            var serv = new PosicionesRicoterasService();

            ViewBag.CantidadDeRicoteros = serv.GetPosicionesRicoteras().Count();
            
            return View("MapaCompleto");
        }


        public ActionResult AgregaTuPuntoDePartida()
        {
            var model = new modPosicionRicotera();

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
