using System.Drawing.Drawing2D;

namespace bakery_management_system.components
{
    public partial class PictureBoxComponent1 : PictureBox
    {
        private Color _borderColor = ColorTranslator.FromHtml("#7E60BF"); // Border color
        private int _borderThickness = 5; // Thickness of the border

        public PictureBoxComponent1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Smooth rendering
            this.BackColor = Color.Transparent; // Make background transparent
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Ensure the control is always a perfect circle by setting equal width and height
            this.Width = this.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Image == null) // If no image, skip custom drawing
                return;

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smooth edges

            // Calculate the diameter for the circular region and the border
            int diameter = Math.Min(this.Width, this.Height) - _borderThickness; // Subtract thickness for proper fitting
            Rectangle circleBounds = new Rectangle(
                _borderThickness / 2,
                _borderThickness / 2,
                diameter,
                diameter
            );

            // Create a circular clipping region
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(circleBounds);
                this.Region = new Region(path); // Set the control's region to the circular path
            }

            // Draw the image with "object-fit: cover" scaling
            float aspectRatioImage = (float)this.Image.Width / this.Image.Height;
            float aspectRatioControl = (float)this.Width / this.Height;

            Rectangle drawRect;

            if (aspectRatioImage > aspectRatioControl)
            {
                // Image is wider than the control, fit by height
                int scaledWidth = (int)(this.Height * aspectRatioImage);
                int offsetX = (this.Width - scaledWidth) / 2;
                drawRect = new Rectangle(offsetX, 0, scaledWidth, this.Height);
            }
            else
            {
                // Image is taller than the control, fit by width
                int scaledHeight = (int)(this.Width / aspectRatioImage);
                int offsetY = (this.Height - scaledHeight) / 2;
                drawRect = new Rectangle(0, offsetY, this.Width, scaledHeight);
            }

            graphics.DrawImage(this.Image, drawRect);

            // Draw the border
            using (Pen borderPen = new Pen(_borderColor, _borderThickness))
            {
                graphics.DrawEllipse(borderPen, circleBounds);
            }
        }
    }
}
