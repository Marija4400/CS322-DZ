using System.Linq.Expressions;

namespace CS322_DZ06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zaposleni lekar = new Lekar("Marija", "Milovanovic", "2342321", "Stomatolog", "EuroMedik","Stomatologija", "Oralna hirurgija");
            Zaposleni medsestra = new MedSestra("Tijana", "Peric", "3232323232", "glavna sestra", "Bel medic", 120000.6, 3);
            Zaposleni lekar2 = new Lekar("Lekar", "Lekaric", "333333333", "Lekar", "Ordinacija", "Lekar", "Hirurg");



            Console.WriteLine(lekar.PrikaziInformacije());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(medsestra.PrikaziInformacije());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(lekar2.PrikaziInformacije());
        }
    }
}