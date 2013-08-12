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
                // check if cookie exists and if yes update
                HttpCookie existingCookie = Request.Cookies["AccessToken"];
                if (existingCookie != null)
                {
                    // force to expire it
                    existingCookie.Value = ("RRP").GetHashCode().ToString();
                    existingCookie.Expires = DateTime.Now.AddHours(-20);
                }

                // create a cookie
                HttpCookie newCookie = new HttpCookie("AccessToken", ("RRP").GetHashCode().ToString());
                newCookie.Expires = DateTime.Today.AddMonths(12);
                Response.Cookies.Add(newCookie);

                return Json(true);
            }
            return Json(false);
        }

    }
}
