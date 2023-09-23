using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRolesBackend.Entidades;
using YibTronBackend.Datos.Repositorios.Implementacion;

namespace UsuariosRolesBackend.Datos
{
    public class OperacionesModulosDAL : RepositorioImplTablaDAL<OperacionesModulosInfo, OperacionesModulosInfo.ColumansBD>
    {
        #region Constructor...
        public OperacionesModulosDAL()
        {
            NombreTabla = "Operaciones_Modulos";
        }
        #endregion Constructor
    }
}
