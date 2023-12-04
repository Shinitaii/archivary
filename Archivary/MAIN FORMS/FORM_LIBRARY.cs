using Archivary._1500X1000.FORM_LIBRARY;
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

        
        private void searchBookTextBox_Click(object sender, EventArgs e)
        {

        }

        private void LAYOUT_TOP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookCotainer_FlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void addBookButton_Click_1(object sender, EventArgs e)
        {
            using (FORM_BOOKADD popupAdd = new FORM_BOOKADD())
            {
                popupAdd.ShowInTaskbar = false;
                DialogResult result = popupAdd.ShowDialog();
            }
        }

       

        private void booksContainerFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewBookButton_Click_1(object sender, EventArgs e)
        {
            using (FORM_BOOKINFO popupInfo = new FORM_BOOKINFO())
            {
                popupInfo.ShowInTaskbar = false;
                DialogResult result = popupInfo.ShowDialog();
            }
        }
    }
}
