using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06
{
    internal class MedSestra: Zaposleni
    {
        public MedSestra(string ime, string prezime, string jMBG, string zvanje, string ustanova, Double Plata, int RadniStaz) : base(ime, prezime, jMBG, zvanje, ustanova)
        {
            this.Plata = Plata;
            this.RadniStaz = RadniStaz;
        }

        public Double Plata { get; set; }
        public int RadniStaz {  get; set; }

        public override string PrikaziInformacije()
        {
            return $" Informacije o Medicinskoj sestri: \nIme: {Ime},\nprezime: {Prezime},\nJMBG: {JMBG},\nzvanje: {Zvanje},\nustanova: {Ustanova},\nplata: {Plata},\nradni staz: {RadniStaz}";
        }
    }
}
