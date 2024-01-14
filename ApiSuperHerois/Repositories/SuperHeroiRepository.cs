using ApiSuperHerois.Data;

namespace ApiSuperHerois.Repositories;

public class SuperHeroiRepository : ISuperHeroiRepository
{
    private readonly AppDbContext _appDbContext;

    public SuperHeroiRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
