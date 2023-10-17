using Microsoft.EntityFrameworkCore;

namespace LifeDrop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<BancoDeSangue> BancosDeSangue { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
    }

}
