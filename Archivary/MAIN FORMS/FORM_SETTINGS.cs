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

     

        private void editButton_Click(object sender, EventArgs e)
        {
            borrowingCapacityTextBox.Enabled = true;
            borrowingDurationTextBox.Enabled = true;
            reserveLimitTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            firstNameTextBox.Enabled = true;
            middleNameTextBox.Enabled = true;
            emailAddressTextBox.Enabled = true;
            contactNumberTextBox.Enabled = true;
            cityTextBOx.Enabled = true;
            barangayTextBox.Enabled = true;
            streetTextBox.Enabled = true;
            houseNumberTextBox.Enabled = true;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roundedTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void LAYOUT_FILL_LEFT_LEFT_FILL_FILL_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        
        private void streetTextBox_Click(object sender, EventArgs e)
        {

        }

        private void borrowingDurationLabel_Click(object sender, EventArgs e)
        {

        }

        private void borrowingCapacityLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_FontChanged(object sender, EventArgs e)
        {
           
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "<Last Name>";
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "<Last Name>")
            {
                lastNameTextBox.Text = "";
            }
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "<First Name>")
            {
                firstNameTextBox.Text = "";
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                firstNameTextBox.Text = "<First Name>";
            }
        }

        private void middleNameTextBox_Enter(object sender, EventArgs e)
        {
            if (middleNameTextBox.Text == "<Middle Name>")
            {
                middleNameTextBox.Text = "";
            }
        }

        private void middleNameTextBox_Leave(object sender, EventArgs e)
        {
            if (middleNameTextBox.Text == "")
            {
                middleNameTextBox.Text = "<Middle Name>";
            }
        }

        private void emailAddressTextBox_Enter(object sender, EventArgs e)
        {
            if (emailAddressTextBox.Text == "someone@gmail.com")
            {
                emailAddressTextBox.Text = "";
            }
        }

        private void emailAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (emailAddressTextBox.Text == "")
            {
                emailAddressTextBox.Text = "someone@gmail.com";
            }
        }

        private void cityTextBOx_Enter(object sender, EventArgs e)
        {
            if (cityTextBOx.Text == "City")
            {
                cityTextBOx.Text = "";
            }
        }

        private void cityTextBOx_Leave(object sender, EventArgs e)
        {
            if (cityTextBOx.Text == "")
            {
                cityTextBOx.Text = "City";
            }
        }

        private void contactNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (contactNumberTextBox.Text == "09XX-XXX-XXXX")
            {
                contactNumberTextBox.Text = "";
            }
        }

        private void contactNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (contactNumberTextBox.Text == "")
            {
                contactNumberTextBox.Text = "09XX-XXX-XXXX";
            }
        }

        private void barangayTextBox_Enter(object sender, EventArgs e)
        {
            if (barangayTextBox.Text == "Barangay")
            {
                barangayTextBox.Text = "";
            }
        }

        private void barangayTextBox_Leave(object sender, EventArgs e)
        {
            if (barangayTextBox.Text == "")
            {
                barangayTextBox.Text = "Barangay";
            }
        }

        private void streetTextBox_Enter(object sender, EventArgs e)
        {
            if (streetTextBox.Text == "Street")
            {
                streetTextBox.Text = "";
            }
        }

        private void streetTextBox_Leave(object sender, EventArgs e)
        {
            if (streetTextBox.Text == "")
            {
                streetTextBox.Text = "Street";
            }
        }

        private void houseNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (houseNumberTextBox.Text == "House No./ Building/ Unit")
            {
                houseNumberTextBox.Text = "";
            }
        }

        private void houseNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (houseNumberTextBox.Text == "")
            {
                houseNumberTextBox.Text = "House No./ Building/ Unit";
            }
        }

        private void borrowingCapacityTextBox_Enter(object sender, EventArgs e)
        {
            if (borrowingCapacityTextBox.Text == "<0000>")
            {
                borrowingCapacityTextBox.Text = "";
            }
        }

        private void borrowingCapacityTextBox_Leave(object sender, EventArgs e)
        {
            if (borrowingCapacityTextBox.Text == "")
            {
                borrowingCapacityTextBox.Text = "<0000>";
            }
        }

        private void reserveLimitTextBox_Enter(object sender, EventArgs e)
        {
            if (reserveLimitTextBox.Text == "<0000>")
            {
                reserveLimitTextBox.Text = "";
            }
        }

        private void reserveLimitTextBox_Leave(object sender, EventArgs e)
        {
            if (reserveLimitTextBox.Text == "")
            {
                reserveLimitTextBox.Text = "<0000>";
            }
        }

        private void borrowingDurationTextBox_Enter(object sender, EventArgs e)
        {
            if (borrowingDurationTextBox.Text == "<0000>")
            {
                borrowingDurationTextBox.Text = "";
            }
        }

        private void borrowingDurationTextBox_Leave(object sender, EventArgs e)
        {
            if (borrowingDurationTextBox.Text == "")
            {
                borrowingDurationTextBox.Text = "<0000>";
            }
        }
    }
}