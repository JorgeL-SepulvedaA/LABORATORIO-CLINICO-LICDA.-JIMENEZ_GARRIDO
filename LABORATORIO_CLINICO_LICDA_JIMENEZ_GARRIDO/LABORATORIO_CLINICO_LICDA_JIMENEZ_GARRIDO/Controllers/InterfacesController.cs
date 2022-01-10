using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Controllers
{
    public class InterfacesController : Controller
    {
        // GET: Interfaces
        public ActionResult MasterView()
        {
            return View();
        }
        public ActionResult AdministradorView()
        {
            return View();
        }
        public ActionResult AxuliarView()
        {
            return View();
        }
        public ActionResult ClienteView()
        {
            return View();
        }
    }
}