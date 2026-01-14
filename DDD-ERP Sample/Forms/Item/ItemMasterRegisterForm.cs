using Item.Application.Services;
using Item.Application.ViewModels;
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

            //ItemApplicationService itemService = new ItemApplicationService();
            //var viewModel = itemService.GetItemMasterViewModel(null);
        }
    }
}
