using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndioMendoza2013.Datos;
using System.Configuration;
using IndioMendoza2013.Modelos;
using Facebook;

namespace IndioMendoza2013.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.MenuSeleccionado = "HOME";
            return View();
        }

        public JsonResult GetPosiciones()
        {
            //Falta instanciar el servicio correctamente
            var serv = new PosicionesRicoterasService();

            var lista = serv.GetPosicionesRicoteras();

            return Json(lista);
        }

        public ActionResult FacebookInfo()
        {
            return PartialView("FacebookInfo");
        }

        //public void SaveFacebookToken(String Token)
        //{
        //    Request.Cookies["AccessToken"] = Token;
        //}
    }
}
