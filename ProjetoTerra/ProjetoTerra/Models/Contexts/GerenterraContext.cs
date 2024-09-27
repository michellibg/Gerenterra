using Microsoft.EntityFrameworkCore;
using ProjetoTerra.Models;

namespace ProjetoTerra.Models.Contexts
{
    public class GerenterraContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public GerenterraContext(DbContextOptions<GerenterraContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("terra");
        }
        public DbSet<ProjetoTerra.Models.Cliente> Clientes { get; set; } = default!;
        public DbSet<ProjetoTerra.Models.Usuario> Usuarios { get; set; } = default!;
    }
}
