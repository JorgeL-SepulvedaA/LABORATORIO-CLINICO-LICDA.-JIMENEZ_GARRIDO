using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using LogicLayer.MODELOS;

namespace DatabaseLayer
{
    public class ResultadoGetting
    {
        private static LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();
        private static Resultados_Cliente resultados = new Resultados_Cliente();

        public static List<ModeloResultados_Cliente> GetAll()
        {
            foreach (Resultados x in _ENTITIES.Resultados.ToList())
            {
                resultados.resultados_Clientes = new List<ModeloResultados_Cliente>
                {
                    new ModeloResultados_Cliente
                    {
                        Fecha = x.Fecha_Resultados.ToString(),
                        Tipo = x.Tipo_Resultados.Descripcion,
                        Archivo = x.Archivo
                    }
                };
            }

            return resultados.resultados_Clientes;
        }

        public static Resultados GetById(int Id_Resultado)
        {
            return _ENTITIES.Resultados.Find(Id_Resultado) != null ? _ENTITIES.Resultados.Find(Id_Resultado) : null;
        }
    }
}
