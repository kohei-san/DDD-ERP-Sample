using Microsoft.Extensions.DependencyInjection;
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
    public partial class ItemMenuForm : Form
    {
        private readonly IServiceProvider _provider;

        public ItemMenuForm(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
        }

        private void btnItemRegister_Click(object sender, EventArgs e)
        {
            using var form = _provider.GetRequiredService<ItemMasterRegisterForm>();
            form.ShowDialog();
        }
    }
}
