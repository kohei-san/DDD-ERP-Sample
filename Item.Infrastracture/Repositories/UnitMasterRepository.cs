using Item.Domain.Entities;
using Item.Infrastracture.Db;

namespace Item.Infrastracture.Repositories
{
    public class UnitMasterRepository : Domain.Repositories.IUnitMasterRepository
    {
        private readonly AppDbContext appDbContext;

        public UnitMasterRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<UnitMaster> FindAll()
        {
            return appDbContext.UnitMasters.ToList();
        }

    }
}
