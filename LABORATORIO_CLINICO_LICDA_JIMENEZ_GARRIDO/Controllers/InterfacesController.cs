using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Models;

namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Controllers
{
    public class InterfacesController : Controller
    {
        // GET: Interfaces
        public ActionResult MasterA_View()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult MasterB_View()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult AdministradorView()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult AuxiliarView()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult ClienteView()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult Otras_Opciones()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
    }
}