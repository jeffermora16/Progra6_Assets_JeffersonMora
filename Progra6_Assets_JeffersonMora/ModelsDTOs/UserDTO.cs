namespace Progra6_Assets_JeffersonMora.ModelsDTOs
{
    public class UserDTO
    {

        public int CodigoUsuario { get; set; }

        public string Cedula { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string? Direccion { get; set; }

        public string? Correo { get; set; }

        public bool? Activo { get; set; }

        public int CodigoDeRol { get; set; }

        public  string? RolDeUsuario { get; set; }

        public string? NotasDelUsuario { get; set; }
    }
}
