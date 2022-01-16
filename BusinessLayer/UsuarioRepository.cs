using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace BusinessLayer
{
    public class UsuarioRepository
    {
        private static LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES _ENTITIES = new LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO_ENTITIES();
        public void Add(Usuarios usuario)
        {
            _ENTITIES.Usuarios.Add(usuario);

        }
    }
}
