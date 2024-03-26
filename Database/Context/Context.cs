using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;

public class Context : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Alerta> Alertas { get; set; }
    public DbSet<Andar> Andares { get; set; }
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Colaborador> Colaboradores { get; set; }
    public DbSet<Configuracao> Configuracoes { get; set; }
    public DbSet<Grupo> Grupos { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<Posto> Postos { get; set; }
    public DbSet<Secao> Secoes { get; set; }
    public DbSet<Sistema> Sistemas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string? connectionString = configuration.GetConnectionString("Intranet");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}