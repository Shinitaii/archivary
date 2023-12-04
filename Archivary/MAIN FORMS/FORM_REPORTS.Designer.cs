namespace Archivary.PARENT_FORMS
{
    partial class FORM_REPORTS
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
            this.roundedTextBox1 = new WHYWHYWHYW.RoundedTextBox();
            this.SuspendLayout();
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBox1.Br = System.Drawing.Color.White;
            this.roundedTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roundedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBox1.Location = new System.Drawing.Point(264, 79);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Radius = 15;
            this.roundedTextBox1.Size = new System.Drawing.Size(413, 33);
            this.roundedTextBox1.TabIndex = 0;
            this.roundedTextBox1.Text = "unfair";
            this.roundedTextBox1.Enter += new System.EventHandler(this.roundedTextBox1_Enter);
            // 
            // FORM_REPORTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedTextBox1);
            this.Name = "FORM_REPORTS";
            this.Text = "FORM_REPORTS";
            this.ResumeLayout(false);

        }

        #endregion

        private WHYWHYWHYW.RoundedTextBox roundedTextBox1;
    }
}