using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersApp.Controllers
{
    public class CookiesController : Controller
    {
        // GET: Cookies
        public ActionResult Index()
        {
            if (HttpContext.Request.Cookies["color"] == null)
            {
                HttpCookie cookie = new HttpCookie("color", "red");
                cookie.Expires = DateTime.Now.AddDays(5.0);
                Response.Cookies.Add(cookie);
            }
            else
            {
                Response.Cookies.Add(HttpContext.Request.Cookies["color"]);
            }
            return View();
        }
    }
}