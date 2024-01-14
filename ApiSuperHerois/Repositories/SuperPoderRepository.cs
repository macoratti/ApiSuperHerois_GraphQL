using ApiSuperHerois.Data;

namespace ApiSuperHerois.Repositories
{
    public class SuperPoderRepository : ISuperPoderRepository
    {
        private readonly AppDbContext _appDbContext;

        public SuperPoderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
