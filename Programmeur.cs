using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonenPW1
{
    class Programmeur : Werknemer
    {
        bool bedrijfswagen;

        public Programmeur(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, string iban,
            DateTime datumVanIndiesttreding, bool bedrijfswagen = false,int startloon = 2200)
            : base(naam, geslacht, geboorteDatum, rijksregisternummer, iban, datumVanIndiesttreding, startloon)
        {
            this.bedrijfswagen = bedrijfswagen;
        }

        public override double Bedrijfsvoorheffing(int gepresteerdeUren = 38)
        {
            if (bedrijfswagen)
            {
                return LoonNaSocialeZekerheid(gepresteerdeUren) * 0.173;
            }
            return base.Bedrijfsvoorheffing(gepresteerdeUren);
        }
    }
}
