﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseLayer;

namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Controllers
{
    public class ManagementController : Controller
    {
        // GENERAL : MANAGEMENT
        public ActionResult Usuarios_General()
        {
            var usuarios = from x in GeneralManagement.GetAll()
                           orderby x.Id
                           select x;
            return View(usuarios);
        }
        public ActionResult Usuarios_MasterA()
        {
            var masterA = from x in MasterAManagement.GetAll()
                          orderby x.Id
                          select x;
            return View(masterA);
        }
        public ActionResult Usuarios_MasterB()
        {
            var masterB = from x in MasterBManagement.GetAll()
                          orderby x.Id
                          select x;
            return View(masterB);
        }
        public ActionResult Usuarios_Administrador()
        {
            var administradores = from x in AdministradorManagement.GetAll()
                                  orderby x.Id
                                  select x;
            return View(administradores);
        }
        public ActionResult Usuarios_Auxiliar()
        {
            var auxiliares = from x in AuxiliarManagement.GetAll()
                             orderby x.Id
                             select x;
            return View(auxiliares);
        }
        public ActionResult Usuarios_Cliente()
        {
            var clientes = from x in ClienteManagement.GetAll()
                           orderby x.Id
                           select x;
            return View(clientes);
        }

        public ActionResult Resultados()
        {
            var resultados = from x in ResultadoManagement.GetAll()
                             orderby x.Id
                             select x;
            return View(resultados);
        }
        public ActionResult Resultados_Cliente()
        {
            var resultados = from x in ResultadoManagement.GetAll()
                             orderby x.Id
                             select x;
            return View(resultados);
        }

        // CRUD : USUARIOS
        public ActionResult Crear_Usuarios()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editar_Usuarios(int Id)
        {
            var resultados = GeneralManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Ver_Usuarios(int Id)
        {
            var resultados = GeneralManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Eliminar_Usuarios(int Id)
        {
            var resultados = GeneralManagement.GetById(Id);

            return View(resultados);
        }

        // CRUD : RESULTADOS
        public ActionResult Crear_Resultados()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editar_Resultados(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Ver_Resultados(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Eliminar_Resultados(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return View(resultados);
        }

        // CRUD : TIPOS DE USUARIOS
        public ActionResult Crear_TUsuarios()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editar_TUsuarios(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Ver_TUsuarios(int Id)
        {
            var resultados = GeneralManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Eliminar_TUsuarios(int Id)
        {
            var resultados = GeneralManagement.GetById(Id);

            return View(resultados);
        }

        // CRUD : TIPOS DE RESULTADOS
        public ActionResult Crear_TResultados()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editar_TResultados(int Id)
        {
            var resultados = ResultadoManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Ver_TResultados(int Id)
        {
            var resultados = GeneralManagement.GetById(Id);

            return View(resultados);
        }
        [HttpPost]
        public ActionResult Eliminar_TResultados(int Id)
        {
            var resultados = GeneralManagement.GetById(Id);

            return View(resultados);
        }
    }
}