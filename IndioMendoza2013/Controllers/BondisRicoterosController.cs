using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndioMendoza2013.Modelos;
using System.Configuration;
using IndioMendoza2013.Datos;
using Facebook;

namespace IndioMendoza2013.Controllers
{
    public class BondisRicoterosController : Controller
    {
        //
        // GET: /BondisRicoteros/

        public ActionResult Index()
        {
            ViewBag.MenuSeleccionado = "BONDI";
            //Falta instanciar el servicio correctamente
            var servUbicaciones = new UbicacionesService();

            var listaProvincias = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };
            listaProvincias.AddRange(servUbicaciones.GetProvincias().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

            ViewBag.ListProvincias = listaProvincias;
            ViewBag.ListZonas = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };

            return View();
        }

        public ActionResult GetZonasByID(int idProvincia)
        {
            var servUbicaciones = new UbicacionesService();
            var listaZonas = new List<ParDeValores>();// { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };

            listaZonas.AddRange(servUbicaciones.GetZonas(idProvincia).Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));
            return Json(
                listaZonas, JsonRequestBehavior.AllowGet
            );
        }

        public ActionResult GetZonas(IEnumerable<int> idProvincias)
        {
            var servUbicaciones = new UbicacionesService();
            var listaZonas = new List<ParDeValores>();// { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };

            listaZonas.AddRange(servUbicaciones.GetZonas(idProvincias).Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

            ViewBag.ListZonas = listaZonas;

            return PartialView("ComboZonas", new modBondiRicotero());
        }

        public ActionResult Buscar(FiltroBondisRicoteros filtro)
        {
            var serv = new BondisRicoterosService();
            var result = serv.GetBondisRicoteros(filtro);

            var longPag = Int32.Parse(System.Configuration.ConfigurationManager.AppSettings["BondisPorPagina"]);

            ViewBag.ResultadosTotales = result.Count();

            Double cantPag = ((Double)result.Count()) / longPag;
            

            var cantPagReal = Math.Truncate(cantPag);

            if ((cantPag - cantPagReal) > 0)
                cantPagReal += 1;

            ViewBag.CantPaginas = (int)cantPagReal;
            filtro.Pagina = filtro.Pagina == 0 || cantPagReal < filtro.Pagina ? 1 : filtro.Pagina;
            ViewBag.Pagina = filtro.Pagina;
            result = result.Skip((filtro.Pagina - 1) * longPag).Take(longPag);

            return PartialView("ResultadosBondisRicoteros", result);
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
                var servUbicaciones = new UbicacionesService();

                var listaProvincias = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };
                listaProvincias.AddRange(servUbicaciones.GetProvincias().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

                ViewBag.ListProvincias = listaProvincias;
                ViewBag.ListZonas = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } }

                return View();
            }
            return new EmptyResult();
        }

        public void AgregarBondi(modBondiRicotero bondi)
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
                var serv = new BondisRicoterosService();
                bondi.LstIdZonas = bondi.LstIdZonasStr.Split(',').Select(x => int.Parse(x)).ToList();
                bondi.Descripcion = bondi.Descripcion.Replace("\n", "<br>");
                serv.AgregarBondi(bondi);
            }
        }

        public ActionResult DetalleBondi(int id)
        {
            var serv = new BondisRicoterosService();

            var bondi = serv.GetBondiRicotero(id);
            return PartialView(bondi);
        }

        public ActionResult AgregarProvincia()
        {
            return PartialView();
        }

        public void GuardarProvincia(modProvincia model)
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
                var servUbicaciones = new UbicacionesService();
                servUbicaciones.AddProvincia(model);
            }
        }

        public ActionResult AgregarZona()
        {
            var servUbicaciones = new UbicacionesService();
            var listaProvincias = new List<ParDeValores>();
            listaProvincias.AddRange(servUbicaciones.GetProvincias().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

            ViewBag.ListProvincias = listaProvincias;

            return PartialView();
        }

        public void GuardarZona(modZona model)
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
                var servUbicaciones = new UbicacionesService();
                servUbicaciones.AddZona(model);
            }
        }

        public ActionResult MensajeTemporalEnConstruccion()
        {
            return PartialView();
        }

        public ActionResult GraciasPorParticipar()
        {
            return PartialView();
        }
    }
}
