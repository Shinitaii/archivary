﻿namespace Archivary
{
    partial class FORM_TITLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_TITLE));
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.goLoginButton = new roundedCorners.roundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(960, 650);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backgroundPictureBox.TabIndex = 1;
            this.backgroundPictureBox.TabStop = false;
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titlePictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogoBannerPNG;
            this.titlePictureBox.Location = new System.Drawing.Point(87, 92);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(775, 322);
            this.titlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlePictureBox.TabIndex = 2;
            this.titlePictureBox.TabStop = false;
            // 
            // goLoginButton
            // 
            this.goLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.goLoginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.goLoginButton.BorderColor = System.Drawing.Color.Empty;
            this.goLoginButton.BorderRadius = 30;
            this.goLoginButton.BorderSize = 0;
            this.goLoginButton.FlatAppearance.BorderSize = 0;
            this.goLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLoginButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.goLoginButton.Location = new System.Drawing.Point(257, 388);
            this.goLoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goLoginButton.Name = "goLoginButton";
            this.goLoginButton.Size = new System.Drawing.Size(437, 100);
            this.goLoginButton.TabIndex = 0;
            this.goLoginButton.Text = "Start";
            this.goLoginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.goLoginButton.UseVisualStyleBackColor = false;
            this.goLoginButton.Click += new System.EventHandler(this.goLoginButton_Click);
            // 
            // FORM_TITLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.ControlBox = false;
            this.Controls.Add(this.goLoginButton);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.backgroundPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_TITLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private roundedCorners.roundedButton goLoginButton;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.PictureBox titlePictureBox;
    }
}

