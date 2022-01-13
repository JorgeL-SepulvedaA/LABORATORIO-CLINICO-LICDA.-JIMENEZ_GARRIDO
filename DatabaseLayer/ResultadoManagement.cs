using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class ResultadoManagement
    {
        private static LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();

        public static List<Resultados> GetAll()
        {
            return _ENTITIES.Resultados.ToList();
        }

        public static Resultados GetById(int Id_Resultado)
        {
            Resultados resultados = _ENTITIES.Resultados.Find(Id_Resultado) != null ? _ENTITIES.Resultados.Find(Id_Resultado) : null;
            return resultados;
        }
    }
}
