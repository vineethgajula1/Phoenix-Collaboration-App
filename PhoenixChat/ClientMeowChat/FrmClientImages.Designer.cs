﻿namespace PhoenixChatClient
{
    partial class FrmClientImages
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
            this.TabControlClientImages = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // TabControlClientImages
            // 
            this.TabControlClientImages.Location = new System.Drawing.Point(3, 3);
            this.TabControlClientImages.Name = "TabControlClientImages";
            this.TabControlClientImages.SelectedIndex = 0;
            this.TabControlClientImages.Size = new System.Drawing.Size(410, 399);
            this.TabControlClientImages.TabIndex = 1;
            // 
            // FrmClientImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 404);
            this.Controls.Add(this.TabControlClientImages);
            this.MaximizeBox = false;
            this.Name = "FrmClientImages";
            this.Text = "FrmImage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmImage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControlClientImages;
    }
}