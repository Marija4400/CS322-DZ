namespace CS322_DZ05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Posetioc posetioc = new Posetioc(Pomocna.GenerisiRec(),Pomocna.GenerisiRec(),Pomocna.GenerisiRandomBroj());
            Posetioc posetioc1 = new Posetioc(Pomocna.GenerisiRec(),Pomocna.GenerisiRec(),Pomocna.GenerisiRandomBroj());

            Console.WriteLine(posetioc.Ispis());
            Console.WriteLine(posetioc1.Ispis());
            


            Console.Write("Unesite broj za sttepenovanje (x): ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite vrednost stepena (n): ");
            double n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Vrednost stepena ne moze biti manja od 0");
            }
            else
            {
                double rezultat = Stepenovanje(x, n);

                Console.WriteLine($"Rezultat stepenovanja broja {x} na stepen {n} je {rezultat}");

            }


           
        }

        private static double Stepenovanje(double x, double n)
        {
            if(x ==0 && n == 0)
            {
                Console.WriteLine("Nije definisano stepenovanje 0 na 0");
                return 0;
                
            }
            else if(n == 1){
                return x;
            }

            double rezultat = 1;

            for(int i =0; i < n; i++)
            {
                rezultat *= x;
            }
            return rezultat;
        }
    }


}

