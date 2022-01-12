using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseLayer;
using LogicLayer;


namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult LogIn()
        {
            return View();
        }

        #region defautl

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        public ActionResult LogOut()
        {
            return View();
        }

        // GET: Usuario
        [HttpPost]
        public ActionResult Interfaces(string n_usuario, string contraseña)
        {
            foreach (var datos in GeneralManagement.GetAll())
            {
                if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.MasterA))
                {
                    return RedirectToAction("MasterA_View", "Interfaces");
                }
                else if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.MasterB))
                {
                    return RedirectToAction("MasterB_View", "Interfaces");
                }
                else if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Administrador))
                {
                    return RedirectToAction("AdministradorView", "Interfaces");
                }
                else if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Auxiliar))
                {
                    return RedirectToAction("AuxiliarView", "Interfaces");
                }
                else if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Cliente))
                {
                    return RedirectToAction("ClienteView", "Interfaces");
                }
                else
                {
                    return RedirectToAction("MasterView", "Interfaces");
                }
            }

            return View();
        }
    }
}