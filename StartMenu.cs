using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaandelijkseLonenPW1
{
    public partial class StartMenu : Form
    {
        List<Werknemer> werknemers = new List<Werknemer>();
        public StartMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Werknemer jack = new Werknemer("Jack Michelson","Male",new DateTime(1958,8,29), "95.02.01-002.00","BE12 1234 5678 9100", new DateTime(2015, 09, 07)) ;
            Programmeur pieter = new Programmeur("Pieter Janssens","Man", new DateTime(1991,01,12), "91.01.12-018.31", "BE01 9876 5432 1234", new DateTime(2018, 7,18),true);

            werknemers.Add(jack);
            werknemers.Add(pieter);

            LaadWerknemers();
        }

        private void LaadWerknemers()
        {
            lbxWerknemers.DataSource = null;
            lbxWerknemers.DataSource = werknemers;
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lbxWerknemers != null)
            {
                werknemers.RemoveAt(lbxWerknemers.SelectedIndex);
            }
            LaadWerknemers();
        }

        private void btnVerander_Click(object sender, EventArgs e)
        {
            if (lbxWerknemers != null)
            {
                WerknemerForm werknemer = new WerknemerForm(lbxWerknemers.SelectedItem as Werknemer);
                if (werknemer.ShowDialog() == DialogResult.OK)
                {
                    btnVerwijder_Click(sender, e);
                    werknemers.Add(werknemer.werknemer);
                }
            }
            LaadWerknemers();
        }

        private void btnMaakAan_Click(object sender, EventArgs e)
        {
            WerknemerForm nieuwewerknemer = new WerknemerForm();
            if (nieuwewerknemer.ShowDialog() == DialogResult.OK)
            {
                werknemers.Add(nieuwewerknemer.werknemer);
            }

            LaadWerknemers();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }
    }
}
