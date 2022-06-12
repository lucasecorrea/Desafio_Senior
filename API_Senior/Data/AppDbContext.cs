using Microsoft.EntityFrameworkCore;

namespace API_Senior.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Ponto> Pontos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ponto>()
                .HasData(
                    new Ponto { Id = 1, includedAt = "2022-03-15 16:30:00", employeeId = 83, employerId = 111 },
                    new Ponto { Id = 2, includedAt = "2022-03-15 16:33:00", employeeId = 95, employerId = 111 },
                    new Ponto { Id = 3, includedAt = "2022-03-15 16:32:00", employeeId = 103, employerId = 111 });
        }
    }
}
