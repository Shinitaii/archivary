using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_LIBRARY : Form
    {
        public FORM_LIBRARY()
        {
            InitializeComponent();
        }

        private void libraryFilterComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {

        }
       

        private void FORM_LIBRARY_Load(object sender, EventArgs e)
        {

        }

        private void searchBookTextBox_Enter(object sender, EventArgs e)
        {
            if(searchBookTextBox.Text == "Search Book")
            {
                searchBookTextBox.Text = "";
            }
        }

        private void searchBookTextBox_Leave(object sender, EventArgs e)
        {
            if(searchBookTextBox.Text == "")
            {
                searchBookTextBox.Text = "Search Book";
            }
        }

        private void booksContainer_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBookTextBox_Click(object sender, EventArgs e)
        {

        }

        private void LAYOUT_TOP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
