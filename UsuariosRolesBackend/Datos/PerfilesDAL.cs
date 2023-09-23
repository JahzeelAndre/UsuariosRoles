using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosRolesBackend.Entidades;
using YibTronBackend.Datos.Repositorios.Implementacion;

namespace UsuariosRolesBackend.Datos
{
    public class PerfilesDAL : RepositorioImplTablaDAL<PerfilesInfo, PerfilesInfo.ColumnasBD>
    {
        #region Constructor...
        public PerfilesDAL()
        {
            NombreTabla = "Perfiles";
        }
        #endregion Constructor
    }
}
