using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult Usuarios_General()
        {
            return View();
        }
        public ActionResult Usuarios_Master()
        {
            return View();
        }
        public ActionResult Usuarios_Administrador()
        {
            return View();
        }
        public ActionResult Usuarios_Auxiliar()
        {
            return View();
        }
        public ActionResult Usuarios_Cliente()
        {
            return View();
        }

        public ActionResult Resultados()
        {
            return View();
        }
    }
}