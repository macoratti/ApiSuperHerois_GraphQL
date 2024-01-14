using ApiSuperHerois.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiSuperHerois.Data.ContextConfigurations;

public class SuperHeroiContextConfiguration : IEntityTypeConfiguration<SuperHeroi>
{
    private Guid[] _ids;

    public SuperHeroiContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }

    public void Configure(EntityTypeBuilder<SuperHeroi> builder)
    {
        builder
            .HasData(
            new SuperHeroi
            {
                Id = _ids[0],
                Nome = "Batman",
                Descricao = "Batman foi originalmente apresentado como um vigilante implacável que frequentemente matava ou mutilava criminosos, mas evoluiu para um personagem com um código moral rigoroso e um forte senso de justiça. Ao contrário da maioria dos super-heróis, Batman não possui superpoderes, confiando apenas em seu intelecto, habilidades de luta e riqueza.",
                Altura = 1.93
            },
            new SuperHeroi
            {
                Id = _ids[1],
                Nome = "Luke Skywalker",
                Descricao = "Luke Skywalker era um fazendeiro de Tatooine que cresceu de origens humildes para se tornar um dos maiores Jedi que a galáxia já conheceu. Junto com seus amigos Princesa Leia e Han Solo, Luke lutou contra o Império do mal, descobriu a verdade sobre sua ascendência e acabou com a tirania dos Sith..",
                Altura = 1.70
            },
            new SuperHeroi
            {
                Id = _ids[2],
                Nome = "Viúva Negra",
                Descricao = "Viúva Negra, cujo nome verdadeiro é Natasha Romanoff, é uma agente secreta e super-heroína treinada que aparece na Marvel Comics. Associado às equipes de super-heróis S.H.I.E.L.D. e os Vingadores, a Viúva Negra compensa sua falta de superpoderes com treinamento de nível mundial como atleta, acrobata, especialista em artes marciais e especialista em armas.",
                Altura = 1.70
            });
    }
}