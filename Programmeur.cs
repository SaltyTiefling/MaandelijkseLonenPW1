using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonenPW1
{
    class Programmeur : Werknemer
    {
        int startloon = 2200;
        bool bedrijfswagen;

        public Programmeur(string naam, string geslacht, DateTime geboorteDatum, string rijksregisternummer, string iban,
            DateTime datumVanIndiesttreding, bool bedrijfswagen = false) 
            : base(naam,geslacht,geboorteDatum,rijksregisternummer,iban,datumVanIndiesttreding){}


    }
}
