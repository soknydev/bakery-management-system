using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;

namespace bakery_management_system.Views.admin
{
    public partial class PaymentAdminForm : Form
    {
        private readonly InvoiceController _invoiceController;
        public PaymentAdminForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _invoiceController = new InvoiceController();
            int employeeId = UserSession.CurrentUser.EmployeeId; // Example
            LoadInvoices(employeeId);

            UserInfo();
        }

        private void LoadInvoices(int employeeId)
        {
            flpInvoices.Controls.Clear();
            var invoices = _invoiceController.GetInvoicesByEmployeeId(employeeId);

            foreach (var invoice in invoices)
            {
                var invoiceControl = new InvoiceControl();
                invoiceControl.SetInvoice(invoice);
                flpInvoices.Controls.Add(invoiceControl);
            }
        }

        private void UserInfo()
        {
            // Section: User Information Display
            if (UserSession.CurrentUser != null)
            {
                lblWelcome.Text = $"Hello, {UserSession.CurrentUser.Name}";
                if (!string.IsNullOrEmpty(UserSession.CurrentUser.ImagePath) && File.Exists(UserSession.CurrentUser.ImagePath))
                {
                    pbProfile.Image = Image.FromFile(UserSession.CurrentUser.ImagePath);
                }
                else
                {
                    // defual avatar
                    pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
                }
            }
            else
            {
                lblWelcome.Text = "Welcome, Guest!";
                pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            }

        }

    }
}
