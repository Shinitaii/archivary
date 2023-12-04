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
    public partial class FORM_BOOKADD : Form
    {
        public FORM_BOOKADD()
        {
            InitializeComponent();
        }
        private void copyrightTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if(copyrightTextBox.Text == "<© YourCompany, 2023>")
            {
                copyrightTextBox.Text = "";
            }
        }

        private void titleTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (titleTextBox.Text == "<Book Title>")
            {
                titleTextBox.Text = "";
            }
        }

        private void titleTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (titleTextBox.Text == "")
            {
                titleTextBox.Text = "<Book Title>";
            }
        }

        private void ISBNTextBox_Click(object sender, EventArgs e)
        {

        }

        private void ISBNTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (ISBNTextBox.Text == "<0000000000000>")
            {
                ISBNTextBox.Text = "";
            }
        }

        private void ISBNTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (ISBNTextBox.Text == "")
            {
                ISBNTextBox.Text = "<0000000000000>";
            }
        }

        private void publisherTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (publisherTextBox.Text == "<Book Publisher>")
            {
                publisherTextBox.Text = "";
            }
        }

        private void publisherTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (publisherTextBox.Text == "")
            {
                publisherTextBox.Text = "<Book Publisher>";
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (lastNameTextBox.Text == "<Last Name>")
            {
                lastNameTextBox.Text = "";
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "<Last Name>";
            }
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (firstNameTextBox.Text == "<First Name>")
            {
                firstNameTextBox.Text = "";
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (firstNameTextBox.Text == "")
            {
                firstNameTextBox.Text = "<First Name>";
            }
        }

        private void middleInitialTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (middleInitialTextBox.Text == "<M.I.>")
            {
                middleInitialTextBox.Text = "";
            }
        }

        private void middleInitialTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (middleInitialTextBox.Text == "")
            {
                middleInitialTextBox.Text = "<M.I.>";
            }
        }

        private void copyrightTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (copyrightTextBox.Text == "")
            {
                copyrightTextBox.Text = "<© YourCompany, 2023>";
            }
        }

        private void aisleTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (aisleTextBox.Text == "<0000>")
            {
                aisleTextBox.Text = "";
            }
        }

        private void aisleTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (aisleTextBox.Text == "")
            {
                aisleTextBox.Text = "<0000>";
            }
        }

        private void shelfTextBox_Enter(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (shelfTextBox.Text == "<0000>")
            {
                shelfTextBox.Text = "";
            }
        }

        private void shelfTextBox_Leave(object sender, EventArgs e)
        {
            //placeholder for textbox
            if (shelfTextBox.Text == "")
            {
                shelfTextBox.Text = "<0000>";
            }
        }

        private void FORM_BOOKADD_Load(object sender, EventArgs e)
        {
            //for the default option of the combo box which are "Genre" and "Category"
            genreComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;
        }

        //for border around the form
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_BOOKADD_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(29, 185, 84), 10); 

        }


        private void LAYOUT_FILL_FILL_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void lastNameTextBox_Click(object sender, EventArgs e)
        {

        }

        //to close the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
