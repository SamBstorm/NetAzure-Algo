namespace Demo_Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Boucle While
            int nombre;
            Console.WriteLine("Entrez un nombre entre 1 et 10");
            nombre = int.Parse(Console.ReadLine());
            while ((nombre < 1) || (nombre > 10))
            {
                Console.WriteLine("Nombre incorrect ! Réessayez.");
                nombre = int.Parse(Console.ReadLine());
            }
            */
            /*Boucle do while()
             
             */

            int nombre;
            string message = "Entrez un nombre entre 1 et 10";
            do
            {
                Console.WriteLine(message);
                nombre = int.Parse(Console.ReadLine());
                message = "Nombre incorrect ! Réessayez.";
            } while ((nombre < 1) || (nombre > 10)) ;

        }
    }
}