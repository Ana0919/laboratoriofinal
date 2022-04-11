using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ApplicationDbContext : DbContext
    {

        ///Conexión a la base de datos.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer("Data Source=CARODRIGUEZ;Initial Catalog=dbmedicallab;Integrated Security=True");
        }
        
        public DbSet<ApplicationUser> Tblusers { get; set; }
        public DbSet<Office> TblOffices { get; set; }
        public DbSet<Pacient> TblPacients { get; set; }
        
    }
}
