using ES.Project.Entities.Entities;
using ES.Project.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ES.Core.DataAccess
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=ISU-NB-00015;database=ES;integrated security=true;");
            optionsBuilder.UseSqlServer(@"server=DESKTOP-E6SPDSH\SQLEXPRESS;database=ES;integrated security=true;");
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<About> Abouts { get; set; }
        
    }
}
