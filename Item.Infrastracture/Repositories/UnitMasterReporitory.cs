using Item.Domain.Entities;
using Item.Infrastracture.Db;

namespace Item.Infrastracture.Repositories
{
    public class UnitMasterReporitory
    {
        private readonly AppDbContext appDbContext;

        public UnitMasterReporitory(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<UnitMaster> FindAll()
        {
            return appDbContext.UnitMasters.ToList();
        }

    }
}
