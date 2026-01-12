using Item.Application.Services;
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
        public ItemMasterRegisterForm()
        {
            InitializeComponent();

            ItemApplicationService itemService = new ItemApplicationService();
            var viewModel = itemService.ItemMasterMaintainShow(null);
        }
    }
}
