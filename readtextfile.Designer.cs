namespace MaandelijkseLonenPW1
{
    partial class readtextfile
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
            this.txtinhoud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtinhoud
            // 
            this.txtinhoud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtinhoud.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinhoud.Location = new System.Drawing.Point(12, 12);
            this.txtinhoud.Multiline = true;
            this.txtinhoud.Name = "txtinhoud";
            this.txtinhoud.ReadOnly = true;
            this.txtinhoud.Size = new System.Drawing.Size(359, 327);
            this.txtinhoud.TabIndex = 0;
            this.txtinhoud.TextChanged += new System.EventHandler(this.txtinhoud_TextChanged);
            // 
            // readtextfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 351);
            this.Controls.Add(this.txtinhoud);
            this.MinimumSize = new System.Drawing.Size(399, 390);
            this.Name = "readtextfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "readtextfile";
            this.Load += new System.EventHandler(this.readtextfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinhoud;
    }
}