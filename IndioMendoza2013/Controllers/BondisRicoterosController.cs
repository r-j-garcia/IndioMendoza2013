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
            var servUbicaciones = new UbicacionesService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            var listaProvincias =  new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };
            listaProvincias.AddRange(servUbicaciones.GetProvincias().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

            ViewBag.ListProvincias = listaProvincias;
            ViewBag.ListZonas = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };

            return View();
        }

        public ActionResult GetZonas(int idProvincia)
        {
            var servUbicaciones = new UbicacionesService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            var listaZonas = new List<ParDeValores>();// { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };

            listaZonas.AddRange(servUbicaciones.GetZonas(idProvincia).Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));
            return Json(
                listaZonas, JsonRequestBehavior.AllowGet
            );
        }

        public ActionResult Buscar(FiltroBondisRicoteros filtro)
        {
            var serv = new BondisRicoterosService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            var result = serv.GetBondisRicoteros(filtro);

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
                var servUbicaciones = new UbicacionesService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

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
            if (Session["AccessToken"] != null)
            {
                var accessToken = Session["AccessToken"].ToString();
                var client = new FacebookClient(accessToken);
                dynamic result = client.Get("me", new { fields = "id" });

                if (result.id == "100002979715059")
                {
                    var serv = new BondisRicoterosService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                    serv.AgregarBondi(bondi);
                }
            }
        }

        public ActionResult DetalleBondi(int id)
        {
            var serv = new BondisRicoterosService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            var bondi = serv.GetBondiRicotero(id);
            return PartialView(bondi);
        }

        public ActionResult AgregarProvincia()
        {
            return PartialView();
        }

        public void GuardarProvincia(modProvincia model)
        {
            var servUbicaciones = new UbicacionesService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            servUbicaciones.AddProvincia(model);
        }

        public ActionResult AgregarZona()
        {
            var servUbicaciones = new UbicacionesService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            var listaProvincias = new List<ParDeValores>(); 
            listaProvincias.AddRange(servUbicaciones.GetProvincias().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

            ViewBag.ListProvincias = listaProvincias;

            return PartialView();
        }

        public void GuardarZona(modZona model)
        {
            var servUbicaciones = new UbicacionesService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            servUbicaciones.AddZona(model);
        }

    }
}
