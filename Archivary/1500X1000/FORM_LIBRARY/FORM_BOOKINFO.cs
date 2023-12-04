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
    public partial class FORM_BOOKINFO : Form
    {
        public FORM_BOOKINFO()
        {
            InitializeComponent();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void genreContainer_Click(object sender, EventArgs e)
        {

        }

       

        private void LAYOUT_FILL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LAYOUT_TOP3_Paint(object sender, PaintEventArgs e)
        {

        }
        //for colored border aroun the form
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_BOOKINFO_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(29, 185, 84), 10); 

        }

        //to access the popup
        private void editInformationButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            using (FORM_BOOKEDIT popupEdit = new FORM_BOOKEDIT())
            {
                popupEdit.ShowInTaskbar = false;
                DialogResult result = popupEdit.ShowDialog();
            }
        }

        //to close the popup
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
