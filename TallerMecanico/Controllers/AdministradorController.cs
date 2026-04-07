using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TallerMecanico.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminDash()
        {
            return View();
        }
        public ActionResult Trabajdash()
        {
            return View();
        }
        public ActionResult cliendash()
        {
            return View();
        }
    }

}