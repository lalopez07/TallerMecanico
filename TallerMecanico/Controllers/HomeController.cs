using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TallerMecanico.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Inventario()
        {
            return View();
        }
        public ActionResult Ordenes()
        {
            return View();
        }
        public ActionResult Pagos()
        {
            return View();
        }


        
    }
}

