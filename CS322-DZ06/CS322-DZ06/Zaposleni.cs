using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06
{
    internal abstract class Zaposleni: Metode
    {
        protected Zaposleni(string ime, string prezime, string jMBG, string zvanje, string ustanova)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jMBG;
            Zvanje = zvanje;
            Ustanova = ustanova;
        }

        public String Ime {  get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }
        public String Zvanje { get; set; }
        public String Ustanova {  get; set; }

        public abstract string PrikaziInformacije();
    }
}
