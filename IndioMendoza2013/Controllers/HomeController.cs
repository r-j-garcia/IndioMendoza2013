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
            var serv = new PosicionesRicoterasService(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            var lista = serv.GetPosicionesRicoteras();

            return Json(lista);
        }

        public ActionResult FacebookInfo()
        {
            modFacebookInfo facInfo = null;
            if (Session["AccessToken"] != null)
            {
                facInfo = new modFacebookInfo();
                var accessToken = Session["AccessToken"].ToString();

                var client = new FacebookClient(accessToken);
                dynamic result = client.Get("me", new { fields = "name,link" });
                facInfo.Nombre = result.name;
                facInfo.Link = result.link;
            }

            return PartialView("FacebookInfo", facInfo);
        }

        public void SaveFacebookToken(String Token)
        {
            Session["AccessToken"] = Token;
        }
    }
}
