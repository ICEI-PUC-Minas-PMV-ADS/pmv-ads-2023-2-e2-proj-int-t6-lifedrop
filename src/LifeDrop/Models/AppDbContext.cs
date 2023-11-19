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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agendamento>()
                .HasOne<Doador>(c => c.Doador)
                .WithMany(i => i.Agendamentos)
                .HasForeignKey(f => f.IdDoador);

            modelBuilder.Entity<Agendamento>()
                .HasOne<BancoDeSangue>(c => c.Unidade)
                .WithMany(i => i.Agendamentos)
                .HasForeignKey(f => f.IdBancoDeSangue);
        }
    }
}