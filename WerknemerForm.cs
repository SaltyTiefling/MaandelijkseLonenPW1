using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaandelijkseLonenPW1
{
    public partial class WerknemerForm : Form
    {
        public Werknemer werknemer { get; set; } = null;
        public WerknemerForm()
        {
            InitializeComponent();
        }

        public WerknemerForm(Werknemer werknemer)
        {
            this.werknemer = werknemer;
            InitializeComponent();
        }

        private void WerknemerForm_Load(object sender, EventArgs e)
        {
            cbxFunctie.Items.Add("Werknemer");
            cbxFunctie.Items.Add("Programmeur");
            cbxFunctie.Items.Add("Support");
            cbxFunctie.Items.Add("IT support");
            cbxFunctie.Items.Add("Costumer support");

            txtNaam.Text = werknemer.naam;
            txtRijsknr.Text = werknemer.rijksregisternummer;
            txtIban.Text = werknemer.iban;
            switch (werknemer.geslacht.ToLower())
            {
                case "man":
                    rbMan.Checked = true;
                    break;
                case "vrouw":
                    rbVrouw.Checked = true;
                    break;
                default:
                    rbAndere.Checked = true;
                    txtAnderGeslacht.Text = werknemer.geslacht;
                    break;
            }
            dtpGeboorte.Value = werknemer.geboorteDatum;
            dtpIndienst.Value = werknemer.datumVanIndiesttreding;
            //combobox
            switch (werknemer.GetType().Name.ToLower())
            {
                case "werknemer":
                    cbxFunctie.SelectedItem = "Werknemer";
                    break;
                case "programmeur":
                    cbxFunctie.SelectedItem = "Programmeur";
                    break;
                case "support":
                    cbxFunctie.SelectedItem = "Support";
                    break;
                case "itsupport":
                    cbxFunctie.SelectedItem = "IT support";
                    break;
                case "costumersupport":
                    cbxFunctie.SelectedItem = "Costumer support";
                    break;
                default:
                    cbxFunctie.SelectedIndex = 0;
                    break;
            }
            cbxFunctie_SelectedIndexChanged(sender,e);
            numUren.Value = werknemer.gepresteerdeUren;
            //checkbox auto
            if (werknemer.GetType().Name.ToLower() == "programmeur")
            {
               checkWagen.Checked = (werknemer as Programmeur).bedrijfswagen;
            }

        }

        private void cbxFunctie_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkWagen.Enabled = cbxFunctie.SelectedItem == "Programeur";
            numUren_ValueChanged(sender, e);
            NoErrors();
        }

        private void numUren_ValueChanged(object sender, EventArgs e)
        {
            NoErrors();
        }
        private bool NoErrors()
        {
            bool result = true;
           
            if (cbxFunctie.SelectedItem == "IT support" && numUren.Value < 38)
            {
                epUren.SetError(numUren, "Een IT support medewerker mag niet minder dan voltijds (38u) per week werken");
                result = false;
            }
            else
            {
                epUren.Clear();
            }

            if (!Regex.IsMatch(txtIban.Text, @"[A-Z][A-Z]\d{2} \d{4} \d{4} \d{4}"))
            {
                epIBAN.SetError(txtIban, "geef een geldig IBAN in (bv. BE12 1234 5678 9100)");
                result = false;
            }
            else
            {
                epIBAN.Clear();
            }

            if (!Regex.IsMatch(txtRijsknr.Text, @"\d{2}.\d{2}.\d{2}-\d{3}.\d{2}"))
            {
                EPRijksregister.SetError(txtRijsknr, "geef een geldig rijksregisternummer in (bv. 95.02.01-002.00)");
                result = false;
            }
            else
            {
                EPRijksregister.Clear();
            }

            if (txtNaam.Text == string.Empty)
            {
                epNaam.SetError(txtNaam,"geef naam in");
                result = false;
            }
            else
            {
                epNaam.Clear();
            }

            if (rbAndere.Checked == true && txtAnderGeslacht.Text == string.Empty)
            {
                epAnderGeslacht.SetError(txtAnderGeslacht,"geef je geslacht in");
                result = false;
            }
            else
            {
                epAnderGeslacht.Clear();
            }

            btnOk.Enabled = result;

            return result;
        }

        private void txtIban_TextChanged(object sender, EventArgs e)
        {
            NoErrors();
        }

        private void txtRijsknr_TextChanged(object sender, EventArgs e)
        {
            NoErrors();
        }

        private void txtAnderGeslacht_TextChanged(object sender, EventArgs e)
        {
            NoErrors();
        }

        private void rbAndere_CheckedChanged(object sender, EventArgs e)
        {
            NoErrors();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string geslacht = gbGeslacht.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault().Text;
            if (geslacht.Equals(rbAndere.Text))
            {
                geslacht = txtAnderGeslacht.Text;
            }

            switch (cbxFunctie.SelectedItem.ToString().ToLower())
            {
                default:
                    werknemer = new Werknemer(txtNaam.Text,geslacht,dtpGeboorte.Value,txtRijsknr.Text,txtIban.Text,
                        dtpGeboorte.Value,gepresteerdeUren: (int)numUren.Value);
                    break;
                case "programmeur":
                    werknemer = new Programmeur(txtNaam.Text, geslacht, dtpGeboorte.Value, txtRijsknr.Text, txtIban.Text,
                        dtpGeboorte.Value, checkWagen.Checked, gepresteerdeUren: (int)numUren.Value);
                    break;
                case "support":
                    werknemer = new Support(txtNaam.Text, geslacht, dtpGeboorte.Value, txtRijsknr.Text, txtIban.Text,
                        dtpGeboorte.Value, gepresteerdeUren: (int)numUren.Value);
                    break;
                case "it support":
                    werknemer = new ITSupport(txtNaam.Text, geslacht, dtpGeboorte.Value, txtRijsknr.Text, txtIban.Text,
                        dtpGeboorte.Value);
                    break;
                case "costumer support":
                    werknemer = new CostumerSupport(txtNaam.Text, geslacht, dtpGeboorte.Value, txtRijsknr.Text, txtIban.Text,
                        dtpGeboorte.Value, gepresteerdeUren: (int)numUren.Value);
                    break;
            }

            DialogResult = DialogResult.OK;
        }

        private void txtNaam_TextChanged(object sender, EventArgs e)
        {
            NoErrors();
        }
    }
}
