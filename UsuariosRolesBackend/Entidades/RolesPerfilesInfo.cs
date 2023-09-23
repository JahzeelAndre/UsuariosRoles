using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YibTronBackend.Atributos.Campos;
using YibTronBackend.Interfaces.Entidades;

namespace UsuariosRolesBackend.Entidades
{
    public class RolesPerfilesInfo : IEntidad
    {
        #region Propiedades...
        public int Id { get; set; }
        public int IdRol {  get; set; }
        public int IdPerfil { get; set; }
        #endregion Propiedades

        #region Columnas BD...
        public class ColumnasBD
        {
            public const string Id = "Id";

            [ColumnaAtributte(nombre: IdRol, descripcion: "Columna con el id del rol asignado al perfil.", tipo: ColumnaAtributte.ETipoCampo.ClaveForanea, permiteNulos: false, decimales: 0, valorUnico: false, ReferenciaTabla = "Roles")]
            public const string IdRol = "IdRol_RolesPerfiles";

            [ColumnaAtributte(nombre: IdPerfil, descripcion: "Columna con el id del perfil asignado al rol.", tipo: ColumnaAtributte.ETipoCampo.ClaveForanea, permiteNulos: false, decimales: 0, valorUnico: false, ReferenciaTabla = "Perfiles")]
            public const string IdPerfil = "IdPerfil_RolesPerfiles";
        }
        #endregion Columnas BD
    }
}
