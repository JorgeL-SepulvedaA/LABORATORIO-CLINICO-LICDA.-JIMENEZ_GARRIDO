using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace BusinessLayer
{
    public class TipoUsuarioRepository
    {
        private LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();

        public void Add(Tipo_Resultados tipo_Resultado)
        {
            _ENTITIES.Tipo_Resultados.Add(tipo_Resultado);
            _ENTITIES.SaveChanges();
        }
    }
}
