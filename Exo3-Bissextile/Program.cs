namespace Exo3_Bissextile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annee;
            Console.WriteLine("Veuillez introduire votre année : ");
            annee = int.Parse(Console.ReadLine());
            if( annee % 400 == 0 || ( annee % 100 != 0 && annee % 4 == 0)) {
                Console.WriteLine($"L'année {annee} est une année bissextile!");
            }
            else
            {
                Console.WriteLine($"L'année {annee} n'est pas une année bissextile...");
            }


            //OU
            /*
            int annee;
            Console.WriteLine("Veuillez introduire votre année : ");
            if(annee % 4 == 0 && annee % 100 != 0) {
                Console.WriteLine($"L'année {annee} est une année bissextile!");
            }
            else if (annee % 400 == 0) { 
                Console.WriteLine($"L'année {annee} est une année bissextile!");
            }
            else{
                Console.WriteLine($"L'année {annee} n'est pas une année bissextile...");
            }
             */
        }
    }
}