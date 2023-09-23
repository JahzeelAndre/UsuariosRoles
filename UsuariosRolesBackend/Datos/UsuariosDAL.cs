using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRolesBackend.Entidades;
using YibTronBackend.Datos.Repositorios.Implementacion;

namespace UsuariosRolesBackend.Datos
{
    public class UsuariosDAL : RepositorioImplTablaDAL<UsuariosInfo, UsuariosInfo.ColumnasBD>
    {
        #region Constructor...
        public UsuariosDAL()
        {
            NombreTabla = "Usuarios";
        }
        #endregion Constructor
    }
}
