namespace Archivary.PARENT_FORMS
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
            this.LAYOUT_TOP = new System.Windows.Forms.Panel();
            this.bookCotainer_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedContainer_searchTextBox = new RoundedCorners.RoundedPanel();
            this.searchBookTextBox = new WHYWHYWHYW.RoundedTextBox();
            this.LAYOUT_TOP_RIGHT = new System.Windows.Forms.Panel();
            this.addBookButton = new sidebarComponents.sidebarButton();
            this.filterComboBox = new custom.CustomComboBox();
            this.booksContainer_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bookContainer = new System.Windows.Forms.Panel();
            this.LAYOUT_FILL_LEFT = new System.Windows.Forms.Panel();
            this.bookImagePictureBok = new System.Windows.Forms.PictureBox();
            this.viewBookButton = new roundedCorners.roundedButton();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roundedButton3 = new roundedCorners.roundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedTextBox1 = new WHYWHYWHYW.RoundedTextBox();
            this.LAYOUT_TOP.SuspendLayout();
            this.roundedContainer_searchTextBox.SuspendLayout();
            this.LAYOUT_TOP_RIGHT.SuspendLayout();
            this.booksContainer_flowLayoutPanel.SuspendLayout();
            this.bookContainer.SuspendLayout();
            this.LAYOUT_FILL_LEFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImagePictureBok)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYOUT_TOP
            // 
            this.LAYOUT_TOP.Controls.Add(this.bookCotainer_FlowLayoutPanel);
            this.LAYOUT_TOP.Controls.Add(this.roundedContainer_searchTextBox);
            this.LAYOUT_TOP.Controls.Add(this.LAYOUT_TOP_RIGHT);
            this.LAYOUT_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.LAYOUT_TOP.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_TOP.Name = "LAYOUT_TOP";
            this.LAYOUT_TOP.Size = new System.Drawing.Size(1920, 127);
            this.LAYOUT_TOP.TabIndex = 0;
            this.LAYOUT_TOP.Paint += new System.Windows.Forms.PaintEventHandler(this.LAYOUT_TOP_Paint);
            // 
            // bookCotainer_FlowLayoutPanel
            // 
            this.bookCotainer_FlowLayoutPanel.AutoScroll = true;
            this.bookCotainer_FlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.bookCotainer_FlowLayoutPanel.Location = new System.Drawing.Point(47, 131);
            this.bookCotainer_FlowLayoutPanel.Name = "bookCotainer_FlowLayoutPanel";
            this.bookCotainer_FlowLayoutPanel.Size = new System.Drawing.Size(1667, 974);
            this.bookCotainer_FlowLayoutPanel.TabIndex = 1;
            // 
            // roundedContainer_searchTextBox
            // 
            this.roundedContainer_searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedContainer_searchTextBox.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedContainer_searchTextBox.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedContainer_searchTextBox.BorderWidth = 1F;
            this.roundedContainer_searchTextBox.Controls.Add(this.searchBookTextBox);
            this.roundedContainer_searchTextBox.Location = new System.Drawing.Point(44, 44);
            this.roundedContainer_searchTextBox.Name = "roundedContainer_searchTextBox";
            this.roundedContainer_searchTextBox.Radius = 15;
            this.roundedContainer_searchTextBox.Size = new System.Drawing.Size(1381, 46);
            this.roundedContainer_searchTextBox.TabIndex = 2;
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBookTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBookTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.searchBookTextBox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.searchBookTextBox.Location = new System.Drawing.Point(2, 3);
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Radius = 12;
            this.searchBookTextBox.Size = new System.Drawing.Size(1376, 40);
            this.searchBookTextBox.TabIndex = 0;
            this.searchBookTextBox.Text = "Search Book";
            this.searchBookTextBox.Click += new System.EventHandler(this.searchBookTextBox_Click);
            this.searchBookTextBox.Enter += new System.EventHandler(this.searchBookTextBox_Enter);
            this.searchBookTextBox.Leave += new System.EventHandler(this.searchBookTextBox_Leave);
            // 
            // LAYOUT_TOP_RIGHT
            // 
            this.LAYOUT_TOP_RIGHT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LAYOUT_TOP_RIGHT.Controls.Add(this.addBookButton);
            this.LAYOUT_TOP_RIGHT.Controls.Add(this.filterComboBox);
            this.LAYOUT_TOP_RIGHT.Location = new System.Drawing.Point(1431, 3);
            this.LAYOUT_TOP_RIGHT.Name = "LAYOUT_TOP_RIGHT";
            this.LAYOUT_TOP_RIGHT.Size = new System.Drawing.Size(486, 121);
            this.LAYOUT_TOP_RIGHT.TabIndex = 1;
            // 
            // addBookButton
            // 
            this.addBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.addBookButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.addBookButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.addBookButton.BorderRadius = 20;
            this.addBookButton.BorderSize = 0;
            this.addBookButton.ButtonImage = null;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.addBookButton.Location = new System.Drawing.Point(242, 44);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(206, 40);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "ADD";
            this.addBookButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.addBookButton.UseVisualStyleBackColor = false;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filterComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.filterComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.filterComboBox.BorderRadius = 40;
            this.filterComboBox.BorderSize = 1;
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.filterComboBox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.filterComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.filterComboBox.Items.AddRange(new object[] {
            "All",
            "Book Name",
            "Author",
            "Category",
            "Genre",
            "ISBN"});
            this.filterComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.filterComboBox.Location = new System.Drawing.Point(2, 44);
            this.filterComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.filterComboBox.Size = new System.Drawing.Size(234, 40);
            this.filterComboBox.TabIndex = 3;
            this.filterComboBox.Texts = "";
            // 
            // booksContainer_flowLayoutPanel
            // 
            this.booksContainer_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksContainer_flowLayoutPanel.AutoScroll = true;
            this.booksContainer_flowLayoutPanel.AutoSize = true;
            this.booksContainer_flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.booksContainer_flowLayoutPanel.Controls.Add(this.bookContainer);
            this.booksContainer_flowLayoutPanel.Controls.Add(this.panel5);
            this.booksContainer_flowLayoutPanel.Location = new System.Drawing.Point(47, 126);
            this.booksContainer_flowLayoutPanel.Name = "booksContainer_flowLayoutPanel";
            this.booksContainer_flowLayoutPanel.Size = new System.Drawing.Size(1817, 907);
            this.booksContainer_flowLayoutPanel.TabIndex = 1;
            this.booksContainer_flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.booksContainer_flowLayoutPanel_Paint);
            // 
            // bookContainer
            // 
            this.bookContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bookContainer.BackColor = System.Drawing.Color.White;
            this.bookContainer.Controls.Add(this.LAYOUT_FILL_LEFT);
            this.bookContainer.Controls.Add(this.viewBookButton);
            this.bookContainer.Controls.Add(this.ISBNLabel);
            this.bookContainer.Controls.Add(this.bookAuthorLabel);
            this.bookContainer.Controls.Add(this.bookTitleLabel);
            this.bookContainer.Location = new System.Drawing.Point(3, 3);
            this.bookContainer.Name = "bookContainer";
            this.bookContainer.Size = new System.Drawing.Size(869, 227);
            this.bookContainer.TabIndex = 8;
            // 
            // LAYOUT_FILL_LEFT
            // 
            this.LAYOUT_FILL_LEFT.Controls.Add(this.bookImagePictureBok);
            this.LAYOUT_FILL_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.LAYOUT_FILL_LEFT.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_FILL_LEFT.Name = "LAYOUT_FILL_LEFT";
            this.LAYOUT_FILL_LEFT.Size = new System.Drawing.Size(244, 227);
            this.LAYOUT_FILL_LEFT.TabIndex = 7;
            // 
            // bookImagePictureBok
            // 
            this.bookImagePictureBok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bookImagePictureBok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.bookImagePictureBok.Location = new System.Drawing.Point(54, 17);
            this.bookImagePictureBok.Name = "bookImagePictureBok";
            this.bookImagePictureBok.Size = new System.Drawing.Size(165, 189);
            this.bookImagePictureBok.TabIndex = 2;
            this.bookImagePictureBok.TabStop = false;
            // 
            // viewBookButton
            // 
            this.viewBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.viewBookButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.viewBookButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.viewBookButton.BorderRadius = 40;
            this.viewBookButton.BorderSize = 0;
            this.viewBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBookButton.FlatAppearance.BorderSize = 0;
            this.viewBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBookButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.viewBookButton.Location = new System.Drawing.Point(253, 144);
            this.viewBookButton.Name = "viewBookButton";
            this.viewBookButton.Size = new System.Drawing.Size(600, 40);
            this.viewBookButton.TabIndex = 6;
            this.viewBookButton.Text = "VIEW BOOK";
            this.viewBookButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.viewBookButton.UseVisualStyleBackColor = false;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(255, 109);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(158, 21);
            this.ISBNLabel.TabIndex = 5;
            this.ISBNLabel.Text = "ISBN: 9781501139239";
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthorLabel.Location = new System.Drawing.Point(254, 85);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(216, 21);
            this.bookAuthorLabel.TabIndex = 4;
            this.bookAuthorLabel.Text = "Author: Reid, Taylor Jenkins";
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.bookTitleLabel.Location = new System.Drawing.Point(250, 55);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(450, 27);
            this.bookTitleLabel.TabIndex = 3;
            this.bookTitleLabel.Text = "THE SEVEN HUSBANDS OF EVELYN HUGO";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.roundedButton3);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(878, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(869, 227);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 227);
            this.panel6.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.pictureBox3.Location = new System.Drawing.Point(54, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 189);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // roundedButton3
            // 
            this.roundedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.roundedButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.roundedButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.roundedButton3.BorderRadius = 40;
            this.roundedButton3.BorderSize = 0;
            this.roundedButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.roundedButton3.Location = new System.Drawing.Point(253, 144);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(600, 40);
            this.roundedButton3.TabIndex = 6;
            this.roundedButton3.Text = "VIEW BOOK";
            this.roundedButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "ISBN: 9781501139239";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Author: Reid, Taylor Jenkins";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(250, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(450, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "THE SEVEN HUSBANDS OF EVELYN HUGO";
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBox1.Br = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.roundedTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roundedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBox1.Location = new System.Drawing.Point(3, 5);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Radius = 12;
            this.roundedTextBox1.Size = new System.Drawing.Size(1374, 38);
            this.roundedTextBox1.TabIndex = 0;
            this.roundedTextBox1.Text = "roundedTextBox1";
            // 
            // FORM_LIBRARY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.booksContainer_flowLayoutPanel);
            this.Controls.Add(this.LAYOUT_TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FORM_LIBRARY";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FORM_LIBRARY_Load);
            this.LAYOUT_TOP.ResumeLayout(false);
            this.roundedContainer_searchTextBox.ResumeLayout(false);
            this.LAYOUT_TOP_RIGHT.ResumeLayout(false);
            this.booksContainer_flowLayoutPanel.ResumeLayout(false);
            this.bookContainer.ResumeLayout(false);
            this.bookContainer.PerformLayout();
            this.LAYOUT_FILL_LEFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookImagePictureBok)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LAYOUT_TOP;
        private System.Windows.Forms.Panel LAYOUT_TOP_RIGHT;
        private custom.CustomComboBox filterComboBox;
        private RoundedCorners.RoundedPanel roundedContainer_searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel bookCotainer_FlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel booksContainer_flowLayoutPanel;
        private sidebarComponents.sidebarButton addBookButton;
        private WHYWHYWHYW.RoundedTextBox roundedTextBox1;
        private WHYWHYWHYW.RoundedTextBox searchBookTextBox;
        private System.Windows.Forms.Panel bookContainer;
        private System.Windows.Forms.Panel LAYOUT_FILL_LEFT;
        private System.Windows.Forms.PictureBox bookImagePictureBok;
        private roundedCorners.roundedButton viewBookButton;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private roundedCorners.roundedButton roundedButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}