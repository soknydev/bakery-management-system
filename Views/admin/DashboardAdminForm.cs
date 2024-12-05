
namespace bakery_management_system.Views.admin
{
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryAdminForm categoryAdminForm = new CategoryAdminForm();
            categoryAdminForm.Show();
            this.Hide();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            CartAdminForm cartAdminForm = new CartAdminForm();
            cartAdminForm.Show();
            this.Hide();
        }

        private void btnMyPayments_Click(object sender, EventArgs e)
        {
            PaymentAdminForm paymentAdminForm = new PaymentAdminForm();
            paymentAdminForm.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerAdminForm customerAdminForm = new CustomerAdminForm();
            customerAdminForm.Show();
            this.Hide();
        }
    }
}
