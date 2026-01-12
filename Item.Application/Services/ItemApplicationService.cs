using Item.Application.DTOs;
using Item.Application.ViewModels;

namespace Item.Application.Services
{
    public class ItemApplicationService
    {

        // マスタメンテ画面表示
        public ItemMasterViewModel ItemMasterMaintainShow(string? itemId)
        {

            ItemDto? item = null;
            if (!string.IsNullOrWhiteSpace(itemId))
            {
                item = new ItemDto();
            }

            // 単位マスタ取得(仮)
            var units = new List<UnitDto>
            {
                new UnitDto(),
                new UnitDto(),
                new UnitDto()
            };

            // 品目種別マスタ取得(仮)
            var types = new List<ItemTypeDto>{
                new ItemTypeDto(),
                new ItemTypeDto()
            };

            ItemMasterViewModel vm = new ItemMasterViewModel(item, units, types);
            return vm;
        }
        // 登録
        // 更新
        // 削除


    }
}
