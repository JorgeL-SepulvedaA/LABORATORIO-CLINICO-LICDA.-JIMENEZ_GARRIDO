using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class ClienteManagement
    {
        private static LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();

        public static List<Usuarios> GetAll()
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            foreach (Usuarios x in _ENTITIES.Usuarios.ToList())
            {
                if (x.Tipo_Usuario == (int)EnumTipoUsuarios.Cliente)
                    usuarios.Add(x);
            }

            return usuarios;
        }

        public static Usuarios GetById(int Id_Usuario)
        {
            Usuarios usuario = _ENTITIES.Usuarios.Find(Id_Usuario);

            return usuario.Tipo_Usuario == (int)EnumTipoUsuarios.Cliente ? usuario : null;
        }
    }
}
