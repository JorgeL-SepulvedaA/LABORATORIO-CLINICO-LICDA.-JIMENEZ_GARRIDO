using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class GeneralManagement
    {
        private static LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();

        public static List<Usuarios> GetAll()
        {
            return _ENTITIES.Usuarios.ToList();
        }

        public static Usuarios GetById(int Id_Usuario)
        {
            Usuarios usuario = _ENTITIES.Usuarios.Find(Id_Usuario) != null ? _ENTITIES.Usuarios.Find(Id_Usuario) : null;
            return usuario;
        }
    }
}
