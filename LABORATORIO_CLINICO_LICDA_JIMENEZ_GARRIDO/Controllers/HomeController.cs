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

        public ActionResult Index()
        {
            return View();
        }

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
                    return RedirectToAction("AxuliarView", "Interfaces");
                }
                else if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Cliente))
                {
                    return RedirectToAction("ClienteView", "Interfaces");
                }
                else
                {
                    return RedirectToAction("MasterA_View", "Interfaces");
                }
            }

            return View();
        }
    }
}