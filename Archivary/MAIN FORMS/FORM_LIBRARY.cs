using Archivary.Archivary_Components;
using CustomDropdown;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_LIBRARY : Form
    {
        private int buttonWidth;
        private int buttonWidth1;
        private Button buttonize;
        private bookDetails bookInfo;
       

        //
        // COLOR METHODS
        //
        private Color archivaryGreen()
        {
            return Color.FromArgb(37, 211, 102);
        }

        private Color archivaryWhite()
        {
            return Color.FromArgb(244, 244, 244);
        }

        private Color archivaryHoverGray()
        {
            return Color.FromArgb(200, 200, 200);
        }

        //MAIN
        public FORM_LIBRARY()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private async void FORM_LIBRARY_Load(object sender, EventArgs e)
        {
            dropdownProperties();
            LoadListAsync();
        }

        private void FORM_LIBRARY_Resize(object sender, EventArgs e)
        {
            LoadListAsync();
        }
        private async Task LoadListAsync()
        {   
            await Task.Run(() =>
            {
                Task.Delay(500).Wait();
                libraryList.Controls.Clear(); // Clear existing controls

                buttonWidth = ((libraryList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth) / 2) - 20;
                buttonWidth1 = (libraryList.ClientSize.Width / 2) - 20;

                int maxButtons = 100;

                // Adjust padding to provide space at the bottom
                libraryList.Padding = new Padding(0, 0, 0, 10);


                for (int i = 0; i < maxButtons; i++)
                {
                    CreateButtons1Async(i, maxButtons);
                    Task.Delay(200);
                }
            });
        }
        private async Task CreateButtons1Async(int i, int maxButtons)
        {
            if (libraryList.InvokeRequired)
            {
                libraryList.BeginInvoke(new MethodInvoker(() => CreateButtons1Async(i, maxButtons)));
                return;
            }

            //int total = 0;

            bookInfo = new bookDetails();
            bookInfo.Text = "Button " + i;
            bookInfo.Height = 200;
            bookInfo.Margin = new Padding(10);
            libraryList.Controls.Add(bookInfo);
            //total += i;
            if (maxButtons <= 4)
            {
                bookInfo.Width = buttonWidth1;
            }
            else if (maxButtons > 4)
            {
                bookInfo.Width = buttonWidth;
            }
        }
        private void dropdownProperties()
        {
            filterDropdown.IsMainMenu = true;
            filterDropdown.PrimaryColor = archivaryGreen();
        }

        private void openDropdownMenu(DropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            //dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
            dropdownMenu.Show(control, control.Width - control.Width, control.Height);
        }

        private void filterSearchButton_Click(object sender, EventArgs e)
        {
            openDropdownMenu(filterDropdown, sender);
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Search Book")
            {
                searchBar.Text = "";
                searchBar.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
                searchBar.ForeColor = archivaryWhite();
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "Search Book";
                searchBar.ForeColor = archivaryHoverGray();
                searchBar.Font = new Font("Montserrat Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
        }

        //
        // DROPDOWN EVENTS
        //
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "All";
        }

        private void bookNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Book Name";
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Author";
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Category";
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Genre";
        }

        private void ISBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "ISBN";
        }

        private void libraryList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
