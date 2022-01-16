using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseLayer;
using LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Models;
using System.IO;
using BusinessLayer;

namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Controllers
{
    public class ManagementController : Controller
    {
        // GENERAL : MANAGEMENT'S VIEW
        public ActionResult Usuarios_General()
        {
            var usuarios = from x in GeneralManagement.GetAll()
                           orderby x.Id
                           select x;
            return IsLoged.Instance.Log_Checking(View(usuarios), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult Usuarios_MasterA()
        {
            var masterA = from x in MasterAManagement.GetAll()
                          orderby x.Id
                          select x;
            return IsLoged.Instance.Log_Checking(View(masterA), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult Usuarios_MasterB()
        {
            var masterB = from x in MasterBManagement.GetAll()
                          orderby x.Id
                          select x;
            return IsLoged.Instance.Log_Checking(View(masterB), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult Usuarios_Administrador()
        {
            var administradores = from x in AdministradorManagement.GetAll()
                                  orderby x.Id
                                  select x;
            return IsLoged.Instance.Log_Checking(View(administradores), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult Usuarios_Auxiliar()
        {
            var auxiliares = from x in AuxiliarManagement.GetAll()
                             orderby x.Id
                             select x;
            return IsLoged.Instance.Log_Checking(View(auxiliares), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult Usuarios_Cliente()
        {
            var clientes = from x in ClienteManagement.GetAll()
                           orderby x.Id
                           select x;
            return IsLoged.Instance.Log_Checking(View(clientes), RedirectToAction("LogIn", "Home"));
        }

        public ActionResult Resultados()
        {
            var resultados = from x in ResultadoManagement.GetAll()
                             orderby x.Id
                             select x;
            return IsLoged.Instance.Log_Checking(View(resultados), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult Resultados_Cliente()
        {
            var resultados = from x in ResultadoManagement.GetAll()
                             orderby x.Id
                             select x;
            return IsLoged.Instance.Log_Checking(View(resultados), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult TipoUsuario()
        {
            var Tusuarios = from x in TipoUsuarioManagement.GetAll()
                             orderby x.Id
                             select x;
            return IsLoged.Instance.Log_Checking(View(Tusuarios), RedirectToAction("LogIn", "Home"));
        }
        public ActionResult TipoResultado()
        {
            var Tresultados = from x in TipoResultadoManagement.GetAll()
                             orderby x.Id
                             select x;
            return IsLoged.Instance.Log_Checking(View(Tresultados), RedirectToAction("LogIn", "Home"));
        }

        // CRUD : USUARIOS
        [HttpPost]
        public ActionResult Crear_Usuarios()
        {

            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Editar_Usuarios(int Id)
        {
            var usuarios = GeneralManagement.GetById(Id);

            return IsLoged.Instance.Log_Checking(View(usuarios), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Ver_Usuarios(int Id)
        {
            var usuarios = GeneralManagement.GetById(Id);

            return IsLoged.Instance.Log_Checking(View(usuarios), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Eliminar_Usuarios(int Id)
        {
            var usuarios = GeneralManagement.GetById(Id);

            return IsLoged.Instance.Log_Checking(View(usuarios), RedirectToAction("LogIn", "Home"));
        }

        // CRUD : RESULTADOS
        
        public ActionResult Crear_Resultados(HttpPostedFileBase fileBase)
        {
            if (fileBase != null)
            {
                FileContainerManagement fileContainer = new FileContainerManagement();

                string file = Path.GetFileName(fileBase.FileName);

                string ruta = fileContainer.FileUP(file);

                ResultadosRepository.Instance.Add(new Resultados { Fecha_Resultados = DateTime.Now, Archivo = ruta, Id_Auxiliar = IsLoged.Instance.Id_Loged, Id_Cliente = 1, Tipo_Resultado = 1 });
                return RedirectToAction("Resultados");
            }
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Editar_Resultados(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return IsLoged.Instance.Log_Checking(View(resultados), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Ver_Resultados(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return IsLoged.Instance.Log_Checking(View(resultados), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Eliminar_Resultados(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return IsLoged.Instance.Log_Checking(View(resultados), RedirectToAction("LogIn", "Home"));
        }

        // CRUD : TIPOS DE USUARIOS
        [HttpPost]
        public ActionResult Crear_TUsuarios()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Editar_TUsuarios(int Id)
        {
            var resultados = TipoUsuarioManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Ver_TUsuarios(int Id)
        {
            var resultados = TipoUsuarioManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Eliminar_TUsuarios(int Id)
        {
            var resultados = TipoUsuarioManagement.GetById(Id);

            return View(resultados);
        }

        // CRUD : TIPOS DE RESULTADOS
        [HttpPost]
        public ActionResult Crear_TResultados()
        {
            return IsLoged.Instance.Log_Checking(View(), RedirectToAction("LogIn", "Home"));
        }
        [HttpPost]
        public ActionResult Editar_TResultados(int Id)
        {
            var resultados = TipoResultadoManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Ver_TResultados(int Id)
        {
            var resultados = TipoResultadoManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Eliminar_TResultados(int Id)
        {
            var resultados = TipoResultadoManagement.GetById(Id);

            return View(resultados);
        }
    }
}