using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndioMendoza2013.Modelos;
using System.Configuration;
using IndioMendoza2013.Datos;

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

    }
}
