using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivePsicologos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bem Vindo ao Live Psicologos";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
