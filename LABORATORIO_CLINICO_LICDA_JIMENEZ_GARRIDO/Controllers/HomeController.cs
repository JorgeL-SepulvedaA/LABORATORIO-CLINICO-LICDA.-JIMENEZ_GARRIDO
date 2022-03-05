using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseLayer;
using LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Models;


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
            n_usuario = Request.Form["email"];
            contraseña = Request.Form["password"];
            foreach (var datos in GeneralManagement.GetAll())
            {
                if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.MasterA))
                {
                    IsLoged.Instance.isLoged = true;
                    IsLoged.Instance.Id_Loged = datos.Id;
                    IsLoged.Instance.Nombre_Loged = datos.Nombre_Completo;

                    return RedirectToAction("MasterA_View", "Interfaces");
                }
                if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.MasterB))
                {
                    IsLoged.Instance.isLoged = true;
                    IsLoged.Instance.Id_Loged = datos.Id;
                    IsLoged.Instance.Nombre_Loged = datos.Nombre_Completo;

                    return RedirectToAction("MasterB_View", "Interfaces");
                }
                if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Administrador))
                {
                    IsLoged.Instance.isLoged = true;
                    IsLoged.Instance.Id_Loged = datos.Id;
                    IsLoged.Instance.Nombre_Loged = datos.Nombre_Completo;

                    return RedirectToAction("AdministradorView", "Interfaces");
                }
                if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Auxiliar))
                {
                    IsLoged.Instance.isLoged = true;
                    IsLoged.Instance.Id_Loged = datos.Id;
                    IsLoged.Instance.Nombre_Loged = datos.Nombre_Completo;

                    return RedirectToAction("AuxiliarView", "Interfaces");
                }
                if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Cliente))
                {
                    IsLoged.Instance.isLoged = true;
                    IsLoged.Instance.Id_Loged = datos.Id;
                    IsLoged.Instance.Nombre_Loged = datos.Nombre_Completo;

                    return RedirectToAction("ClienteView", "Interfaces");
                }
                else
                {
                    IsLoged.Instance.isLoged = false;
                    return RedirectToAction("Index", "Interfaces");
                }
            }

            return View();
        }
    }
}