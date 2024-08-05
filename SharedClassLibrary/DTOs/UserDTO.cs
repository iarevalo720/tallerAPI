using System.ComponentModel.DataAnnotations;

namespace SharedClassLibrary.DTOs
{
    public class UserDTO
    {
        public string? Id { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string NroDocumento { get; set; } = string.Empty;
        [Required]
        public string NroTelefono { get; set; } = string.Empty;
        [Required]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
