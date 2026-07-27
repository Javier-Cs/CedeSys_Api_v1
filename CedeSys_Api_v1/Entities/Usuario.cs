using CedeSys_Api_v1.Entities.Enums;
namespace CedeSys_Api_v1.Entities
{
    
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public int IdEmpresa { get; set; }

        public string NombreUsuario { get; set; } = string.Empty;

        public RolUsuario Rol { get; set; }

        public string Email { get; set; } = string.Empty;

        public string PassHash { get; set; } = string.Empty;

        public string DireccionUsuario { get; set; } = string.Empty;

        public string CedulaUsuario { get; set; } = string.Empty;

        public string UrlImgUsuario { get; set; } = string.Empty;

        public bool EstadoUsuario { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? UltimoLogin { get; set; }

        public DateTime FechaCreacionUsuario { get; set; }

        public DateTime FechaModificacionUsuario { get; set; }
    }
}
