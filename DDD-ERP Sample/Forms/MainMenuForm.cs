using DDD_ERP_Sample.Forms.Item;

namespace DDD_ERP_Sample
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnItemMenu_Click(object sender, EventArgs e)
        {
            using var form = new ItemMenuForm();
            form.ShowDialog();
        }
    }
}