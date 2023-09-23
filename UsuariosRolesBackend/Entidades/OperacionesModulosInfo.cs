
using YibTronBackend.Atributos.Campos;
using YibTronBackend.Interfaces.Entidades;

namespace UsuariosRolesBackend.Entidades
{
    public class OperacionesModulosInfo : IEntidad
    {
        #region Propiedades...
        public int Id { get; set; }
        public int IdOperacion {  get; set; }
        public int IdModulo { get; set; }
        public int IdPerfil { get; set; }
        #endregion Propiedades

        #region Columnas BD...
        public class ColumansBD
        {
            public const string Id = "Id";

            [ColumnaAtributte(nombre: IdOperacion, descripcion: "Columna con el id de la operación asignada.", tipo: ColumnaAtributte.ETipoCampo.ClaveForanea, permiteNulos: false, decimales: 0, valorUnico: false, ReferenciaTabla = "Operaciones")]
            public const string IdOperacion = "IdOperacion_OperacionesModulos";

            [ColumnaAtributte(nombre: IdModulo, descripcion: "Columna con el id del modulo asignado.", tipo: ColumnaAtributte.ETipoCampo.ClaveForanea, permiteNulos: false, decimales: 0, valorUnico: false, ReferenciaTabla = "Modulos")]
            public const string IdModulo = "IdModulo_OperacionesModulos";

            [ColumnaAtributte(nombre: IdPerfil, descripcion: "Columna con el id del perfil asignado.", tipo: ColumnaAtributte.ETipoCampo.ClaveForanea, permiteNulos: false, decimales: 0, valorUnico: false, ReferenciaTabla = "Perfiles")]
            public const string IdPerfil = "IdPerfil_OperacionesModulos";
        }
        #endregion Columnas BD
    }
}
