namespace CedeSys_Api_v1.Entities
{
    public class Empresa
    {
        
        public int IdEmpresa { get; set; }

        public string NombreEmpresa { get; set; } = string.Empty;

        public string DireccionEmpresa { get; set; } = string.Empty;

        public string RucEmpresa { get; set; } = string.Empty;

        public string UrlImgEmpresa { get; set; } = string.Empty; 

        public bool EstadoEmpresa { get; set; } = true;
        public bool IsDeleted { get; set; } = false;


        public DateTime FechaCreacionEmpresa { get; set; }

        
        public DateTime FechaModificacionEmpresa { get; set; }
        
    }
}
