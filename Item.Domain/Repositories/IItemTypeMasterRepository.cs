using Item.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Repositories
{
    public interface IItemTypeMasterRepository
    {
        List<ItemTypeMaster> FindAll();
    }
}
