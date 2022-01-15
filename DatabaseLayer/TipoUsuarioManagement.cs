using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class TipoUsuarioManagement
    {
        private static LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();

        public static List<Tipo_Usuarios> GetAll()
        {
            return _ENTITIES.Tipo_Usuarios.ToList();
        }

        public static Tipo_Usuarios GetById(int Id)
        {
            Tipo_Usuarios Tusuario = _ENTITIES.Tipo_Usuarios.Find(Id) != null ? _ENTITIES.Tipo_Usuarios.Find(Id) : null;
            return Tusuario;
        }
    }
}
