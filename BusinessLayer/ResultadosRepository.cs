using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace BusinessLayer
{
    public sealed class ResultadosRepository
    {
        private ResultadosRepository() { }

        public static ResultadosRepository Instance { get; set; } = new ResultadosRepository();
        
        private LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();

        public void Add(Resultados resultado)
        {
            _ENTITIES.Resultados.Add(resultado);
            _ENTITIES.SaveChanges();
        }
    }
}
