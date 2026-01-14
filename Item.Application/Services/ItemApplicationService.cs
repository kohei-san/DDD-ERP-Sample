using Item.Application.DTOs;
using Item.Application.ViewModels;
using Item.Domain.Repositories;

namespace Item.Application.Services
{
    public class ItemApplicationService
    {
        private readonly IUnitMasterRepository _unitRepo;
        //private readonly IItemMasterRepository _itemRepo;

        public ItemApplicationService(IUnitMasterRepository unitRepo
                                        //IItemMasterRepository itemRepo
            )
        {
            _unitRepo = unitRepo;
            //_itemRepo = itemRepo;
        }


        // マスタメンテ画面表示
        public ItemMasterViewModel GetItemMasterViewModel(string? itemId)
        {

            ItemDto? item = null;
            if (!string.IsNullOrWhiteSpace(itemId))
            {
                item = new ItemDto();
            }



            // 単位マスタ取得(仮)
            var units = _unitRepo.FindAll();

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
