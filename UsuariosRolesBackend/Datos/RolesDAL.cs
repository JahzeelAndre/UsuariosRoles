using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRolesBackend.Entidades;
using YibTronBackend.Datos.Repositorios.Implementacion;

namespace UsuariosRolesBackend.Datos
{
    public class RolesDAL : RepositorioImplTablaDAL<RolesInfo, RolesInfo.ColumnasBD>
    {
        #region Constructor...
        public RolesDAL()
        {
            NombreTabla = "Roles";
        }
        #endregion Constructor
    }
}
