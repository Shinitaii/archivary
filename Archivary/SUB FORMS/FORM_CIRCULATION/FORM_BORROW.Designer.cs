﻿namespace Archivary.SUB_FORMS
{
    partial class FORM_BORROW
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MAIN_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.left_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.right_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.collegeLabel = new System.Windows.Forms.Label();
            this.IDInputLabel = new System.Windows.Forms.Label();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.collegeInputLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LAYOUT_searchBook = new RoundedCorners.RoundedPanel();
            this.searchBook = new RoundedCorners.RoundedTextBox();
            this.LAYOUT_searchID = new RoundedCorners.RoundedPanel();
            this.searchID = new RoundedCorners.RoundedTextBox();
            this.borrowButton = new roundedCorners.roundedButton();
            this.clearButton = new roundedCorners.roundedButton();
            this.reserveButton = new roundedCorners.roundedButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIN_TableLayout.SuspendLayout();
            this.left_TableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.right_TableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LAYOUT_searchBook.SuspendLayout();
            this.LAYOUT_searchID.SuspendLayout();
            this.SuspendLayout();
            // 
            // MAIN_TableLayout
            // 
            this.MAIN_TableLayout.ColumnCount = 2;
            this.MAIN_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MAIN_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MAIN_TableLayout.Controls.Add(this.left_TableLayout, 0, 0);
            this.MAIN_TableLayout.Controls.Add(this.right_TableLayout, 1, 0);
            this.MAIN_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MAIN_TableLayout.Location = new System.Drawing.Point(11, 10);
            this.MAIN_TableLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MAIN_TableLayout.Name = "MAIN_TableLayout";
            this.MAIN_TableLayout.RowCount = 1;
            this.MAIN_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MAIN_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MAIN_TableLayout.Size = new System.Drawing.Size(919, 603);
            this.MAIN_TableLayout.TabIndex = 0;
            // 
            // left_TableLayout
            // 
            this.left_TableLayout.ColumnCount = 1;
            this.left_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.left_TableLayout.Controls.Add(this.LAYOUT_searchBook, 0, 0);
            this.left_TableLayout.Controls.Add(this.BooksDataGridView, 0, 2);
            this.left_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_TableLayout.Location = new System.Drawing.Point(3, 2);
            this.left_TableLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.left_TableLayout.Name = "left_TableLayout";
            this.left_TableLayout.RowCount = 3;
            this.left_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.left_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.left_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.left_TableLayout.Size = new System.Drawing.Size(453, 599);
            this.left_TableLayout.TabIndex = 0;
            this.left_TableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.left_TableLayout_Paint);
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.AllowUserToAddRows = false;
            this.BooksDataGridView.AllowUserToDeleteRows = false;
            this.BooksDataGridView.AllowUserToResizeColumns = false;
            this.BooksDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BooksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BooksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BooksDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.BooksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureHeader,
            this.TitleColumn,
            this.ISBNColumn,
            this.StatusColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BooksDataGridView.EnableHeadersVisualStyles = false;
            this.BooksDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BooksDataGridView.Location = new System.Drawing.Point(3, 79);
            this.BooksDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BooksDataGridView.MultiSelect = false;
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.ReadOnly = true;
            this.BooksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BooksDataGridView.RowHeadersVisible = false;
            this.BooksDataGridView.RowHeadersWidth = 51;
            this.BooksDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BooksDataGridView.RowTemplate.Height = 24;
            this.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksDataGridView.Size = new System.Drawing.Size(447, 518);
            this.BooksDataGridView.TabIndex = 1;
            // 
            // right_TableLayout
            // 
            this.right_TableLayout.ColumnCount = 3;
            this.right_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.right_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.right_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.right_TableLayout.Controls.Add(this.LAYOUT_searchID, 0, 0);
            this.right_TableLayout.Controls.Add(this.borrowButton, 0, 7);
            this.right_TableLayout.Controls.Add(this.clearButton, 0, 9);
            this.right_TableLayout.Controls.Add(this.IDLabel, 0, 2);
            this.right_TableLayout.Controls.Add(this.nameLabel, 0, 3);
            this.right_TableLayout.Controls.Add(this.collegeLabel, 0, 4);
            this.right_TableLayout.Controls.Add(this.reserveButton, 2, 7);
            this.right_TableLayout.Controls.Add(this.IDInputLabel, 1, 2);
            this.right_TableLayout.Controls.Add(this.nameInputLabel, 1, 3);
            this.right_TableLayout.Controls.Add(this.collegeInputLabel, 1, 4);
            this.right_TableLayout.Controls.Add(this.dataGridView1, 0, 5);
            this.right_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_TableLayout.Location = new System.Drawing.Point(462, 2);
            this.right_TableLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.right_TableLayout.Name = "right_TableLayout";
            this.right_TableLayout.RowCount = 10;
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.right_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.right_TableLayout.Size = new System.Drawing.Size(454, 599);
            this.right_TableLayout.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.IDLabel.Location = new System.Drawing.Point(3, 77);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(107, 50);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID:";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.nameLabel.Location = new System.Drawing.Point(3, 127);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 50);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // collegeLabel
            // 
            this.collegeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.collegeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collegeLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collegeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.collegeLabel.Location = new System.Drawing.Point(3, 177);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Size = new System.Drawing.Size(107, 50);
            this.collegeLabel.TabIndex = 6;
            this.collegeLabel.Text = "College:";
            this.collegeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IDInputLabel
            // 
            this.IDInputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.right_TableLayout.SetColumnSpan(this.IDInputLabel, 2);
            this.IDInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDInputLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDInputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.IDInputLabel.Location = new System.Drawing.Point(116, 77);
            this.IDInputLabel.Name = "IDInputLabel";
            this.IDInputLabel.Size = new System.Drawing.Size(335, 50);
            this.IDInputLabel.TabIndex = 7;
            this.IDInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameInputLabel
            // 
            this.right_TableLayout.SetColumnSpan(this.nameInputLabel, 2);
            this.nameInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameInputLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.nameInputLabel.Location = new System.Drawing.Point(116, 127);
            this.nameInputLabel.Name = "nameInputLabel";
            this.nameInputLabel.Size = new System.Drawing.Size(335, 50);
            this.nameInputLabel.TabIndex = 8;
            this.nameInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // collegeInputLabel
            // 
            this.collegeInputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.right_TableLayout.SetColumnSpan(this.collegeInputLabel, 2);
            this.collegeInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collegeInputLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collegeInputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.collegeInputLabel.Location = new System.Drawing.Point(116, 177);
            this.collegeInputLabel.Name = "collegeInputLabel";
            this.collegeInputLabel.Size = new System.Drawing.Size(335, 50);
            this.collegeInputLabel.TabIndex = 9;
            this.collegeInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.StatusColumn1});
            this.right_TableLayout.SetColumnSpan(this.dataGridView1, 3);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 208);
            this.dataGridView1.TabIndex = 10;
            // 
            // LAYOUT_searchBook
            // 
            this.LAYOUT_searchBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBook.BorderWidth = 1F;
            this.LAYOUT_searchBook.Controls.Add(this.searchBook);
            this.LAYOUT_searchBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.LAYOUT_searchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_searchBook.Location = new System.Drawing.Point(3, 2);
            this.LAYOUT_searchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LAYOUT_searchBook.Name = "LAYOUT_searchBook";
            this.LAYOUT_searchBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LAYOUT_searchBook.Radius = 10;
            this.LAYOUT_searchBook.Size = new System.Drawing.Size(447, 53);
            this.LAYOUT_searchBook.TabIndex = 0;
            // 
            // searchBook
            // 
            this.searchBook.BackColor = System.Drawing.Color.Transparent;
            this.searchBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchBook.BorderThickness = 0;
            this.searchBook.Br = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBook.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchBook.Location = new System.Drawing.Point(3, 2);
            this.searchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBook.Name = "searchBook";
            this.searchBook.Radius = 9;
            this.searchBook.ReadOnly = false;
            this.searchBook.Size = new System.Drawing.Size(441, 49);
            this.searchBook.TabIndex = 0;
            this.searchBook.Text = "Search by Book";
            this.searchBook.UseSystemPasswordChar = false;
            this.searchBook.TextChanged += new System.EventHandler(this.searchBook_TextChanged);
            this.searchBook.Enter += new System.EventHandler(this.searchBook_Enter);
            this.searchBook.Leave += new System.EventHandler(this.searchBook_Leave);
            // 
            // LAYOUT_searchID
            // 
            this.LAYOUT_searchID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchID.BorderWidth = 1F;
            this.right_TableLayout.SetColumnSpan(this.LAYOUT_searchID, 3);
            this.LAYOUT_searchID.Controls.Add(this.searchID);
            this.LAYOUT_searchID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_searchID.Location = new System.Drawing.Point(3, 2);
            this.LAYOUT_searchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LAYOUT_searchID.Name = "LAYOUT_searchID";
            this.LAYOUT_searchID.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LAYOUT_searchID.Radius = 10;
            this.LAYOUT_searchID.Size = new System.Drawing.Size(448, 53);
            this.LAYOUT_searchID.TabIndex = 0;
            // 
            // searchID
            // 
            this.searchID.BackColor = System.Drawing.Color.Transparent;
            this.searchID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchID.BorderThickness = 0;
            this.searchID.Br = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchID.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchID.Location = new System.Drawing.Point(3, 2);
            this.searchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchID.Name = "searchID";
            this.searchID.Radius = 9;
            this.searchID.ReadOnly = false;
            this.searchID.Size = new System.Drawing.Size(442, 49);
            this.searchID.TabIndex = 0;
            this.searchID.Text = "Search by User ID";
            this.searchID.UseSystemPasswordChar = false;
            this.searchID.TextChanged += new System.EventHandler(this.searchID_TextChanged);
            this.searchID.Enter += new System.EventHandler(this.searchID_Enter);
            this.searchID.Leave += new System.EventHandler(this.searchID_Leave);
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.borrowButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.borrowButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borrowButton.BorderRadius = 20;
            this.borrowButton.BorderSize = 0;
            this.right_TableLayout.SetColumnSpan(this.borrowButton, 2);
            this.borrowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowButton.FlatAppearance.BorderSize = 0;
            this.borrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.ForeColor = System.Drawing.Color.White;
            this.borrowButton.Location = new System.Drawing.Point(3, 451);
            this.borrowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(220, 66);
            this.borrowButton.TabIndex = 1;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.TextColor = System.Drawing.Color.White;
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.clearButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.clearButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clearButton.BorderRadius = 15;
            this.clearButton.BorderSize = 0;
            this.right_TableLayout.SetColumnSpan(this.clearButton, 3);
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.clearButton.Location = new System.Drawing.Point(3, 531);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(448, 66);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.reserveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.reserveButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.reserveButton.BorderRadius = 20;
            this.reserveButton.BorderSize = 0;
            this.reserveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reserveButton.FlatAppearance.BorderSize = 0;
            this.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.Color.White;
            this.reserveButton.Location = new System.Drawing.Point(229, 451);
            this.reserveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(222, 66);
            this.reserveButton.TabIndex = 2;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.TextColor = System.Drawing.Color.White;
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // pictureHeader
            // 
            this.pictureHeader.HeaderText = "PICTURE";
            this.pictureHeader.MinimumWidth = 6;
            this.pictureHeader.Name = "pictureHeader";
            this.pictureHeader.ReadOnly = true;
            this.pictureHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "TITLE";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // ISBNColumn
            // 
            this.ISBNColumn.HeaderText = "ISBN";
            this.ISBNColumn.MinimumWidth = 6;
            this.ISBNColumn.Name = "ISBNColumn";
            this.ISBNColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "STATUS";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PICTURE";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TITLE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // StatusColumn1
            // 
            this.StatusColumn1.HeaderText = "STATUS";
            this.StatusColumn1.MinimumWidth = 6;
            this.StatusColumn1.Name = "StatusColumn1";
            this.StatusColumn1.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // ISBNColumn
            // 
            this.ISBNColumn.HeaderText = "ISBN";
            this.ISBNColumn.MinimumWidth = 6;
            this.ISBNColumn.Name = "ISBNColumn";
            this.ISBNColumn.ReadOnly = true;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // pictureHeader
            // 
            this.pictureHeader.HeaderText = "Picture";
            this.pictureHeader.MinimumWidth = 6;
            this.pictureHeader.Name = "pictureHeader";
            this.pictureHeader.ReadOnly = true;
            this.pictureHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FORM_BORROW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(941, 623);
            this.ControlBox = false;
            this.Controls.Add(this.MAIN_TableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_BORROW";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_BORROW";
            this.Load += new System.EventHandler(this.FORM_BORROW_Load);
            this.MAIN_TableLayout.ResumeLayout(false);
            this.left_TableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.right_TableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LAYOUT_searchBook.ResumeLayout(false);
            this.LAYOUT_searchID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MAIN_TableLayout;
        private System.Windows.Forms.TableLayoutPanel left_TableLayout;
        private System.Windows.Forms.TableLayoutPanel right_TableLayout;
        private RoundedCorners.RoundedPanel LAYOUT_searchBook;
        private RoundedCorners.RoundedPanel LAYOUT_searchID;
        private RoundedCorners.RoundedTextBox searchID;
        private RoundedCorners.RoundedTextBox searchBook;
        private roundedCorners.roundedButton borrowButton;
        private roundedCorners.roundedButton reserveButton;
        private roundedCorners.roundedButton clearButton;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label collegeLabel;
        private System.Windows.Forms.Label IDInputLabel;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Label collegeInputLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}