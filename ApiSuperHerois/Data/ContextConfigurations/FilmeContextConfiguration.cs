using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ApiSuperHerois.Entities;

namespace ApiSuperHerois.Data.ContextConfigurations;

public class FilmeContextConfiguration : IEntityTypeConfiguration<Filme>
{
    private Guid[] _ids;

    public FilmeContextConfiguration(Guid[] ids)
    {
        _ids = ids;
    }

    public void Configure(EntityTypeBuilder<Filme> builder)
    {
        builder
            .HasData(
            new Filme
            {
                Id = Guid.NewGuid(),
                Titulo = "Batman Begins",
                Descricao = "Batman Begins é um filme de super-herói de 2005 dirigido por Christopher Nolan e escrito por Nolan e David S. Goyer. Baseado no personagem Batman da DC Comics, é estrelado por Christian Bale como Bruce Wayne / Batman, com Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                Instrutor = "Christopher Nolan",
                Lancamento = new DateTime(2005, 06, 25),
                SuperHeroiId = _ids[0]
            },
            new Filme
            {
                Id = Guid.NewGuid(),
                Titulo = "O Cavaleiro das trevas",
                Descricao = "O Cavaleiro das Trevas é um filme de super-herói de 2008 dirigido, produzido e co-escrito por Christopher Nolan. Baseado no personagem Batman da DC Comics, o filme é a segunda parcela da trilogia O Cavaleiro das Trevas de Nolan e uma sequência de Batman Begins de 2005, estrelado por Christian Bale e apoiado por Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal e Morgan Freeman.",
                Instrutor = "Christopher Nolan",
                Lancamento = new DateTime(2008, 07, 18),
                SuperHeroiId = _ids[0]
            },
            new Filme
            {
                Id = Guid.NewGuid(),
                Titulo = "O Cavaleiro das trevas - Ressurreição",
                Descricao = "O Cavaleiro das Trevas Ressurge é um filme de super-heróis de 2012 dirigido por Christopher Nolan, que co-escreveu o roteiro com seu irmão Jonathan Nolan, e a história com David S. Goyer.",
                Instrutor = "Christopher Nolan",
                Lancamento = new DateTime(2012, 07, 20),
                SuperHeroiId = _ids[0]
            },
            new Filme
            {
                Id = Guid.NewGuid(),
                Titulo = "Guerra nas estrelas: Episode IV – Uma nova esperança",
                Descricao = "Star Wars (intitulado retroativamente Star Wars: Episódio IV – Uma Nova Esperança) é um filme épico americano de ópera espacial de 1977 escrito e dirigido por George Lucas, produzido pela Lucasfilm e distribuído pela 20th Century Fox.",
                Instrutor = "George Lucas",
                Lancamento = new DateTime(1977, 05, 25),
                SuperHeroiId = _ids[1]
            },
            new Filme
            {
                Id = Guid.NewGuid(),
                Titulo = "Guera nas estrelas: Episode V – O império contra ataca",
                Descricao = "The Empire Strikes Back (também conhecido como Star Wars: Episódio V – The Empire Strikes Back) é um filme épico americano de ópera espacial de 1980 dirigido por Irvin Kershner e escrito por Leigh Brackett e Lawrence Kasdan, baseado em uma história de George Lucas..",
                Instrutor = "Irvin Kershner",
                Lancamento = new DateTime(1980, 05, 21),
                SuperHeroiId = _ids[1]
            },
            new Filme
            {
                Id = Guid.NewGuid(),
                Titulo = "Guerra nas Estrelas: Episode VI – O retorno de Jedi",
                Descricao = "O Retorno de Jedi (também conhecido como Star Wars: Episódio VI – O Retorno de Jedi) é um filme épico americano de ópera espacial de 1983, dirigido por Richard Marquand. O roteiro é de Lawrence Kasdan e George Lucas a partir de uma história de Lucas, que também foi produtor executivo.",
                Instrutor = "Richard Marquand",
                Lancamento = new DateTime(1983, 05, 25),
                SuperHeroiId = _ids[1]
            },
            new Filme
            {
                Id = Guid.NewGuid(),
                Titulo = "Viúva Negra",
                Descricao = "Viúva Negra é um filme de super-herói americano de 2021 baseado na Marvel Comics apresentando o personagem de mesmo nome. Produzido pela Marvel Studios e distribuído pela Walt Disney Studios Motion Pictures, é o 24º filme do Universo Cinematográfico Marvel (MCU).",
                Instrutor = "Cate Shortland",
                Lancamento = new DateTime(2021, 06, 29),
                SuperHeroiId = _ids[2]
            });
    }
}