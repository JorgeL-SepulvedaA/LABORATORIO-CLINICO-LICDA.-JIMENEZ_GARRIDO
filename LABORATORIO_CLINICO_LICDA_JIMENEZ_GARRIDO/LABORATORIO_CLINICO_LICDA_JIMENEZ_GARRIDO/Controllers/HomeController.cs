using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Models;


namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult LogIn()
        {
            return View();
        }

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
        // GET: Usuario
        [HttpPost]
        public ActionResult Interfaces(string n_usuario, string contraseña)
        {
            LABORATORIO_CLINICO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_ENTITIES();
            /*List<Usuario> usuarios = _ENTITIES.Usuarios.ToList();*/
            
            foreach (var datos in _ENTITIES.Usuarios.ToList())
            {
                if ((datos.Nombre_Usuario == n_usuario || datos.Correo == n_usuario) && datos.Contraseña == contraseña && datos.Tipo_Usuario == ((int)EnumTipoUsuarios.Master))
                {
                    return RedirectToAction("MasterView", "Interfaces");
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
                    return RedirectToAction("Contact", "Home");
                }
            }

            return View();
        }

        /*public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        */
    }
}