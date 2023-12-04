using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RoundedCorners
{
    public partial class RoundedPanel : Panel
    {
        private int radius = 10;
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        private Color backgroundColor = SystemColors.Control;
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        private Color borderColor = SystemColors.Control;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        private float borderWidth = 1.0f;
        public float BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        public RoundedPanel()
        {
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = radius * 2;
            int width = Width - 1;
            int height = Height - 1;

            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(width - diameter, 0, diameter, diameter, 270, 90);
            path.AddArc(width - diameter, height - diameter, diameter, diameter, 0, 90);
            path.AddArc(0, height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            // Draw background
            g.FillPath(new SolidBrush(backgroundColor), path);

            // Draw border
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                borderPen.Alignment = PenAlignment.Center;
                g.DrawPath(borderPen, path);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }
    }
}
