using System.Runtime.InteropServices;

namespace CS322_DZ04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 1 - Ispisati sumu neparnih brojeva od 1 do n.");

            Console.WriteLine("Unesite broj n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int zbirNeparnih = 0;

            for(int i =0; i < n; i++)
            {
                if(i % 2 != 0)
                {
                    zbirNeparnih =+i;
                }

            }
            Console.WriteLine($"Zbir neparnih brojeva iznosi: {zbirNeparnih}" );


            Console.WriteLine("********************************************************");
            Console.WriteLine("Zadatak 2 - Ispisati dvostruku vrednost prirodnih brojeva od 8 do 16 unazad.");

            for(int i = 16; i>=8; i--)
            {
                int dvostrukaVrednostBroja = i * 2;
                Console.WriteLine($"Dvostruka vrednost brojeava je: {dvostrukaVrednostBroja}");

            }

            // Napisati program koji učitava sa standardnog ulaza prirodan broj manji od milijarde i na
            //standardni izlaz ispisuje da li cifre tog broja obrazuju strogo rastući niz. Na primer, cifre broja
            //118 ne obrazuju strogo rastući niz, cifre broja 8876551 ne obrazuju strogo rastući niz, dok
            //cifre broja 1234569 obrazuju strogo rastući niz.

            Console.WriteLine("**********************Zadatak 3 ******************");
            Console.WriteLine("Unesite broj manji od milijarde: ");
            string unos = Console.ReadLine();

            if (ValidanUnos(unos))
            {
                bool strogoRastuci = DaLiJeStrogoRastuci(unos);
                if (strogoRastuci)
                {
                    Console.WriteLine("Cifra koju ste uneli je strogo rastuci niz.");
                }
                else { Console.WriteLine("Cifra koju ste uneli ne obrazuje strogo rastuci niz."); }
            }
            else
            {
                Console.WriteLine("Uneli ste broj koji nije manji od milijarde.");
            }


        }

        static bool ValidanUnos(string unos)
        {
            int broj;
            return int.TryParse(unos, out broj) && broj>0 && broj < 1000000000;

        }

        static bool DaLiJeStrogoRastuci(string unos)
        {
            for(int i = 0;i< unos.Length-i; i++)
            {
                if (unos[i] >= unos[i + 1])
                {
                    return false;
                }
            } return true;
        }
    }
}