namespace MaandelijkseLonenPW1
{
    partial class WerknemerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.txtAnderGeslacht = new System.Windows.Forms.TextBox();
            this.rbAndere = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtRijsknr = new System.Windows.Forms.TextBox();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.dtpGeboorte = new System.Windows.Forms.DateTimePicker();
            this.dtpIndienst = new System.Windows.Forms.DateTimePicker();
            this.cbxFunctie = new System.Windows.Forms.ComboBox();
            this.numUren = new System.Windows.Forms.NumericUpDown();
            this.checkWagen = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.epIBAN = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUren = new System.Windows.Forms.ErrorProvider(this.components);
            this.EPRijksregister = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAnderGeslacht = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNaam = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGeslacht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIBAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRijksregister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAnderGeslacht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rijksregisternr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IBAN:";
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGeslacht.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGeslacht.Controls.Add(this.txtAnderGeslacht);
            this.gbGeslacht.Controls.Add(this.rbAndere);
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbGeslacht.Location = new System.Drawing.Point(15, 84);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(236, 100);
            this.gbGeslacht.TabIndex = 6;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht:";
            // 
            // txtAnderGeslacht
            // 
            this.txtAnderGeslacht.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtAnderGeslacht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnderGeslacht.Location = new System.Drawing.Point(75, 64);
            this.txtAnderGeslacht.Name = "txtAnderGeslacht";
            this.txtAnderGeslacht.Size = new System.Drawing.Size(138, 20);
            this.txtAnderGeslacht.TabIndex = 4;
            this.txtAnderGeslacht.TextChanged += new System.EventHandler(this.txtAnderGeslacht_TextChanged);
            // 
            // rbAndere
            // 
            this.rbAndere.AutoSize = true;
            this.rbAndere.Location = new System.Drawing.Point(7, 67);
            this.rbAndere.Name = "rbAndere";
            this.rbAndere.Size = new System.Drawing.Size(62, 17);
            this.rbAndere.TabIndex = 3;
            this.rbAndere.Text = "Andere:";
            this.rbAndere.UseVisualStyleBackColor = true;
            this.rbAndere.CheckedChanged += new System.EventHandler(this.rbAndere_CheckedChanged);
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(7, 44);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 2;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(7, 20);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 1;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "geboortedatum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum Indiensttreding:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Functie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gespresteerde uren:";
            // 
            // txtNaam
            // 
            this.txtNaam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaam.Location = new System.Drawing.Point(131, 6);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(120, 20);
            this.txtNaam.TabIndex = 12;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // txtRijsknr
            // 
            this.txtRijsknr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRijsknr.Location = new System.Drawing.Point(131, 32);
            this.txtRijsknr.Name = "txtRijsknr";
            this.txtRijsknr.Size = new System.Drawing.Size(120, 20);
            this.txtRijsknr.TabIndex = 13;
            this.txtRijsknr.TextChanged += new System.EventHandler(this.txtRijsknr_TextChanged);
            // 
            // txtIban
            // 
            this.txtIban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIban.Location = new System.Drawing.Point(131, 58);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(120, 20);
            this.txtIban.TabIndex = 14;
            this.txtIban.TextChanged += new System.EventHandler(this.txtIban_TextChanged);
            // 
            // dtpGeboorte
            // 
            this.dtpGeboorte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpGeboorte.CustomFormat = "dd MMM yyyy";
            this.dtpGeboorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGeboorte.Location = new System.Drawing.Point(131, 191);
            this.dtpGeboorte.Name = "dtpGeboorte";
            this.dtpGeboorte.Size = new System.Drawing.Size(120, 20);
            this.dtpGeboorte.TabIndex = 15;
            // 
            // dtpIndienst
            // 
            this.dtpIndienst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIndienst.CustomFormat = "dd MMM yyyy";
            this.dtpIndienst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIndienst.Location = new System.Drawing.Point(131, 217);
            this.dtpIndienst.Name = "dtpIndienst";
            this.dtpIndienst.Size = new System.Drawing.Size(120, 20);
            this.dtpIndienst.TabIndex = 16;
            // 
            // cbxFunctie
            // 
            this.cbxFunctie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFunctie.FormattingEnabled = true;
            this.cbxFunctie.Location = new System.Drawing.Point(131, 243);
            this.cbxFunctie.Name = "cbxFunctie";
            this.cbxFunctie.Size = new System.Drawing.Size(120, 21);
            this.cbxFunctie.TabIndex = 17;
            this.cbxFunctie.SelectedIndexChanged += new System.EventHandler(this.cbxFunctie_SelectedIndexChanged);
            // 
            // numUren
            // 
            this.numUren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUren.Location = new System.Drawing.Point(131, 270);
            this.numUren.Maximum = new decimal(new int[] {
            38,
            0,
            0,
            0});
            this.numUren.Name = "numUren";
            this.numUren.Size = new System.Drawing.Size(120, 20);
            this.numUren.TabIndex = 18;
            this.numUren.Value = new decimal(new int[] {
            38,
            0,
            0,
            0});
            this.numUren.ValueChanged += new System.EventHandler(this.numUren_ValueChanged);
            // 
            // checkWagen
            // 
            this.checkWagen.AutoSize = true;
            this.checkWagen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkWagen.Location = new System.Drawing.Point(12, 296);
            this.checkWagen.Name = "checkWagen";
            this.checkWagen.Size = new System.Drawing.Size(134, 17);
            this.checkWagen.TabIndex = 19;
            this.checkWagen.Text = "Bedrijfswagen:             ";
            this.checkWagen.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(195, 314);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // epIBAN
            // 
            this.epIBAN.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epIBAN.ContainerControl = this;
            // 
            // epUren
            // 
            this.epUren.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epUren.ContainerControl = this;
            // 
            // EPRijksregister
            // 
            this.EPRijksregister.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EPRijksregister.ContainerControl = this;
            // 
            // epAnderGeslacht
            // 
            this.epAnderGeslacht.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epAnderGeslacht.ContainerControl = this;
            // 
            // epNaam
            // 
            this.epNaam.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNaam.ContainerControl = this;
            // 
            // WerknemerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 349);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkWagen);
            this.Controls.Add(this.numUren);
            this.Controls.Add(this.cbxFunctie);
            this.Controls.Add(this.dtpIndienst);
            this.Controls.Add(this.dtpGeboorte);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.txtRijsknr);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(298, 388);
            this.Name = "WerknemerForm";
            this.Text = "Nieuwe Werknemer";
            this.Load += new System.EventHandler(this.WerknemerForm_Load);
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIBAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRijksregister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAnderGeslacht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.TextBox txtAnderGeslacht;
        private System.Windows.Forms.RadioButton rbAndere;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtRijsknr;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.DateTimePicker dtpGeboorte;
        private System.Windows.Forms.DateTimePicker dtpIndienst;
        private System.Windows.Forms.ComboBox cbxFunctie;
        private System.Windows.Forms.NumericUpDown numUren;
        private System.Windows.Forms.CheckBox checkWagen;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider epIBAN;
        private System.Windows.Forms.ErrorProvider epUren;
        private System.Windows.Forms.ErrorProvider EPRijksregister;
        private System.Windows.Forms.ErrorProvider epAnderGeslacht;
        private System.Windows.Forms.ErrorProvider epNaam;
    }
}