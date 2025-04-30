using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppEmpresa.Models; 

namespace WebAppEmpresa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<WebAppEmpresa.Models.Operaciones> Operaciones { get; set; }
        public virtual DbSet<WebAppEmpresa.Models.Estado> Estado { get; set; }
        public virtual DbSet<WebAppEmpresa.Models.Responsable> Responsables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RICKY-SANTIAGO\\SQLEXPRESS;Database=DBOPERACIONES2015I;" +
                "User id=sa;Password=1234;MultipleActiveResultSets=true;Encrypt=false");
        }
    }
}
