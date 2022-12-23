using CartorioCivil.Modelos;
using CartorioCivil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CartorioCivil.Contexto
{
    public class DataBaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataBaseContext()
        {

        }

        public DataBaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        //public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Conjuge> Conjuges { get; set; }
        public DbSet<Nascimento> Nascimentos { get; set; }
        public DbSet<Casamento> Casamentos { get; set; }
        public DbSet<Obito> Obitos { get; set; }

        public DbSet<Registros> Registros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Casamento>().HasMany(c => c.conjuges).WithOne(c => c.casamento);

        }
    }
}
