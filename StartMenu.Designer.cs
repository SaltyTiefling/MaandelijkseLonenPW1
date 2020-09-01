namespace MaandelijkseLonenPW1
{
    partial class StartMenu
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
            this.lbxWerknemers = new System.Windows.Forms.ListBox();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.btnVerander = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxWerknemers
            // 
            this.lbxWerknemers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxWerknemers.FormattingEnabled = true;
            this.lbxWerknemers.Location = new System.Drawing.Point(16, 29);
            this.lbxWerknemers.Name = "lbxWerknemers";
            this.lbxWerknemers.Size = new System.Drawing.Size(175, 160);
            this.lbxWerknemers.TabIndex = 0;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaakAan.Location = new System.Drawing.Point(197, 29);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(75, 23);
            this.btnMaakAan.TabIndex = 1;
            this.btnMaakAan.Text = "Nieuwe";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            this.btnMaakAan.Click += new System.EventHandler(this.btnMaakAan_Click);
            // 
            // btnVerander
            // 
            this.btnVerander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerander.Location = new System.Drawing.Point(197, 58);
            this.btnVerander.Name = "btnVerander";
            this.btnVerander.Size = new System.Drawing.Size(75, 23);
            this.btnVerander.TabIndex = 2;
            this.btnVerander.Text = "Pas aan";
            this.btnVerander.UseVisualStyleBackColor = true;
            this.btnVerander.Click += new System.EventHandler(this.btnVerander_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijder.Location = new System.Drawing.Point(197, 87);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Werknemers";
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.Location = new System.Drawing.Point(197, 166);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnVerander);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.lbxWerknemers);
            this.MinimumSize = new System.Drawing.Size(300, 241);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Werknemer Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWerknemers;
        private System.Windows.Forms.Button btnMaakAan;
        private System.Windows.Forms.Button btnVerander;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprint;
    }
}

