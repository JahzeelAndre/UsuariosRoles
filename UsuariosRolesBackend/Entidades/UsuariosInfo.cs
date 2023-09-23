using YibTronBackend.Atributos.Campos;
using YibTronBackend.Interfaces.Entidades;

namespace UsuariosRolesBackend.Entidades
{
    public class UsuariosInfo : IEntidad
    {
        #region Propiedades...

        public int Id { get; set; }
        public required string NombreUsuario { get; set; }
        public required string Contraseña { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Correo { get; set; }
        public required DateTime FechaRegistro { get; set; }
        public required DateTime FechaUltimaSesion { get; set; }
        public int IdRol { get; set; }
        #endregion Propiedades

        #region Columnas BD...
        public class ColumnasBD
        {
            public const string Id = "Id";

            [ColumnaAtributte(nombre: NombreUsuario, descripcion: "Columna con el nombre de inicio del usuario.", tipo: ColumnaAtributte.ETipoCampo.Texto, tamaño: 20, permiteNulos: false, valorUnico: true)]
            public const string NombreUsuario = "NombreUsuario";

            [ColumnaAtributte(nombre: Contraseña, descripcion: "Columna con la contraseña del usuario.", tipo: ColumnaAtributte.ETipoCampo.Texto, tamaño: 200, permiteNulos: false, valorUnico: false)]
            public const string Contraseña = "Contraseña";

            [ColumnaAtributte(nombre: Nombre, descripcion: "Columna con el nombre real del usuario.", tipo: ColumnaAtributte.ETipoCampo.Texto, tamaño: 50, permiteNulos: false, valorUnico: false)]
            public const string Nombre = "Nombre";

            [ColumnaAtributte(nombre: Apellido, descripcion: "Columna con los apellidos del usuario.", tipo: ColumnaAtributte.ETipoCampo.Texto, tamaño: 50, permiteNulos: false, valorUnico: false)]
            public const string Apellido = "Apellido";

            [ColumnaAtributte(nombre: Correo, descripcion: "Columna con el correo del usuario.", tipo: ColumnaAtributte.ETipoCampo.Texto, tamaño: 100, permiteNulos: false, valorUnico: true)]
            public const string Correo = "Correo";

            [ColumnaAtributte(nombre: FechaRegistro, descripcion: "Columna con la fecha del registro del usuario.", tipo: ColumnaAtributte.ETipoCampo.FechaDate, permiteNulos: false)]
            public const string FechaRegistro = "FechaRegistro";

            [ColumnaAtributte(nombre: FechaUltimaSesion, descripcion: "Columna con la fecha del último inicio de sesión del usuario.", tipo: ColumnaAtributte.ETipoCampo.FechaDate, permiteNulos: true)]
            public const string FechaUltimaSesion = "FechaUltimaSesion";

            [ColumnaAtributte(nombre: IdRol, descripcion: "Columna con el id del rol asignado al usuario.", tipo: ColumnaAtributte.ETipoCampo.ClaveForanea, permiteNulos: false, decimales: 0, valorUnico: false, ReferenciaTabla = "Roles")]
            public const string IdRol = "IdRol_Usuarios";
        } 
        #endregion Columnas BD
    }
}
