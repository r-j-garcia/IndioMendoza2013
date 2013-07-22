using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndioMendoza2013.Models;

namespace IndioMendoza2013.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Login(LoginModel login)
        {
            if (login.Contraseña == "rrp123456RRP654321")
            {
                Session["AccessToken"] = ("RRP").GetHashCode();
                return Json(true);
            }
            return Json(false);
        }

    }
}
