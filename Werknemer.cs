﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonenPW1
{
    public class Werknemer
    {
        string naam;
        string geslacht;
        DateTime geboorteDatum;
        string rijksregisternummer;
        public DateTime datumVanIndiesttreding;
        string iban;
        double startloon;
        public int gepresteerdeUren;

        public Werknemer(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, string iban,
            DateTime datumVanIndiesttreding, double startloon = 1900, int gepresteerdeUren = 38)
        {
            this.naam = naam;
            this.geslacht = geslacht;
            this.geboorteDatum = geboorteDatum;
            this.rijksregisternummer = rijksregisternummer;
            this.datumVanIndiesttreding = datumVanIndiesttreding;
            this.iban = iban;
            this.startloon = startloon;
            this.gepresteerdeUren = gepresteerdeUren; 
        }

        public virtual double StartloonBerekening()
        {
            return gepresteerdeUren/38 * startloon;
        }

        public virtual double LoonNaAncienniteitBerekening()
        {
            double ancienniteit = StartloonBerekening();

            for (int i = 1; i <= (DateTime.Now.Year - datumVanIndiesttreding.Year); i++)
            {
                ancienniteit *= 1.01;
            }

            return ancienniteit;
        }

        public double Ancienniteit()
        {
            return LoonNaAncienniteitBerekening() - StartloonBerekening();
        }

        public double LoonNaSocialeZekerheid()
        {
            return LoonNaAncienniteitBerekening() - 200;
        }

        public virtual double Bedrijfsvoorheffing( )
        {
            return LoonNaSocialeZekerheid() * 0.1368;
        }

        public virtual double BerekenNettoLoon()
        {
            return LoonNaSocialeZekerheid() - Bedrijfsvoorheffing();
        }

        public override string ToString()
        {
            return $"{naam} ({ this.GetType().Name})";
        }
    }
}
