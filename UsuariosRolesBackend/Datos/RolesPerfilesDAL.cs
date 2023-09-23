using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRolesBackend.Entidades;
using YibTronBackend.Datos.Repositorios.Implementacion;

namespace UsuariosRolesBackend.Datos
{
    public class RolesPerfilesDAL : RepositorioImplTablaDAL<RolesPerfilesInfo, RolesPerfilesInfo.ColumnasBD>
    {
        #region Constructor...
        public RolesPerfilesDAL()
        {
            NombreTabla = "Roles_Perfiles";
        }
        #endregion Constructor
    }
}
