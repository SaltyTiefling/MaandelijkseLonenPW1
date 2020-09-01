using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonenPW1
{
    class Programmeur : Werknemer
    {
        public bool bedrijfswagen;

        public Programmeur(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, string iban,
            DateTime datumVanIndiesttreding, bool bedrijfswagen = false,double startloon = 2200, int gepresteerdeUren = 38)
            : base(naam, geslacht, geboorteDatum, rijksregisternummer, iban, datumVanIndiesttreding, startloon, gepresteerdeUren)
        {
            this.bedrijfswagen = bedrijfswagen;
        }

        public override double Bedrijfsvoorheffing()
        {
            if (bedrijfswagen)
            {
                return LoonNaSocialeZekerheid() * 0.173;
            }
            return base.Bedrijfsvoorheffing();
        }
    }
}
