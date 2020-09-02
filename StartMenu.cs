using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            Werknemer jack = new Werknemer("Jack Michelson", "Man", new DateTime(1958, 8, 29), "95.02.01-002.00", "NL01 9876 5432 1234", new DateTime(2015, 09, 07), gepresteerdeUren: 19);
            Programmeur pieter = new Programmeur("Pieter Janssens", "Man", new DateTime(1991, 01, 12), "91.01.12-018.31", "BE01 9876 5432 1234", new DateTime(2018, 7, 18), true);
            CostumerSupport karel = new CostumerSupport("Karel Pieters", "Vrouw", new DateTime(1991, 01, 12), "95.02.01-002.00", "BE12 1234 5678 9100", new DateTime(2015, 09, 07));

            werknemers.Add(jack);
            werknemers.Add(pieter);
            werknemers.Add(karel);

            LaadWerknemers();
        }

        private void LaadWerknemers()
        {
            lbxWerknemers.DataSource = null;
            lbxWerknemers.DataSource = werknemers;
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lbxWerknemers != null && lbxWerknemers.SelectedIndex != null)
            {
                werknemers.RemoveAt(lbxWerknemers.SelectedIndex);
            }
            LaadWerknemers();
        }

        private void btnVerander_Click(object sender, EventArgs e)
        {
            if (lbxWerknemers != null && lbxWerknemers.SelectedIndex != null)
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
            string totaalkostenBedrijf = "";
            double loonKosten = 0;

            string mapname = $"LOONBRIEVEN {DateTime.Now.ToString("MMMM yyyy").ToUpper()}\\";

            if (!Directory.Exists(mapname))
            {
                Directory.CreateDirectory(mapname);
            }

            foreach (Werknemer werknemer in werknemers)
            {
                string filename = mapname + $"LOONBRIEF {werknemer.naam.ToUpper()} {werknemer.rijksregisternummer.Replace(".", "")} {DateTime.Now.ToString("MM-yyyy")}.txt";

                File.Delete(filename);


                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(new string('-', 50));
                    writer.WriteLine($"LOONBRIEF {DateTime.Now.ToString("MMMM yyyy").ToUpper()}");
                    writer.WriteLine(new string('-', 50));
                    writer.WriteLine($"NAAM                     : {werknemer.naam}");
                    writer.WriteLine($"RIJKSREGISTERNUMMER      : {werknemer.rijksregisternummer}");
                    writer.WriteLine($"GESLACHT                 : {werknemer.geslacht}");
                    writer.WriteLine($"GEBOORTEDATUM            : {werknemer.geboorteDatum.ToString("dd MMMM yyyy")}");
                    writer.WriteLine($"DATUM INDIENSTTREDING    : {werknemer.datumVanIndiesttreding.ToString("dd MMMM yyyy")}");
                    writer.WriteLine($"FUNCTIE                  : {werknemer.GetType().Name}");
                    writer.WriteLine($"AANTAL GEPRESTEERDE UREN : {werknemer.gepresteerdeUren}/38");
                    if (werknemer.GetType().Name == "Programmeur")
                    {
                        writer.Write($"BEDRIJFSWAGEN            : ");
                        if ((werknemer as Programmeur).bedrijfswagen)
                        {
                            writer.WriteLine("JA");
                        }
                        else
                        {
                            writer.WriteLine("NEE");
                        }
                    }
                    writer.WriteLine(new string('-', 50));

                    writer.WriteLine($"STARTLOON                :   € {ShowDouble(werknemer.StartloonBerekening())}");
                    writer.WriteLine($"ANCIËNNITEIT             : + € {ShowDouble(werknemer.Ancienniteit())}");
                    writer.WriteLine($"                         :   € {ShowDouble(werknemer.LoonNaAncienniteitBerekening())}");
                    writer.WriteLine($"SOCIALE ZEKERHEID        : - € {ShowDouble(werknemer.LoonNaAncienniteitBerekening() - werknemer.LoonNaSocialeZekerheid())}");
                    writer.WriteLine($"                         :   € {ShowDouble(werknemer.LoonNaSocialeZekerheid())}");
                    writer.WriteLine($"BEDRIJFSVOORHEFFING      : - € {ShowDouble(werknemer.Bedrijfsvoorheffing())}");
                    writer.WriteLine($"                         :   € {ShowDouble(werknemer.LoonNaBedrijfsvoorheffing())}");
                    if (werknemer.GetType().Name.ToLower().Contains("support"))
                    {
                        writer.WriteLine($"THUISWERKBONUS           : + € {ShowDouble(50)}");
                        if (werknemer.GetType().Name.ToLower() == "costumersupport")
                        {
                            writer.WriteLine($"OPLEIDING                : + € {ShowDouble(19.5)}");
                        }
                    }

                    writer.WriteLine($"NETTOLOON                :   € {ShowDouble(werknemer.BerekenNettoLoon())}");

                }

                totaalkostenBedrijf += $"{werknemer.naam.PadRight(30, ' ')} + € {ShowDouble(werknemer.BerekenNettoLoon())}\n";
                loonKosten += werknemer.BerekenNettoLoon();
                readtextfile readtextfile = new readtextfile(filename);
                readtextfile.Show();
            }
            File.Delete(mapname + $"LOONKOSTEN {DateTime.Now.ToString("MMMM yyyy").ToUpper()}.txt");
            using (StreamWriter writer = new StreamWriter(mapname + $"LOONKOSTEN {DateTime.Now.ToString("MMMM yyyy").ToUpper()}.txt"))
            {
                writer.WriteLine("naam".PadRight(30, ' ') + $"   Nettoloon");

                writer.WriteLine(new string('-', 42));
                writer.Write(totaalkostenBedrijf);
                writer.WriteLine(new string('-', 42));
                writer.WriteLine($"{("totaal:").PadRight(30, ' ')} : € {ShowDouble(loonKosten)}");
            }

        }
        public string ShowDouble(double myNumber)
        {

            return myNumber.ToString("0.00").PadLeft(7, ' ');
        }
    }
}
