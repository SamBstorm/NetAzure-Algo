namespace ExoBonus01_TourTerre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             A l'aide du Rayon de la terre (6371km), calculez une distance donnée en nombre de tour effectué.

            Exemple : 
            53.000km donne 1 tour et 12969.826408 km
             */

            const int RAYON = 6371;
            int tour, distance;
            double circonference, km;

            Console.WriteLine("Veuillez indiquer une distance en km :");
            distance = int.Parse(Console.ReadLine());
            circonference = (2 * RAYON * Math.PI);
            tour = (int)(distance / circonference) ;
            km = distance % circonference;

            Console.WriteLine($"{distance} km donne {tour} tour(s) et {km} km.");
        }
    }
}