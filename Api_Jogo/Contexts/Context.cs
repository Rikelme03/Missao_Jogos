using Api_Jogo.Domains;
using Microsoft.EntityFrameworkCore;

namespace Api_Jogo.Contexts
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Jogos> Jogos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE44-S28\\SQLEXPRESS; Database = Db_Jogos; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }


    }
}
