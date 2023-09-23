using YibTronBackend.Atributos.Campos;
using YibTronBackend.Interfaces.Entidades;

namespace UsuariosRolesBackend.Entidades
{
    public class PerfilesInfo : IEntidad
    {
        #region Propiedades...
        public int Id { get; set; }
        public required string Nombre { get; set; }
        #endregion Propiedades

        #region Columnas BD...
        public class ColumnasBD
        {
            public const string Id = "Id";

            [ColumnaAtributte(nombre: Nombre, descripcion: "Columna con el nombre del perfil.", tipo: ColumnaAtributte.ETipoCampo.Texto, tamaño: 50, permiteNulos: false, valorUnico: true)]
            public const string Nombre = "Nombre";
        }
        #endregion
    }
}
