using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class TipoResultado
    {
        private static LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();

        public static List<Tipo_Resultados> GetAll()
        {
            return _ENTITIES.Tipo_Resultados.ToList();
        }

        public static Tipo_Resultados GetById(int Id)
        {
            Tipo_Resultados Tresultados = _ENTITIES.Tipo_Resultados.Find(Id) != null ? _ENTITIES.Tipo_Resultados.Find(Id) : null;
            return Tresultados;
        }
    }
}
