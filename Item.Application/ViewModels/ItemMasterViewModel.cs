using Item.Application.DTOs;
using Item.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Application.ViewModels
{
    public class ItemMasterViewModel
    {
        public ItemDto? Item { get; }
        public IReadOnlyList<UnitMaster> Units { get; }
        public IReadOnlyList<ItemTypeMaster> ItemTypes { get; }

        public ItemMasterViewModel(
            ItemDto? item,
            IReadOnlyList<UnitMaster> units,
            IReadOnlyList<ItemTypeMaster> itemTypes)
        {
            Item = item;
            Units = units;
            ItemTypes = itemTypes;
        }
    }

}