using System.Drawing.Drawing2D;

namespace bakery_management_system.components
{
    public partial class PanelComponent1 : Panel
    {
        public PanelComponent1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Reduce flickering for smoother rendering
            this.BackColor = Color.White; // Set the background color to white
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smooth edges

            // Define the bounds for the rounded rectangle
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            int cornerRadius = 10; // Radius for rounded corners

            using (GraphicsPath path = CreateRoundedRectanglePath(bounds, cornerRadius))
            using (SolidBrush brush = new SolidBrush(this.BackColor)) // Brush to fill background
            {
                // Fill the panel with the background color inside the rounded rectangle
                graphics.FillPath(brush, path);

                // Set the clipping region to the rounded rectangle to prevent drawing outside
                this.Region = new Region(path);
            }
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            // Add arcs for the rounded corners
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner

            path.CloseFigure();
            return path;
        }
    }
}
