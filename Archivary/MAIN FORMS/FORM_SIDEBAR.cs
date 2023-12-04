//using Archivary.MAIN_FORMS;
using Archivary._1500X1000.FORM_LIBRARY;
using Archivary.MAIN_FORMS;
using Archivary.PARENT_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary
{
    public partial class FORM_SIDEBAR : Form
    {
        private FORM_ROOT FormsRoot;
        private FORM_LOGIN FormsLogin;

        private bool isToggled = false;

        public FORM_SIDEBAR(FORM_ROOT showFormsRoot)
        {
            InitializeComponent();
            FormsRoot = showFormsRoot;
        }

        private void FORM_SIDEBAR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsRoot.loadParentForm(new FORM_LOGIN(FormsRoot));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            collapseSidebar();
        }

        private void collapseSidebar()
        {
            if (isToggled)
            {
                logoPictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogoGreen;
                PANEL_SIDEBAR.Size = new System.Drawing.Size(80, 1080);
            }
            else
            {
                logoPictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogoBannerPNG;
                PANEL_SIDEBAR.Size = new System.Drawing.Size(320, 1080);
            }
        }
        //
        // LibraryButton
        //
        private void panel_libraryButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel_libraryButton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel_libraryButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void libraryTemporary_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            FORM_LIBRARY lIBRARY = new FORM_LIBRARY();
            lIBRARY.Show();
            
        }

        private void settings_TemporaryButton_Click(object sender, EventArgs e)
        {
            FORM_SETTINGS SETTINGS = new FORM_SETTINGS();
            SETTINGS.Show();
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
           FORM_BOOKINFO INFO = new FORM_BOOKINFO();
            INFO.Show();
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            FORM_BOOKEDIT EFIT = new FORM_BOOKEDIT();
            EFIT.Show();
            this.Close();
        }

        private void bookAdd_TemporaryButton_Click(object sender, EventArgs e)
        {
            FORM_BOOKADD ADD = new FORM_BOOKADD();
            ADD.Show();
            this.Close();
        }
    }
}
