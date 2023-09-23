using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YibTronBackend.Entidades.Tablas;
using YibTronBackend.Negocio.Repositorios.Base;

namespace UsuariosRolesBackend.Negocio
{
    public class CrearBD : RepositorioBaseCrearBaseDatosBAL
    {
        public override string? CadenaConexion { get; set; }

        public override string obtenerDescripcionProyecto()
        {
            return "";
        }

        public override List<EstructuraTablaInfo>? obtenerEstructurasTablas()
        {
            return new List<EstructuraTablaInfo>()
            {
                new RolesBAL().obtenerEstructuraTabla(),
                new PerfilesBAL().obtenerEstructuraTabla(),
                new OperacionesBAL().obtenerEstructuraTabla(),
                new ModulosBAL().obtenerEstructuraTabla(),
                new UsuariosBAL().obtenerEstructuraTabla(),
                new RolesPerfilesBAL().obtenerEstructuraTabla(),
                new OperacionesModulosBAL().obtenerEstructuraTabla(),
            };
        }

        public override string obtenerNombreProyecto()
        {
            return "UsuariosRoles";
        }

        public override Task<int> generarBaseDeDatos()
        {
            return base.generarBaseDeDatos();
        }
    }
}
