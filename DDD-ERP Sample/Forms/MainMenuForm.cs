using DDD_ERP_Sample.Forms.Item;
using Microsoft.Extensions.DependencyInjection;

namespace DDD_ERP_Sample
{
    public partial class MainMenuForm : Form
    {
        private readonly IServiceProvider _provider;

        public MainMenuForm(IServiceProvider provider)
        {
            _provider = provider;
            InitializeComponent();
        }

        private void btnItemMenu_Click(object sender, EventArgs e)
        {
            using var form = _provider.GetRequiredService<ItemMenuForm>();
            form.ShowDialog();
        }
    }
}