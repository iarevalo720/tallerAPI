using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace IdentityManagerServerApi.Data
{
    public class AppDbContext(DbContextOptions options) : IdentityDbContext<ApplicationUser>(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var mecanico = new IdentityRole("Mecanico");
            mecanico.NormalizedName = "MECANICO";

            var secretaria = new IdentityRole("Secreataria");
            secretaria.NormalizedName = "SECRETARIA";

            builder.Entity<IdentityRole>().HasData(mecanico, secretaria);
        }
    }
}
