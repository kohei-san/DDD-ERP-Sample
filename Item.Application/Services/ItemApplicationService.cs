using Item.Application.DTOs;
using Item.Application.ViewModels;
using Item.Domain.Repositories;

namespace Item.Application.Services
{
    public class ItemApplicationService
    {
        private readonly IUnitMasterRepository _unitRepo;
        private readonly IItemTypeMasterRepository _itemTypeRepo;

        public ItemApplicationService(IUnitMasterRepository unitRepo,
                                        IItemTypeMasterRepository itemTypeRepo
            )
        {
            _unitRepo = unitRepo;
            _itemTypeRepo = itemTypeRepo;
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
            var itemTypes = _itemTypeRepo.FindAll();

            // ViewModelに値をセット
            ItemMasterViewModel vm = new ItemMasterViewModel(item, units, itemTypes);
            return vm;
        }
        // 登録
        // 更新
        // 削除


    }
}
