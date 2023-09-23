
using UsuariosRolesBackend.Entidades;
using YibTronBackend.Datos.Repositorios.Implementacion;

namespace UsuariosRolesBackend.Datos
{
    public class ModulosDAL : RepositorioImplTablaDAL<ModulosInfo, ModulosInfo.ColumnasBD>
    {
        #region Constructor...
        public ModulosDAL()
        {
            NombreTabla = "Modulos";
        }
        #endregion Constructor
    }
}
