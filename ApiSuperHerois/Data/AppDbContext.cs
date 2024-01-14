using ApiSuperHerois.Data.ContextConfigurations;
using ApiSuperHerois.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiSuperHerois.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Gera 3 GUIDS e os coloca em um array
        var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

        // Aplica a configuração para 3 contextos
        // Isso vai criar os dados usados no endpoint do GraphQL
        builder.ApplyConfiguration(new SuperHeroiContextConfiguration(ids));
        builder.ApplyConfiguration(new SuperPoderContextConfiguration(ids));
        builder.ApplyConfiguration(new FilmeContextConfiguration(ids));
    }

    // Adiciona os DbSets para cada modelo
    public DbSet<SuperHeroi> SuperHerois { get; set; }
    public DbSet<SuperPoder> SuperPoderes { get; set; }
    public DbSet<Filme> Filmes { get; set; }
}
