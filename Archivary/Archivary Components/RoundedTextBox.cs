using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WHYWHYWHYW
{
    public class RoundedTextBox: Control
    {
        private int radius = 15;
        public TextBox textBox = new TextBox();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color br;

        public int Radius
        {
            get => radius;
            set
            {
                radius = value;
                AdjustTextBoxLayout(); 
                Invalidate(); 
            }
        }
        private void AdjustTextBoxLayout()
        {
            int horizontalPadding = 10;
            int verticalPadding = 5;    

            textBox.Location = new Point(radius + horizontalPadding, (Height / 2) - (textBox.Font.Height / 2) + verticalPadding);
            textBox.Width = Width - (radius * 2) - (2 * horizontalPadding);
        }

        public RoundedTextBox()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.textBox.Parent = this;
            base.Controls.Add(this.textBox);
            this.textBox.BorderStyle = BorderStyle.None;
            textBox.Font = this.Font;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.br = Color.White;
            textBox.BackColor = this.br;
            this.Text = null;
            this.Font = new Font("Century Gothic", 12f);
            base.Size = new Size(135, 33);
            this.DoubleBuffered = true;
            textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            textBox.TextChanged += new EventHandler(textBox_TextChanged);
            textBox.MouseDoubleClick += new MouseEventHandler(textBox_MouseDoubleCLick);
            textBox.Width = Width - (radius * 2) - (2 * 10); 
            AdjustTextBoxLayout(); 
        }

        private void textBox_MouseDoubleCLick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBox.SelectAll();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox.Text;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.Control && (e.KeyCode == Keys.A))
            {
                textBox.SelectionStart = 0;
                textBox.SelectionLength = this.Text.Length;
            }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            textBox.Font = this.Font;
            base.Invalidate();
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textBox.ForeColor = this.ForeColor;
            base.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new MyRectangle((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new MyRectangle(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;

            if (textBox.Height >= (base.Height - 4))
            {
                base.Height = textBox.Height + 4;
            }
            textBox.Location = new Point(this.radius - 5, (base.Height / 2) - (textBox.Font.Height / 2));
            textBox.Width = base.Width - ((int)(this.radius * 1.5));
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            Bitmap bitmap = new Bitmap (base.Width, base.Height);
            Graphics graphics = Graphics.FromImage ((Image)bitmap);
            e.Graphics.DrawPath(Pens.Gray, this.shape);
            using (SolidBrush brush = new SolidBrush(this.br))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            Trans.MakeTransparent(this, e.Graphics);
            base.OnPaint(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            textBox.Text = this.Text;
        }
        public void SelectAll()
        {
            textBox.SelectAll();
        }
        public Color Br
        {
            get =>
                this.br;
            set
            {
                this.br = value;
                if (this.br !=Color.Transparent)
                {
                    textBox.BackColor = this.br;
                }
                base.Invalidate();
            }
        }
        public override Color BackColor { 
            get => base.BackColor; 
            set => base.BackColor = Color.Transparent;
        }
    }
}
