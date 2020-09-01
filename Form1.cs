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
    public partial class Form1 : Form
    {
        List<Werknemer> werknemers = new List<Werknemer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Werknemer jack = new Werknemer("Jack Michelson","Male",new DateTime(1958,8,29), "95.02.01-002.00","BE12 1234 5678 9100", new DateTime(2015, 09, 07)) ;
            Programmeur pieter = new Programmeur("Pieter Janssens","Man", new DateTime(1991,01,12),"910112-18-31","BE01 9876 5432 1234", new DateTime(2018, 7,18),true);

            werknemers.Add(jack);
            werknemers.Add(pieter);


        }
    }
}
