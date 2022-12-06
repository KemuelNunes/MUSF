using Microsoft.EntityFrameworkCore;
using MUSF.Domain.Entities;
using System.Configuration;

namespace MUSF.Domain.Context
{
    public class Context : DbContext
    {
        const string connectionString = "Server=DESKTOP-0U8SAJL;Database=MissoesDb;Integrated Security=True;TrustServerCertificate=True;";
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }       

        public DbSet<AcompanharMissoes> AcompanharMissoes { get; set; }
        public DbSet<Missao> Misao { get; set; }
        public DbSet<MissaoMissionario> MissaoMissionario { get; set; }
        public DbSet<Missionario> Missionario { get; set; }
        public DbSet<NecessidadeMissoes> NecessidadeMissoes { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Transacao> Transacao { get; set; }
        public DbSet<TransacaoUsuario> TransacaoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
