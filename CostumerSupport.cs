using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonenPW1
{
    public class CostumerSupport : Support
    {
        public CostumerSupport(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, string iban,
            DateTime datumVanIndiesttreding, double startloon = 2050, int gepresteerdeUren = 38)
            : base(naam, geslacht, geboorteDatum, rijksregisternummer, iban, datumVanIndiesttreding, startloon, gepresteerdeUren)
        {
        }

        public override double BerekenNettoLoon()
        {
            return base.BerekenNettoLoon() + 19.50;
        }

    }
}
