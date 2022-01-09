using System.Web;
using System.Web.Mvc;

namespace LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
