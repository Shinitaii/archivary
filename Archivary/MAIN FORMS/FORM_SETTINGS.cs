using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHYWHYWHYW;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary.MAIN_FORMS
{
    public partial class FORM_SETTINGS : Form
    {
        public FORM_SETTINGS()
        {
            InitializeComponent();
        }

       
      
        private void FORM_SETTINGS_Leave(object sender, EventArgs e)
        {
           
        }

    

        private void FORM_SETTINGS_Load(object sender, EventArgs e)
        {

        }

        private void borrowingCapacityTextBox_Enter(object sender, EventArgs e)
        {
            if(borrowingCapacityTextBox.Text == "<0000>")
            {
                borrowingCapacityTextBox.Text = "";
            }
        }

        private void borrowingCapacityTextBox_Click(object sender, EventArgs e)
        {

        }

        private void borrowingCapacityTextBox_Leave(object sender, EventArgs e)
        {
            if(borrowingCapacityTextBox.Text == "")
            {
                borrowingCapacityTextBox.Text = "<0000>";
            }
        }

        private void reserveLimitTextBox_Enter(object sender, EventArgs e)
        {
            if(reserveLimitTextBox.Text == "<0000>")
            {
                reserveLimitTextBox.Text = "";
            }
        }

        private void reserveLimitTextBox_Leave(object sender, EventArgs e)
        {
            if(reserveLimitTextBox.Text == "")
            {
                reserveLimitTextBox.Text = "<0000>";
            }
        }

        private void borrowingDurationTextBox_Enter(object sender, EventArgs e)
        {
            if(borrowingDurationTextBox.Text == "<0000>")
            {
                borrowingDurationTextBox.Text = "";
            }
        }

        private void borrowingDurationTextBox_Leave(object sender, EventArgs e)
        {
            if(borrowingDurationTextBox.Text == "")
            {
                borrowingDurationTextBox.Text = "<0000>";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            borrowingCapacityTextBox.Enabled = true;
            borrowingDurationTextBox.Enabled = true;
            reserveLimitTextBox.Enabled = true;
        }

        private void LAYOUT_FILL_LEFT_LEFT_FILL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LAYOUT_FILL_LEFT_LEFT_FILL_FILL_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
