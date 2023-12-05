namespace Archivary.PARENT_FORMS
{
    partial class FORM_USERS
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
            this.LAYOUT_FILL = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LAYOUT_FILL
            // 
            this.LAYOUT_FILL.AutoScroll = true;
            this.LAYOUT_FILL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LAYOUT_FILL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_FILL.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_FILL.Name = "LAYOUT_FILL";
            this.LAYOUT_FILL.Size = new System.Drawing.Size(1482, 953);
            this.LAYOUT_FILL.TabIndex = 10;
            // 
            // FORM_USERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.LAYOUT_FILL);
            this.Name = "FORM_USERS";
            this.Text = "FORM_USERS";
            this.Load += new System.EventHandler(this.FORM_USERS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LAYOUT_FILL;
    }
}