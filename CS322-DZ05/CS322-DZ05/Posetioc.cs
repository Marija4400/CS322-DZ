using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ05
{
    internal class Posetioc
    {
        public String Ime { set; get; }
        public String Prezime { set; get; }

        public int BrojUlaznice { set; get; }

        public Posetioc() { }

        public Posetioc(string ime, string prezime, int brojUlaznice)
        {
            Ime = ime;
            Prezime = prezime;
            BrojUlaznice = brojUlaznice;
        }

        public String Ispis() {
            return Ime + " " + Prezime + " " + BrojUlaznice;
        }

    }

}
