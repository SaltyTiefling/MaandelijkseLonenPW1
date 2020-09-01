using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonenPW1
{
    public class ITSupport : Support
    {
        public ITSupport(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, string iban,
            DateTime datumVanIndiesttreding, double startloon = 2050)
            : base(naam, geslacht, geboorteDatum, rijksregisternummer, iban, datumVanIndiesttreding, startloon)
        {
        }

        public override double LoonNaAncienniteitBerekening()
        {
            double sixPercentLowering = StartloonBerekening() * 0.06; 
            double ancienniteit = StartloonBerekening() *sixPercentLowering;

            for (int i = 1; i <= (DateTime.Now.Year - datumVanIndiesttreding.Year); i++)
            {
                ancienniteit *= 1.01;
            }
            ancienniteit += sixPercentLowering;
            return ancienniteit;
        }

        public override double BerekenNettoLoon()
        {
            if (gepresteerdeUren < 38)
            {
                throw new ArgumentException("Een IT support medewerker mag niet minder dan voltijds (38u) per week werken");
            }
            return base.BerekenNettoLoon();
        }

    }
}
