using Microsoft.AspNetCore.Identity;

namespace IdentityManagerServerApi.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? NroDocumento { get; set; }
        public string? Direccion { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
