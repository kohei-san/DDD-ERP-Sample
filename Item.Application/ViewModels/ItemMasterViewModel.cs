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
        public IReadOnlyList<ItemTypeDto> ItemTypes { get; }

        public ItemMasterViewModel(
            ItemDto? item,
            IReadOnlyList<UnitMaster> units,
            IReadOnlyList<ItemTypeDto> itemTypes)
        {
            Item = item;
            Units = units;
            ItemTypes = itemTypes;
        }
    }

}