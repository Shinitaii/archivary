﻿namespace Archivary.PARENT_FORMS
{
    partial class FORM_LIBRARY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LIBRARY));
            this.PANEL_libraryListContainer = new System.Windows.Forms.Panel();
            this.libraryList = new System.Windows.Forms.FlowLayoutPanel();
            this.filterSearchButton = new sidebarComponents.RoundedPictureButtonRight();
            this.addBookButton = new sidebarComponents.RoundedSidebarButton();
            this.LAYOUT_searchBar = new RoundedCorners.RoundedPanel();
            this.searchBar = new RoundedCorners.RoundedTextBox();
            this.filterDropdown = new CustomDropdown.DropdownMenu(this.components);
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NonFictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcademicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PANEL_libraryListContainer.SuspendLayout();
            this.LAYOUT_searchBar.SuspendLayout();
            this.filterDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_libraryListContainer
            // 
            this.PANEL_libraryListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_libraryListContainer.Controls.Add(this.libraryList);
            this.PANEL_libraryListContainer.Location = new System.Drawing.Point(0, 90);
            this.PANEL_libraryListContainer.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_libraryListContainer.Name = "PANEL_libraryListContainer";
            this.PANEL_libraryListContainer.Size = new System.Drawing.Size(958, 580);
            this.PANEL_libraryListContainer.TabIndex = 2;
            // 
            // libraryList
            // 
            this.libraryList.AutoScroll = true;
            this.libraryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.libraryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryList.Location = new System.Drawing.Point(0, 0);
            this.libraryList.Name = "libraryList";
            this.libraryList.Size = new System.Drawing.Size(958, 580);
            this.libraryList.TabIndex = 0;
            // 
            // filterSearchButton
            // 
            this.filterSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.filterSearchButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.filterSearchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filterSearchButton.BorderRadius = 10;
            this.filterSearchButton.BorderSize = 0;
            this.filterSearchButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("filterSearchButton.ButtonImage")));
            this.filterSearchButton.FlatAppearance.BorderSize = 0;
            this.filterSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterSearchButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterSearchButton.ForeColor = System.Drawing.Color.White;
            this.filterSearchButton.Location = new System.Drawing.Point(641, 12);
            this.filterSearchButton.Name = "filterSearchButton";
            this.filterSearchButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.filterSearchButton.Size = new System.Drawing.Size(150, 54);
            this.filterSearchButton.TabIndex = 6;
            this.filterSearchButton.Text = "Filter";
            this.filterSearchButton.TextColor = System.Drawing.Color.White;
            this.filterSearchButton.UseVisualStyleBackColor = false;
            this.filterSearchButton.Click += new System.EventHandler(this.filterSearchButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addBookButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addBookButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addBookButton.BorderRadius = 10;
            this.addBookButton.BorderSize = 0;
            this.addBookButton.ButtonImage = global::Archivary.Properties.Resources.ICON_ADD;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Location = new System.Drawing.Point(797, 12);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addBookButton.Size = new System.Drawing.Size(150, 54);
            this.addBookButton.TabIndex = 5;
            this.addBookButton.Text = "Add";
            this.addBookButton.TextColor = System.Drawing.Color.White;
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // LAYOUT_searchBar
            // 
            this.LAYOUT_searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAYOUT_searchBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBar.BorderWidth = 1F;
            this.LAYOUT_searchBar.Controls.Add(this.searchBar);
            this.LAYOUT_searchBar.Location = new System.Drawing.Point(12, 12);
            this.LAYOUT_searchBar.Name = "LAYOUT_searchBar";
            this.LAYOUT_searchBar.Padding = new System.Windows.Forms.Padding(2);
            this.LAYOUT_searchBar.Radius = 10;
            this.LAYOUT_searchBar.Size = new System.Drawing.Size(623, 54);
            this.LAYOUT_searchBar.TabIndex = 0;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.Transparent;
            this.searchBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchBar.BorderThickness = 0;
            this.searchBar.Br = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchBar.Location = new System.Drawing.Point(2, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Radius = 9;
            this.searchBar.ReadOnly = false;
            this.searchBar.Size = new System.Drawing.Size(619, 50);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Search Book";
            this.searchBar.UseSystemPasswordChar = false;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // filterDropdown
            // 
            this.filterDropdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filterDropdown.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filterDropdown.IsMainMenu = false;
            this.filterDropdown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.FictionToolStripMenuItem,
            this.NonFictionToolStripMenuItem,
            this.AcademicToolStripMenuItem});
            this.filterDropdown.MenuItemHeight = 25;
            this.filterDropdown.MenuItemTextColor = System.Drawing.Color.Empty;
            this.filterDropdown.Name = "dropdownMenu1";
            this.filterDropdown.PrimaryColor = System.Drawing.Color.Empty;
            this.filterDropdown.Size = new System.Drawing.Size(157, 108);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // FictionToolStripMenuItem
            // 
            this.FictionToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9F);
            this.FictionToolStripMenuItem.Name = "FictionToolStripMenuItem";
            this.FictionToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.FictionToolStripMenuItem.Text = "Fiction";
            this.FictionToolStripMenuItem.Click += new System.EventHandler(this.FictionToolStripMenuItem_Click);
            // 
            // NonFictionToolStripMenuItem
            // 
            this.NonFictionToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9F);
            this.NonFictionToolStripMenuItem.Name = "NonFictionToolStripMenuItem";
            this.NonFictionToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.NonFictionToolStripMenuItem.Text = "Nonfiction";
            this.NonFictionToolStripMenuItem.Click += new System.EventHandler(this.NonFictionToolStripMenuItem_Click);
            // 
            // AcademicToolStripMenuItem
            // 
            this.AcademicToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9F);
            this.AcademicToolStripMenuItem.Name = "AcademicToolStripMenuItem";
            this.AcademicToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.AcademicToolStripMenuItem.Text = "Academic";
            this.AcademicToolStripMenuItem.Click += new System.EventHandler(this.AcademicToolStripMenuItem_Click);
            // 
            // FORM_LIBRARY
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.filterSearchButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.LAYOUT_searchBar);
            this.Controls.Add(this.PANEL_libraryListContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_LIBRARY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_LIBRARY_Load);
            this.Resize += new System.EventHandler(this.FORM_LIBRARY_Resize);
            this.PANEL_libraryListContainer.ResumeLayout(false);
            this.LAYOUT_searchBar.ResumeLayout(false);
            this.filterDropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedCorners.RoundedPanel LAYOUT_searchBar;
        private System.Windows.Forms.Panel PANEL_libraryListContainer;
        public System.Windows.Forms.FlowLayoutPanel libraryList;
        private sidebarComponents.RoundedSidebarButton addBookButton;
        private sidebarComponents.RoundedPictureButtonRight filterSearchButton;
        private CustomDropdown.DropdownMenu filterDropdown;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NonFictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcademicToolStripMenuItem;
        private RoundedCorners.RoundedTextBox searchBar;
    }
}