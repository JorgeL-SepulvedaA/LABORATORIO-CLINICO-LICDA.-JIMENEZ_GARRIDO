using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO.Models
{
    public sealed class IsLoged
    {
        private IsLoged()
        {
        }
        public static IsLoged Instance { get; set; } = new IsLoged();
        public bool isLoged { get; set; }
        public ActionResult Log_Checking(ActionResult forTrue, ActionResult forFalse)
        {
            return isLoged ? forTrue : forFalse;
        }
    }
}