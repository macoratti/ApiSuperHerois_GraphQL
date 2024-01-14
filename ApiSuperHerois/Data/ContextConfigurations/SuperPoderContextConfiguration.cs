using ApiSuperHerois.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiSuperHerois.Data.ContextConfigurations;

public class SuperPoderContextConfiguration :
             IEntityTypeConfiguration<SuperPoder>
{
    private Guid[] _ids;

    public SuperPoderContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }

    public void Configure(EntityTypeBuilder<SuperPoder> builder)
    {
        builder
            .HasData(
            new SuperPoder
            {
                Id = Guid.NewGuid(),
                Super_Poder = "Inteligência",
                Descricao = "Sempre esta a um passo a frente",
                SuperHeroiId = _ids[0]
            },
            new SuperPoder
            {
                Id = Guid.NewGuid(),
                Super_Poder = "Luta",
                Descricao = "Habilidades de luta especiais",
                SuperHeroiId = _ids[0]
            },
            new SuperPoder
            {
                Id = Guid.NewGuid(),
                Super_Poder = "Fortuna",
                Descricao = "Possui muito dinheiro",
                SuperHeroiId = _ids[0]
            },
            new SuperPoder
            {
                Id = Guid.NewGuid(),
                Super_Poder = "Desvia o poder do blaster.",
                Descricao = "Skywalker é capaz de desviar o fogo de um blaster de volta para o oponente que está atirando.",
                SuperHeroiId = _ids[1]
            },
            new SuperPoder
            {
                Id = Guid.NewGuid(),
                Super_Poder = "Espionagem",
                Descricao = "Conhece técnicas para espionar as pessoas.",
                SuperHeroiId = _ids[2]
            },
            new SuperPoder
            {
                Id = Guid.NewGuid(),
                Super_Poder = "Infiltração",
                Descricao = "Sabe como se infiltrar no inimigo.",
                SuperHeroiId = _ids[2]
            },
            new SuperPoder
            {
                Id = Guid.NewGuid(),
                Super_Poder = "Subterfúgio",
                Descricao = "Tem o conhecimento de como minar os outros.",
                SuperHeroiId = _ids[2]
            });
    }
}