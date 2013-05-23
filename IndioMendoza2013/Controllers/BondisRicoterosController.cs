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
            if (Session["AccessToken"] != null)
            {
                var accessToken = Session["AccessToken"].ToString();
                var client = new FacebookClient(accessToken);
                dynamic result = client.Get("me", new { fields = "id" });

                if (result.id == "100002979715059")
                {
                    var servUbicaciones = new UbicacionesService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                    var listaProvincias = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } };
                    listaProvincias.AddRange(servUbicaciones.GetProvincias().Select(x => new ParDeValores() { id = x.ID, descripcion = x.Descripcion }));

                    ViewBag.ListProvincias = listaProvincias;
                    ViewBag.ListZonas = new List<ParDeValores>(); // { new ParDeValores() { id = 0, descripcion = "Seleccionar.." } }

                    return View();
                }
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

        public ActionResult AgregarZona()
        {
            return PartialView();
        }

    }
}
