using System.Collections.Generic;
using System.Linq;
using Item.Domain.Entities;
using Item.Infrastracture.Db;

namespace Item.Infrastracture.Repositories
{
    public class ItemTypeMasterRepository : Domain.Repositories.IItemTypeMasterRepository
    {
        private readonly AppDbContext appDbContext;

        public ItemTypeMasterRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<ItemTypeMaster> FindAll()
        {
            return appDbContext.ItemTypeMasters.ToList();
        }
    }
}