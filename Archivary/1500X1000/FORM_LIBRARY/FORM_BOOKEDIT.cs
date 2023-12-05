using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary._1500X1000.FORM_LIBRARY
{
    public partial class FORM_BOOKEDIT : Form
    {
        public FORM_BOOKEDIT()
        {
            InitializeComponent();
        }

        private void FORM_BOOKEDIT_Load(object sender, EventArgs e)
        {
            //for the default option of the combo box which are "Genre" and "Category"
            categoryComboBox.SelectedIndex = 0;
            genreComboBox.SelectedIndex = 0;
        }

        private void titleTextBox_Click(object sender, EventArgs e)
        {

        }

        private void LAYOUT_FILL_FILL_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //for border around the form
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }

        private void FORM_BOOKEDIT_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(29, 185, 84), 10);

        }

        //to access the popup
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            using (FORM_BOOKINFO popupInfo = new FORM_BOOKINFO())
            {
                popupInfo.ShowInTaskbar = false;
                DialogResult result = popupInfo.ShowDialog();
            }
        }

        private void bookPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
