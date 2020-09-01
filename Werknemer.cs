using System;
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
        DateTime datumVanIndiesttreding;
        string iban;
        int startloon = 1900;

        public Werknemer(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, string iban,
            DateTime datumVanIndiesttreding)
        {
            this.naam = naam;
            this.geslacht = geslacht;
            this.geboorteDatum = geboorteDatum;
            this.rijksregisternummer = rijksregisternummer;
            this.datumVanIndiesttreding = datumVanIndiesttreding;
            this.iban = iban;
        }

        public double StartloonBerekening(int gepresteerdeUren = 38)
        {
            return gepresteerdeUren/38 * startloon;
        }

        public double LoonNaAncienniteitBerekening(int gepresteerdeUren = 38)
        {
            double ancienniteit = StartloonBerekening(gepresteerdeUren);

            for (int i = 1; i <= (DateTime.Now.Year - datumVanIndiesttreding.Year); i++)
            {
                ancienniteit *= 1.01;
            }

            return ancienniteit;
        }

        public double Ancienniteit(int gepresteerdeUren = 38)
        {

            return LoonNaAncienniteitBerekening(gepresteerdeUren) - StartloonBerekening(gepresteerdeUren);
        }

        public double LoonNaSocialeZekerheid(int gepresteerdeUren = 38)
        {
            return LoonNaAncienniteitBerekening(gepresteerdeUren) - 200;
        }

        public double Bedrijfsvoorheffing( int gepresteerdeUren = 38)
        {
            return LoonNaSocialeZekerheid(gepresteerdeUren) * 0.1368;
        }

        public double BerekenNettoLoon(int gepresteerdeUren = 38)
        {
            return LoonNaSocialeZekerheid(gepresteerdeUren) - Bedrijfsvoorheffing(gepresteerdeUren);
        }
    }
}
