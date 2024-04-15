using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jornadas.Controllers
{
    public class JornadaController : Controller
    {
        // GET: Jornada
        public ActionResult Index()
        {
            return View();
        }
    }
}