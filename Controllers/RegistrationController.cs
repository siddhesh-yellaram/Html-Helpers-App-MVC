using HtmlHelpersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPost(UserRegistration vm)
        {
            if (!this.ModelState.IsValid)
            {
                return View(vm);
            }

            string thankYouMsg = "Thank you for registering " + vm.Name;
            return Content(thankYouMsg);
        }
    }
}