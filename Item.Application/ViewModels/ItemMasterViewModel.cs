using Item.Application.DTOs;
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
        public IReadOnlyList<UnitDto> Units { get; }
        public IReadOnlyList<ItemTypeDto> ItemTypes { get; }

        public ItemMasterViewModel(
            ItemDto? item,
            IReadOnlyList<UnitDto> units,
            IReadOnlyList<ItemTypeDto> itemTypes)
        {
            Item = item;
            Units = units;
            ItemTypes = itemTypes;
        }
    }

}