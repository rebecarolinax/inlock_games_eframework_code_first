using Microsoft.EntityFrameworkCore;
using webapi.inlock.codefirst.Domains;

namespace webapi.inlock.codefirst.Contexts
{
    public class InLockContext : DbContext
    {
        /// <summary>
        /// Definição das entidades do Banco de Dados
        /// </summary>
        public DbSet<TiposUsuario> tiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE09-S14; Database= inlock_games_codeFirst; User Id= sa; Pwd= Senai@134; TrustServerCertificate= True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
