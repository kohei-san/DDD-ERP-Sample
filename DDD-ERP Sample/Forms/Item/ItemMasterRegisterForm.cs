using Item.Application.Services;
using Item.Application.ViewModels;
using Item.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD_ERP_Sample.Forms.Item
{
    public partial class ItemMasterRegisterForm : Form
    {
        private readonly ItemApplicationService _service;

        public ItemMasterRegisterForm(ItemApplicationService service)
        {
            _service = service;
            InitializeComponent();

            ItemMasterViewModel vm = service.GetItemMasterViewModel(null);

            BindListToComboBox<UnitMaster>(cmbUnit, vm.Units.ToList(), "Name", "Code");
            BindListToComboBox<ItemTypeMaster>(cmbItemType, vm.ItemTypes.ToList(), "Name", "Code");
        }

        private void BindListToComboBox<T>(ComboBox comboBox, List<T> list, string displayMember, string valueMember)
        {
            comboBox.DataSource = list;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

            // 既定を空欄にする（プレースホルダを使わない場合の安全策）
            comboBox.SelectedItem = null;
            comboBox.SelectedIndex = -1;
        }
    }
}
