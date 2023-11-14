using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06
{
    internal class Lekar : Zaposleni
    {
        public Lekar(string ime, string prezime, string jMBG, string zvanje, string ustanova, string Odeljenje, string Specijalizacija ) : base(ime, prezime, jMBG, zvanje, ustanova)
        {
            this.Odeljenje = Odeljenje;
            this.Specijalizacija = Specijalizacija;
        }

        public String Odeljenje {  get; set; }

        public String Specijalizacija { get; set; }

      

        public override string PrikaziInformacije()
        {
           return "Informacije o lekaru: \n Ime:" + Ime + " ,\n Prezime: " + Prezime + " ,\n JMBG: " + JMBG + " ,\n Zvanje: " + Zvanje + " ,\n Ustanova: " + Ustanova + " ,\n Odeljenje: " + Odeljenje + " ,\n Specijalizacija: " + Specijalizacija;
        }
    }



}
