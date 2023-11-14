using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ05
{
    internal class Pomocna
    {
        private static Random random = new Random();

        public static string GenerisiRec()
        {
            const int duzinaReci = 8;

            char prvoSlovo = (char)('A' + random.Next(26));

            string ostatak = new string(new char[duzinaReci - 1].Select(_ => (char)('a' + random.Next(26))).ToArray());

            string radnomRec = prvoSlovo + ostatak;

            return radnomRec;
        }

        public static int GenerisiRandomBroj()
        {
            int randomBroj = random.Next(1, 201);
            return randomBroj;
        }
    }

}

