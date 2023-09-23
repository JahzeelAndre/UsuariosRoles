using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRolesBackend.Entidades;
using YibTronBackend.Datos.Repositorios.Implementacion;

namespace UsuariosRolesBackend.Datos
{
    public class OperacionesDAL : RepositorioImplTablaDAL<OperacionesInfo, OperacionesInfo.ColumnasBD>
    {
        #region Constructor...
        public OperacionesDAL()
        {
            NombreTabla = "Operaciones";
        }
        #endregion Constructor
    }
}
